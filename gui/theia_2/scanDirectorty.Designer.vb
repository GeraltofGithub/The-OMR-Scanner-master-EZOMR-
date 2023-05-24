<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scanDirectorty
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scanDirectorty))
        Me.RightLabel = New System.Windows.Forms.Label()
        Me.WrongLabel = New System.Windows.Forms.Label()
        Me.RightMarksInput = New System.Windows.Forms.NumericUpDown()
        Me.WrongMarksInput = New System.Windows.Forms.NumericUpDown()
        Me.browse_btn = New System.Windows.Forms.Button()
        Me.folderLoc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scanAnsConfirm = New System.Windows.Forms.Button()
        Me.examNameInput = New System.Windows.Forms.TextBox()
        Me.examNameTitle = New System.Windows.Forms.Label()
        Me.animLoad = New System.Windows.Forms.PictureBox()
        Me.minimize = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.print_title = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        CType(Me.RightMarksInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WrongMarksInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.animLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.print_title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RightLabel
        '
        Me.RightLabel.AutoSize = True
        Me.RightLabel.Font = New System.Drawing.Font("Yu Gothic UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.RightLabel.ForeColor = System.Drawing.Color.LightGray
        Me.RightLabel.Location = New System.Drawing.Point(219, 374)
        Me.RightLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RightLabel.Name = "RightLabel"
        Me.RightLabel.Size = New System.Drawing.Size(389, 46)
        Me.RightLabel.TabIndex = 15
        Me.RightLabel.Text = "Marks Per Right Answer"
        '
        'WrongLabel
        '
        Me.WrongLabel.AutoSize = True
        Me.WrongLabel.Font = New System.Drawing.Font("Yu Gothic UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.WrongLabel.ForeColor = System.Drawing.Color.LightGray
        Me.WrongLabel.Location = New System.Drawing.Point(219, 442)
        Me.WrongLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WrongLabel.Name = "WrongLabel"
        Me.WrongLabel.Size = New System.Drawing.Size(430, 46)
        Me.WrongLabel.TabIndex = 16
        Me.WrongLabel.Text = "Penalty Per Wrong Answer"
        '
        'RightMarksInput
        '
        Me.RightMarksInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.RightMarksInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RightMarksInput.DecimalPlaces = 2
        Me.RightMarksInput.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.RightMarksInput.ForeColor = System.Drawing.Color.White
        Me.RightMarksInput.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.RightMarksInput.Location = New System.Drawing.Point(683, 388)
        Me.RightMarksInput.Margin = New System.Windows.Forms.Padding(4)
        Me.RightMarksInput.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.RightMarksInput.Minimum = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.RightMarksInput.Name = "RightMarksInput"
        Me.RightMarksInput.Size = New System.Drawing.Size(281, 32)
        Me.RightMarksInput.TabIndex = 17
        Me.RightMarksInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RightMarksInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'WrongMarksInput
        '
        Me.WrongMarksInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.WrongMarksInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WrongMarksInput.DecimalPlaces = 2
        Me.WrongMarksInput.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.WrongMarksInput.ForeColor = System.Drawing.Color.White
        Me.WrongMarksInput.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.WrongMarksInput.Location = New System.Drawing.Point(683, 456)
        Me.WrongMarksInput.Margin = New System.Windows.Forms.Padding(4)
        Me.WrongMarksInput.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.WrongMarksInput.Name = "WrongMarksInput"
        Me.WrongMarksInput.Size = New System.Drawing.Size(281, 32)
        Me.WrongMarksInput.TabIndex = 18
        Me.WrongMarksInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'browse_btn
        '
        Me.browse_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.browse_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.browse_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.browse_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.browse_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.browse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browse_btn.Font = New System.Drawing.Font("Yu Gothic UI", 12.8!, System.Drawing.FontStyle.Bold)
        Me.browse_btn.ForeColor = System.Drawing.Color.LightGray
        Me.browse_btn.Location = New System.Drawing.Point(799, 522)
        Me.browse_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.browse_btn.Name = "browse_btn"
        Me.browse_btn.Size = New System.Drawing.Size(165, 52)
        Me.browse_btn.TabIndex = 21
        Me.browse_btn.Text = "Browse"
        Me.browse_btn.UseVisualStyleBackColor = False
        '
        'folderLoc
        '
        Me.folderLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.folderLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.folderLoc.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folderLoc.ForeColor = System.Drawing.Color.White
        Me.folderLoc.Location = New System.Drawing.Point(227, 549)
        Me.folderLoc.Margin = New System.Windows.Forms.Padding(4)
        Me.folderLoc.Name = "folderLoc"
        Me.folderLoc.Size = New System.Drawing.Size(373, 25)
        Me.folderLoc.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 12.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(222, 515)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 30)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Enter Location of Scanned OMR Sheet(s)"
        '
        'scanAnsConfirm
        '
        Me.scanAnsConfirm.AutoSize = True
        Me.scanAnsConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.scanAnsConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.scanAnsConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.scanAnsConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.scanAnsConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scanAnsConfirm.Font = New System.Drawing.Font("Yu Gothic UI", 12.8!, System.Drawing.FontStyle.Bold)
        Me.scanAnsConfirm.ForeColor = System.Drawing.Color.LightGray
        Me.scanAnsConfirm.Location = New System.Drawing.Point(799, 613)
        Me.scanAnsConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.scanAnsConfirm.Name = "scanAnsConfirm"
        Me.scanAnsConfirm.Size = New System.Drawing.Size(165, 52)
        Me.scanAnsConfirm.TabIndex = 22
        Me.scanAnsConfirm.Text = "Scan"
        Me.scanAnsConfirm.UseVisualStyleBackColor = False
        '
        'examNameInput
        '
        Me.examNameInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.examNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.examNameInput.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examNameInput.ForeColor = System.Drawing.Color.White
        Me.examNameInput.Location = New System.Drawing.Point(521, 294)
        Me.examNameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.examNameInput.Name = "examNameInput"
        Me.examNameInput.Size = New System.Drawing.Size(443, 25)
        Me.examNameInput.TabIndex = 24
        '
        'examNameTitle
        '
        Me.examNameTitle.AutoSize = True
        Me.examNameTitle.Font = New System.Drawing.Font("Yu Gothic UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.examNameTitle.ForeColor = System.Drawing.Color.LightGray
        Me.examNameTitle.Location = New System.Drawing.Point(219, 283)
        Me.examNameTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.examNameTitle.Name = "examNameTitle"
        Me.examNameTitle.Size = New System.Drawing.Size(294, 46)
        Me.examNameTitle.TabIndex = 23
        Me.examNameTitle.Text = "Enter Exam Name"
        '
        'animLoad
        '
        Me.animLoad.Image = Global.ycceomrapp.My.Resources.Resources.loading_2
        Me.animLoad.Location = New System.Drawing.Point(510, 613)
        Me.animLoad.Margin = New System.Windows.Forms.Padding(4)
        Me.animLoad.Name = "animLoad"
        Me.animLoad.Size = New System.Drawing.Size(128, 122)
        Me.animLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.animLoad.TabIndex = 25
        Me.animLoad.TabStop = False
        Me.animLoad.Visible = False
        '
        'minimize
        '
        Me.minimize.BackgroundImage = CType(resources.GetObject("minimize.BackgroundImage"), System.Drawing.Image)
        Me.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.minimize.Location = New System.Drawing.Point(1076, 13)
        Me.minimize.Margin = New System.Windows.Forms.Padding(4)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(33, 28)
        Me.minimize.TabIndex = 10
        Me.minimize.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.close_btn.Location = New System.Drawing.Point(1106, 13)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(33, 28)
        Me.close_btn.TabIndex = 9
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'print_title
        '
        Me.print_title.Image = CType(resources.GetObject("print_title.Image"), System.Drawing.Image)
        Me.print_title.Location = New System.Drawing.Point(461, 48)
        Me.print_title.Margin = New System.Windows.Forms.Padding(4)
        Me.print_title.Name = "print_title"
        Me.print_title.Size = New System.Drawing.Size(190, 134)
        Me.print_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.print_title.TabIndex = 26
        Me.print_title.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Yu Gothic UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.LightGray
        Me.TextBox1.Location = New System.Drawing.Point(289, 189)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(551, 67)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.Text = "SCAN ANSWER SHEET"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Yu Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.LightGray
        Me.TextBox4.Location = New System.Drawing.Point(374, 760)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(387, 29)
        Me.TextBox4.TabIndex = 28
        Me.TextBox4.Text = "Built and Developed by YCCE Ver 1.0.0.0"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'scanDirectorty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1152, 789)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.print_title)
        Me.Controls.Add(Me.animLoad)
        Me.Controls.Add(Me.scanAnsConfirm)
        Me.Controls.Add(Me.examNameInput)
        Me.Controls.Add(Me.examNameTitle)
        Me.Controls.Add(Me.browse_btn)
        Me.Controls.Add(Me.folderLoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WrongMarksInput)
        Me.Controls.Add(Me.RightMarksInput)
        Me.Controls.Add(Me.WrongLabel)
        Me.Controls.Add(Me.RightLabel)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.close_btn)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "scanDirectorty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "scanDirectorty"
        CType(Me.RightMarksInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WrongMarksInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.animLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.print_title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents minimize As Button
    Friend WithEvents close_btn As Button
    Friend WithEvents RightLabel As Label
    Friend WithEvents WrongLabel As Label
    Friend WithEvents RightMarksInput As NumericUpDown
    Friend WithEvents WrongMarksInput As NumericUpDown
    Friend WithEvents browse_btn As Button
    Friend WithEvents folderLoc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents scanAnsConfirm As Button
    Friend WithEvents examNameInput As TextBox
    Friend WithEvents examNameTitle As Label
    Friend WithEvents animLoad As PictureBox
    Friend WithEvents print_title As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
