#Region " Copyright © 2008 Ashu Fouzdar. All rights reserved."

'Copyright © 2008 Ashu Fouzdar(ashu.fouzdar@gmail.com). All rights reserved.

'Redistribution and use in source and binary forms, with or without
'modification, are permitted provided that the following conditions
'are met:

'1. Redistributions of source code must retain the above copyright
'   notice, this list of conditions and the following disclaimer.
'2. Redistributions in binary form must reproduce the above copyright
'   notice, this list of conditions and the following disclaimer in the
'   documentation and/or other materials provided with the distribution.
'3. The name of the author may not be used to endorse or promote products
'   derived from this software without specific prior written permission.

'THIS SOFTWARE IS PROVIDED BY THE AUTHOR "AS IS" AND ANY EXPRESS OR
'IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
'OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
'IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY DIRECT, INDIRECT,
'INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
'NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
'DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
'THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
'(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
'THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

#End Region

Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class FrmCheckSum
    Private destDir As String = String.Empty
    Private Delegate Sub InsChkSum(ByVal chkSumEntry As chkSumInfo)
    Private Structure chkSumInfo
        Public file1 As String
        Public chkSum1 As StringBuilder
        Public size1 As String

        Public file2 As String
        Public chkSum2 As StringBuilder
        Public size2 As String
        Public result As String
    End Structure

    Private Sub AddChkSum(ByVal chkSumEntry As chkSumInfo)
        Try
            Dim lItem As ListViewItem
            lItem = lstChkSum.Items.Add(chkSumEntry.file1)
            lItem.SubItems.Add(chkSumEntry.chkSum1.ToString())
            lItem.SubItems.Add(chkSumEntry.size1)
            lItem.SubItems.Add(chkSumEntry.file2)
            lItem.SubItems.Add(chkSumEntry.chkSum2.ToString())
            lItem.SubItems.Add(chkSumEntry.size2)
            lItem.SubItems.Add(chkSumEntry.result)

            If chkSumEntry.result.Equals("Different") Then
                lItem.BackColor = Color.Red
                lItem.ForeColor = Color.YellowGreen
            End If

            lblProgress.Text = "Processing file:" + chkSumEntry.file1

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Adding Checksum Entry:" + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnBrowse1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse1.Click
        Try
            If dlgFolder.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.txtSrcDir.Text = dlgFolder.SelectedPath()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Source Directory:" + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnBrowse2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse2.Click
        Try
            If dlgFolder.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.txtDestDir.Text = dlgFolder.SelectedPath()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Dest. Directory:" + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ProcessDir(ByVal dInfo As DirectoryInfo)
        Try
            If Directory.Exists(dInfo.FullName) And Directory.Exists(destDir) Then
                Dim fInfo As FileInfo
                Dim sha1 As SHA1CryptoServiceProvider
                'Iterating through each file
                For Each fInfo In dInfo.GetFiles()
                    Try
                        Dim fColl As String() = Directory.GetFiles(destDir, fInfo.Name, SearchOption.AllDirectories)
                        If Not (fColl Is Nothing) Then

                            If fColl.Length > 0 Then
                                If File.Exists(fColl(0)) Then
                                    Dim tmpfInfo As FileInfo = New FileInfo(fColl(0))

                                    Dim f1 As New FileStream(fInfo.FullName, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                                    Dim f2 As New FileStream(tmpfInfo.FullName, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                                    sha1 = New SHA1CryptoServiceProvider()

                                    Dim hash1 As Byte() = sha1.ComputeHash(f1)
                                    Dim hash2 As Byte() = sha1.ComputeHash(f2)

                                    Dim buff1 As StringBuilder = New StringBuilder
                                    Dim hashByte As Byte
                                    For Each hashByte In hash1
                                        buff1.Append(String.Format("{0:X1}", hashByte))
                                    Next

                                    Dim buff2 As StringBuilder = New StringBuilder
                                    For Each hashByte In hash2
                                        buff2.Append(String.Format("{0:X1}", hashByte))
                                    Next

                                    Dim entryChkSum As New chkSumInfo()
                                    entryChkSum.file1 = fInfo.FullName
                                    entryChkSum.size1 = (fInfo.Length / 1024).ToString()
                                    entryChkSum.chkSum1 = buff1
                                    entryChkSum.file2 = tmpfInfo.FullName
                                    entryChkSum.size2 = (tmpfInfo.Length / 1024).ToString()
                                    entryChkSum.chkSum2 = buff2

                                    If buff1.Equals(buff2) Then
                                        entryChkSum.result = "Identical"
                                    Else
                                        entryChkSum.result = "Different"
                                    End If

                                    Dim dlgt As New InsChkSum(AddressOf AddChkSum)
                                    Me.Invoke(dlgt, entryChkSum)

                                End If
                            End If
                        Else
                            Dim entryChkSum As New chkSumInfo()
                            entryChkSum.file1 = fInfo.FullName
                            entryChkSum.size1 = (fInfo.Length / 1024).ToString()
                            entryChkSum.chkSum1 = New StringBuilder()
                            entryChkSum.file2 = "Not Found"
                            entryChkSum.size2 = "N/A"
                            entryChkSum.chkSum2 = New StringBuilder()
                            entryChkSum.result = "File Missing"
                            Dim dlgt As New InsChkSum(AddressOf AddChkSum)
                            Me.Invoke(dlgt, entryChkSum)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, fInfo.Name + ":" + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Next
                'Processing Sub Directories
                For Each childDir As DirectoryInfo In dInfo.GetDirectories()
                    'Calling with sub directory
                    ProcessDir(childDir)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Process Dir-" + dInfo.Name + " " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Try
            If txtSrcDir.Text <> String.Empty And txtDestDir.Text <> String.Empty Then
                Me.Cursor = Cursors.WaitCursor
                Me.picProcessing.Visible = True
                Me.lblProcessing.Visible = True
                Me.lblProgress.Visible = True
                destDir = Me.txtDestDir.Text
                Me.lstChkSum.Items.Clear()

                Me.btnStart.Enabled = False
                Me.btnBrowse1.Enabled = False
                Me.btnBrowse2.Enabled = False

                bgWrkr.RunWorkerAsync()
            Else
                MessageBox.Show("Please select both directories for comparison", "Required ??", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Start Compare:" + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub bgWrkr_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgWrkr.DoWork
        Call ProcessDir(New DirectoryInfo(txtSrcDir.Text))
    End Sub

    Private Sub bgWrkr_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWrkr.RunWorkerCompleted
        Me.Cursor = Cursors.Arrow

        Me.btnStart.Enabled = True
        Me.btnBrowse1.Enabled = True
        Me.btnBrowse1.Enabled = True

        Me.picProcessing.Visible = False
        Me.lblProcessing.Visible = False
        Me.lblProgress.Visible = False

        If MessageBox.Show("Checksum verfication completed, Do you want to save the report", "Completed", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            btnExportToXL_Click(sender, e)
        End If
    End Sub

    Private Sub btnExportToXL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportToXL.Click
        Try
            If lstChkSum.Items.Count > 0 Then
                If dlgSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Dim strFilename As String = dlgSave.FileName
                    Dim xlStrm As New StreamWriter(strFilename, False)
                    xlStrm.WriteLine("File Name,Checksum,Size,File Name,Checksum,Size,Result")
                    For Each lItem As ListViewItem In lstChkSum.Items
                        xlStrm.WriteLine("{0},{1},{2},{3},{4},{5},{6}", New Object() {lItem.Text, lItem.SubItems(1).Text, lItem.SubItems(2).Text, lItem.SubItems(3).Text, lItem.SubItems(4).Text, lItem.SubItems(5).Text, lItem.SubItems(6).Text})
                    Next
                    xlStrm.Close()
                    MessageBox.Show("Exported the checksum report to XL sheet as:" + strFilename, "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ExportXL" + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
