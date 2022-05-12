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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCheckSum
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCheckSum))
        Me.tblLayoutPanel = New System.Windows.Forms.TableLayoutPanel
        Me.btnBrowse2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSrcDir = New System.Windows.Forms.TextBox
        Me.txtDestDir = New System.Windows.Forms.TextBox
        Me.btnBrowse1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lstChkSum = New System.Windows.Forms.ListView
        Me.File1 = New System.Windows.Forms.ColumnHeader
        Me.CheckSum1 = New System.Windows.Forms.ColumnHeader
        Me.Size1 = New System.Windows.Forms.ColumnHeader
        Me.File2 = New System.Windows.Forms.ColumnHeader
        Me.CheckSum2 = New System.Windows.Forms.ColumnHeader
        Me.Size2 = New System.Windows.Forms.ColumnHeader
        Me.Result = New System.Windows.Forms.ColumnHeader
        Me.btnExportToXL = New System.Windows.Forms.Button
        Me.btnStart = New System.Windows.Forms.Button
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog
        Me.bgWrkr = New System.ComponentModel.BackgroundWorker
        Me.lblProcessing = New System.Windows.Forms.Label
        Me.picProcessing = New System.Windows.Forms.PictureBox
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog
        Me.lblProgress = New System.Windows.Forms.Label
        Me.tblLayoutPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picProcessing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblLayoutPanel
        '
        Me.tblLayoutPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblLayoutPanel.ColumnCount = 6
        Me.tblLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tblLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tblLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblLayoutPanel.Controls.Add(Me.btnBrowse2, 5, 0)
        Me.tblLayoutPanel.Controls.Add(Me.Label1, 0, 0)
        Me.tblLayoutPanel.Controls.Add(Me.Label2, 3, 0)
        Me.tblLayoutPanel.Controls.Add(Me.txtSrcDir, 1, 0)
        Me.tblLayoutPanel.Controls.Add(Me.txtDestDir, 4, 0)
        Me.tblLayoutPanel.Controls.Add(Me.btnBrowse1, 2, 0)
        Me.tblLayoutPanel.Location = New System.Drawing.Point(5, 6)
        Me.tblLayoutPanel.Name = "tblLayoutPanel"
        Me.tblLayoutPanel.RowCount = 1
        Me.tblLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblLayoutPanel.Size = New System.Drawing.Size(583, 32)
        Me.tblLayoutPanel.TabIndex = 0
        '
        'btnBrowse2
        '
        Me.btnBrowse2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse2.Location = New System.Drawing.Point(555, 4)
        Me.btnBrowse2.Name = "btnBrowse2"
        Me.btnBrowse2.Size = New System.Drawing.Size(25, 23)
        Me.btnBrowse2.TabIndex = 3
        Me.btnBrowse2.Text = "..."
        Me.btnBrowse2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Directory"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Directory"
        '
        'txtSrcDir
        '
        Me.txtSrcDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSrcDir.Location = New System.Drawing.Point(103, 5)
        Me.txtSrcDir.Name = "txtSrcDir"
        Me.txtSrcDir.ReadOnly = True
        Me.txtSrcDir.Size = New System.Drawing.Size(155, 21)
        Me.txtSrcDir.TabIndex = 0
        '
        'txtDestDir
        '
        Me.txtDestDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDestDir.Location = New System.Drawing.Point(394, 5)
        Me.txtDestDir.Name = "txtDestDir"
        Me.txtDestDir.ReadOnly = True
        Me.txtDestDir.Size = New System.Drawing.Size(155, 21)
        Me.txtDestDir.TabIndex = 2
        '
        'btnBrowse1
        '
        Me.btnBrowse1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse1.Location = New System.Drawing.Point(264, 4)
        Me.btnBrowse1.Name = "btnBrowse1"
        Me.btnBrowse1.Size = New System.Drawing.Size(24, 23)
        Me.btnBrowse1.TabIndex = 1
        Me.btnBrowse1.Text = "..."
        Me.btnBrowse1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lstChkSum)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 170)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CheckSum Result"
        '
        'lstChkSum
        '
        Me.lstChkSum.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.File1, Me.CheckSum1, Me.Size1, Me.File2, Me.CheckSum2, Me.Size2, Me.Result})
        Me.lstChkSum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstChkSum.Location = New System.Drawing.Point(3, 17)
        Me.lstChkSum.Name = "lstChkSum"
        Me.lstChkSum.Size = New System.Drawing.Size(577, 150)
        Me.lstChkSum.TabIndex = 0
        Me.lstChkSum.UseCompatibleStateImageBehavior = False
        Me.lstChkSum.View = System.Windows.Forms.View.Details
        '
        'File1
        '
        Me.File1.Text = "File"
        Me.File1.Width = 250
        '
        'CheckSum1
        '
        Me.CheckSum1.Text = "CheckSum"
        Me.CheckSum1.Width = 150
        '
        'Size1
        '
        Me.Size1.Text = "Size (KB)"
        '
        'File2
        '
        Me.File2.Text = "File"
        Me.File2.Width = 250
        '
        'CheckSum2
        '
        Me.CheckSum2.Text = "CheckSum"
        Me.CheckSum2.Width = 150
        '
        'Size2
        '
        Me.Size2.Text = "Size (KB)"
        '
        'Result
        '
        Me.Result.Text = "Result"
        Me.Result.Width = 100
        '
        'btnExportToXL
        '
        Me.btnExportToXL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportToXL.Location = New System.Drawing.Point(490, 239)
        Me.btnExportToXL.Name = "btnExportToXL"
        Me.btnExportToXL.Size = New System.Drawing.Size(97, 23)
        Me.btnExportToXL.TabIndex = 3
        Me.btnExportToXL.Text = "Export To XL"
        Me.btnExportToXL.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Location = New System.Drawing.Point(491, 43)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(97, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start Compare"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'bgWrkr
        '
        '
        'lblProcessing
        '
        Me.lblProcessing.AutoSize = True
        Me.lblProcessing.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessing.Location = New System.Drawing.Point(7, 45)
        Me.lblProcessing.Name = "lblProcessing"
        Me.lblProcessing.Size = New System.Drawing.Size(135, 13)
        Me.lblProcessing.TabIndex = 4
        Me.lblProcessing.Text = "Computing Checksum :"
        Me.lblProcessing.Visible = False
        '
        'picProcessing
        '
        Me.picProcessing.Image = Global.ChecksumVerifier.My.Resources.Resources.Processing
        Me.picProcessing.Location = New System.Drawing.Point(142, 48)
        Me.picProcessing.Name = "picProcessing"
        Me.picProcessing.Size = New System.Drawing.Size(100, 10)
        Me.picProcessing.TabIndex = 5
        Me.picProcessing.TabStop = False
        Me.picProcessing.Visible = False
        '
        'dlgSave
        '
        Me.dlgSave.DefaultExt = "csv"
        Me.dlgSave.Filter = "Excel File|*.csv"
        '
        'lblProgress
        '
        Me.lblProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProgress.Location = New System.Drawing.Point(8, 244)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(0, 13)
        Me.lblProgress.TabIndex = 6
        '
        'FrmCheckSum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 266)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.picProcessing)
        Me.Controls.Add(Me.lblProcessing)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnExportToXL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tblLayoutPanel)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCheckSum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CheckSum Verification Tool"
        Me.tblLayoutPanel.ResumeLayout(False)
        Me.tblLayoutPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picProcessing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tblLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExportToXL As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lstChkSum As System.Windows.Forms.ListView
    Friend WithEvents File1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CheckSum1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents File2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CheckSum2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Result As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSrcDir As System.Windows.Forms.TextBox
    Friend WithEvents txtDestDir As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse1 As System.Windows.Forms.Button
    Friend WithEvents btnBrowse2 As System.Windows.Forms.Button
    Friend WithEvents dlgFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Size1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Size2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents bgWrkr As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblProcessing As System.Windows.Forms.Label
    Friend WithEvents picProcessing As System.Windows.Forms.PictureBox
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lblProgress As System.Windows.Forms.Label

End Class
