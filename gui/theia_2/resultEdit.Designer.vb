<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resultEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(resultEdit))
        Me.dataTable = New System.Windows.Forms.DataGridView()
        Me.meritPos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.correctAns = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wrongAns = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalMarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.image = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.print = New System.Windows.Forms.Button()
        Me.minimize = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataTable
        '
        Me.dataTable.AllowUserToOrderColumns = True
        Me.dataTable.AllowUserToResizeColumns = False
        Me.dataTable.AllowUserToResizeRows = False
        Me.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dataTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.meritPos, Me.roll, Me.correctAns, Me.wrongAns, Me.totalMarks, Me.image})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataTable.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataTable.EnableHeadersVisualStyles = False
        Me.dataTable.Location = New System.Drawing.Point(18, 76)
        Me.dataTable.Margin = New System.Windows.Forms.Padding(4)
        Me.dataTable.Name = "dataTable"
        Me.dataTable.RowHeadersVisible = False
        Me.dataTable.RowHeadersWidth = 51
        Me.dataTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataTable.Size = New System.Drawing.Size(1002, 654)
        Me.dataTable.TabIndex = 0
        '
        'meritPos
        '
        Me.meritPos.HeaderText = "Merit Position"
        Me.meritPos.MinimumWidth = 6
        Me.meritPos.Name = "meritPos"
        '
        'roll
        '
        Me.roll.HeaderText = "Roll Number"
        Me.roll.MinimumWidth = 6
        Me.roll.Name = "roll"
        '
        'correctAns
        '
        Me.correctAns.HeaderText = "Correct Answer"
        Me.correctAns.MinimumWidth = 6
        Me.correctAns.Name = "correctAns"
        '
        'wrongAns
        '
        Me.wrongAns.HeaderText = "Wrong Answer"
        Me.wrongAns.MinimumWidth = 6
        Me.wrongAns.Name = "wrongAns"
        '
        'totalMarks
        '
        Me.totalMarks.HeaderText = "Total Marks"
        Me.totalMarks.MinimumWidth = 6
        Me.totalMarks.Name = "totalMarks"
        '
        'image
        '
        Me.image.HeaderText = "image"
        Me.image.LinkColor = System.Drawing.Color.Aqua
        Me.image.MinimumWidth = 6
        Me.image.Name = "image"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Button1.BackgroundImage = Global.ycceomrapp.My.Resources.Resources.excelLogo
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1028, 646)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 84)
        Me.Button1.TabIndex = 28
        Me.Button1.UseVisualStyleBackColor = False
        '
        'print
        '
        Me.print.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.print.BackgroundImage = Global.ycceomrapp.My.Resources.Resources.printIcon
        Me.print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.print.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.print.Location = New System.Drawing.Point(1028, 554)
        Me.print.Margin = New System.Windows.Forms.Padding(4)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(91, 84)
        Me.print.TabIndex = 27
        Me.print.UseVisualStyleBackColor = False
        '
        'minimize
        '
        Me.minimize.BackgroundImage = CType(resources.GetObject("minimize.BackgroundImage"), System.Drawing.Image)
        Me.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.minimize.Location = New System.Drawing.Point(1074, 13)
        Me.minimize.Margin = New System.Windows.Forms.Padding(4)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(33, 28)
        Me.minimize.TabIndex = 12
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
        Me.close_btn.TabIndex = 11
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Yu Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.LightGray
        Me.TextBox4.Location = New System.Drawing.Point(392, 761)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(387, 29)
        Me.TextBox4.TabIndex = 30
        Me.TextBox4.Text = "Built and Developed by YCCE Ver 1.0.0.0"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'resultEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1152, 789)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.dataTable)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "resultEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "resultEdit"
        CType(Me.dataTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataTable As DataGridView
    Friend WithEvents minimize As Button
    Friend WithEvents close_btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents print As Button
    Friend WithEvents meritPos As DataGridViewTextBoxColumn
    Friend WithEvents roll As DataGridViewTextBoxColumn
    Friend WithEvents correctAns As DataGridViewTextBoxColumn
    Friend WithEvents wrongAns As DataGridViewTextBoxColumn
    Friend WithEvents totalMarks As DataGridViewTextBoxColumn
    Friend WithEvents image As DataGridViewLinkColumn
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
