<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class printSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(printSheet))
        Me.copyCountLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.printerList = New System.Windows.Forms.ListBox()
        Me.copyInput = New System.Windows.Forms.NumericUpDown()
        Me.print = New System.Windows.Forms.Button()
        Me.minimize = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.print_title = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        CType(Me.copyInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.print_title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'copyCountLabel
        '
        Me.copyCountLabel.AutoSize = True
        Me.copyCountLabel.Font = New System.Drawing.Font("Yu Gothic UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.copyCountLabel.ForeColor = System.Drawing.Color.LightGray
        Me.copyCountLabel.Location = New System.Drawing.Point(281, 349)
        Me.copyCountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.copyCountLabel.Name = "copyCountLabel"
        Me.copyCountLabel.Size = New System.Drawing.Size(309, 46)
        Me.copyCountLabel.TabIndex = 8
        Me.copyCountLabel.Text = "Number of Copies "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 12.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(284, 418)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Select Printer"
        '
        'printerList
        '
        Me.printerList.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.printerList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.printerList.Font = New System.Drawing.Font("Yu Gothic UI", 12.8!, System.Drawing.FontStyle.Bold)
        Me.printerList.ForeColor = System.Drawing.Color.LightGray
        Me.printerList.FormattingEnabled = True
        Me.printerList.ItemHeight = 30
        Me.printerList.Location = New System.Drawing.Point(289, 452)
        Me.printerList.Margin = New System.Windows.Forms.Padding(4)
        Me.printerList.Name = "printerList"
        Me.printerList.Size = New System.Drawing.Size(453, 210)
        Me.printerList.TabIndex = 11
        '
        'copyInput
        '
        Me.copyInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.copyInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.copyInput.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.copyInput.ForeColor = System.Drawing.Color.White
        Me.copyInput.Location = New System.Drawing.Point(614, 362)
        Me.copyInput.Margin = New System.Windows.Forms.Padding(4)
        Me.copyInput.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.copyInput.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.copyInput.Name = "copyInput"
        Me.copyInput.Size = New System.Drawing.Size(200, 32)
        Me.copyInput.TabIndex = 13
        Me.copyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.copyInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'print
        '
        Me.print.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.print.BackgroundImage = Global.ycceomrapp.My.Resources.Resources.printIcon
        Me.print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.print.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.print.Location = New System.Drawing.Point(766, 568)
        Me.print.Margin = New System.Windows.Forms.Padding(4)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(95, 94)
        Me.print.TabIndex = 12
        Me.print.UseVisualStyleBackColor = False
        '
        'minimize
        '
        Me.minimize.BackgroundImage = CType(resources.GetObject("minimize.BackgroundImage"), System.Drawing.Image)
        Me.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.minimize.Location = New System.Drawing.Point(1076, 13)
        Me.minimize.Margin = New System.Windows.Forms.Padding(4)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(33, 28)
        Me.minimize.TabIndex = 6
        Me.minimize.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.close_btn.Location = New System.Drawing.Point(1106, 13)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(33, 28)
        Me.close_btn.TabIndex = 5
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
        Me.print_title.TabIndex = 14
        Me.print_title.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Yu Gothic UI", 30.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.LightGray
        Me.TextBox1.Location = New System.Drawing.Point(289, 189)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(572, 67)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.Text = "PRINT ANSWER SHEET"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Yu Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.LightGray
        Me.TextBox4.Location = New System.Drawing.Point(377, 760)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(387, 29)
        Me.TextBox4.TabIndex = 29
        Me.TextBox4.Text = "Built and Developed by YCCE Ver 1.0.0.0"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'printSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1152, 789)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.print_title)
        Me.Controls.Add(Me.copyInput)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.printerList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.copyCountLabel)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.close_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "printSheet"
        Me.Text = "Print OMR Sheet"
        CType(Me.copyInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.print_title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents minimize As Button
    Friend WithEvents close_btn As Button
    Friend WithEvents copyCountLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents printerList As ListBox
    Friend WithEvents print As Button
    Friend WithEvents copyInput As NumericUpDown
    Friend WithEvents print_title As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
