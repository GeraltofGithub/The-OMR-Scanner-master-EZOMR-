<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.minimize = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.scanOption = New System.Windows.Forms.Button()
        Me.printOption = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'minimize
        '
        Me.minimize.BackgroundImage = CType(resources.GetObject("minimize.BackgroundImage"), System.Drawing.Image)
        Me.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.minimize.Location = New System.Drawing.Point(1074, 13)
        Me.minimize.Margin = New System.Windows.Forms.Padding(4)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(33, 28)
        Me.minimize.TabIndex = 4
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
        Me.close_btn.TabIndex = 3
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'scanOption
        '
        Me.scanOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.scanOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.scanOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scanOption.Font = New System.Drawing.Font("Yu Gothic", 30.0!, System.Drawing.FontStyle.Bold)
        Me.scanOption.ForeColor = System.Drawing.Color.LightGray
        Me.scanOption.Location = New System.Drawing.Point(695, 570)
        Me.scanOption.Margin = New System.Windows.Forms.Padding(4)
        Me.scanOption.Name = "scanOption"
        Me.scanOption.Size = New System.Drawing.Size(337, 72)
        Me.scanOption.TabIndex = 1
        Me.scanOption.Text = "Scan"
        Me.scanOption.UseVisualStyleBackColor = False
        '
        'printOption
        '
        Me.printOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.printOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.printOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printOption.Font = New System.Drawing.Font("Yu Gothic", 30.0!, System.Drawing.FontStyle.Bold)
        Me.printOption.ForeColor = System.Drawing.Color.LightGray
        Me.printOption.Location = New System.Drawing.Point(160, 570)
        Me.printOption.Margin = New System.Windows.Forms.Padding(4)
        Me.printOption.Name = "printOption"
        Me.printOption.Size = New System.Drawing.Size(337, 72)
        Me.printOption.TabIndex = 0
        Me.printOption.Text = "Print"
        Me.printOption.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Yu Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.LightGray
        Me.TextBox1.Location = New System.Drawing.Point(477, 216)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(262, 81)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "EZ OMR"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(477, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Yu Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.LightGray
        Me.TextBox2.Location = New System.Drawing.Point(403, 268)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(387, 29)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "We assist you to make results accurate!"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Yu Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.LightGray
        Me.TextBox3.Location = New System.Drawing.Point(414, 288)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(387, 29)
        Me.TextBox3.TabIndex = 10
        Me.TextBox3.Text = "Scan! Evaluate! Reward!"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(235, 381)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(186, 169)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(772, 381)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(186, 169)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Yu Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.LightGray
        Me.TextBox4.Location = New System.Drawing.Point(403, 759)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(387, 29)
        Me.TextBox4.TabIndex = 13
        Me.TextBox4.Text = "Built and Developed by YCCE Ver 1.0.0.0"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1152, 789)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.scanOption)
        Me.Controls.Add(Me.printOption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EZ OMR"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents printOption As Button
    Friend WithEvents scanOption As Button
    Friend WithEvents close_btn As Button
    Friend WithEvents minimize As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox4 As TextBox
End Class
