﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnswerEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnswerEditor))
        Me.ConfirmBtn = New System.Windows.Forms.Button()
        Me.minimize = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ConfirmBtn
        '
        Me.ConfirmBtn.AutoSize = True
        Me.ConfirmBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ConfirmBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ConfirmBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ConfirmBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ConfirmBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmBtn.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmBtn.ForeColor = System.Drawing.Color.White
        Me.ConfirmBtn.Location = New System.Drawing.Point(279, 833)
        Me.ConfirmBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ConfirmBtn.Name = "ConfirmBtn"
        Me.ConfirmBtn.Size = New System.Drawing.Size(93, 36)
        Me.ConfirmBtn.TabIndex = 22
        Me.ConfirmBtn.Text = "Confirm"
        Me.ConfirmBtn.UseVisualStyleBackColor = False
        '
        'minimize
        '
        Me.minimize.BackgroundImage = CType(resources.GetObject("minimize.BackgroundImage"), System.Drawing.Image)
        Me.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.minimize.Location = New System.Drawing.Point(321, 15)
        Me.minimize.Margin = New System.Windows.Forms.Padding(4)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(33, 28)
        Me.minimize.TabIndex = 24
        Me.minimize.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.close_btn.Location = New System.Drawing.Point(351, 15)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(33, 28)
        Me.close_btn.TabIndex = 23
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'AnswerEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 886)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.ConfirmBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AnswerEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Answer Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConfirmBtn As Button
    Friend WithEvents minimize As Button
    Friend WithEvents close_btn As Button
End Class
