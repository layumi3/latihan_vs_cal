<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.tb_b = New System.Windows.Forms.TextBox()
        Me.Tb_a = New System.Windows.Forms.TextBox()
        Me.Lb_a = New System.Windows.Forms.Label()
        Me.Lb_b = New System.Windows.Forms.Label()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.t_hasil = New System.Windows.Forms.TextBox()
        Me.txt_hasil = New System.Windows.Forms.Label()
        Me.btn_p = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_b
        '
        Me.tb_b.Location = New System.Drawing.Point(136, 74)
        Me.tb_b.Name = "tb_b"
        Me.tb_b.Size = New System.Drawing.Size(52, 20)
        Me.tb_b.TabIndex = 1
        '
        'Tb_a
        '
        Me.Tb_a.Location = New System.Drawing.Point(38, 74)
        Me.Tb_a.Name = "Tb_a"
        Me.Tb_a.Size = New System.Drawing.Size(52, 20)
        Me.Tb_a.TabIndex = 2
        '
        'Lb_a
        '
        Me.Lb_a.AutoSize = True
        Me.Lb_a.Location = New System.Drawing.Point(42, 31)
        Me.Lb_a.Name = "Lb_a"
        Me.Lb_a.Size = New System.Drawing.Size(14, 13)
        Me.Lb_a.TabIndex = 3
        Me.Lb_a.Text = "A"
        '
        'Lb_b
        '
        Me.Lb_b.AutoSize = True
        Me.Lb_b.Location = New System.Drawing.Point(133, 31)
        Me.Lb_b.Name = "Lb_b"
        Me.Lb_b.Size = New System.Drawing.Size(14, 13)
        Me.Lb_b.TabIndex = 4
        Me.Lb_b.Text = "B"
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(303, 64)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(69, 39)
        Me.btn_submit.TabIndex = 5
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        't_hasil
        '
        Me.t_hasil.Location = New System.Drawing.Point(216, 74)
        Me.t_hasil.Name = "t_hasil"
        Me.t_hasil.Size = New System.Drawing.Size(52, 20)
        Me.t_hasil.TabIndex = 6
        '
        'txt_hasil
        '
        Me.txt_hasil.AutoSize = True
        Me.txt_hasil.Location = New System.Drawing.Point(232, 31)
        Me.txt_hasil.Name = "txt_hasil"
        Me.txt_hasil.Size = New System.Drawing.Size(30, 13)
        Me.txt_hasil.TabIndex = 7
        Me.txt_hasil.Text = "Hasil"
        '
        'btn_p
        '
        Me.btn_p.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_p.Location = New System.Drawing.Point(303, 109)
        Me.btn_p.Name = "btn_p"
        Me.btn_p.Size = New System.Drawing.Size(37, 28)
        Me.btn_p.TabIndex = 8
        Me.btn_p.Text = "+"
        Me.btn_p.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.Location = New System.Drawing.Point(303, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 32)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 268)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_p)
        Me.Controls.Add(Me.txt_hasil)
        Me.Controls.Add(Me.t_hasil)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.Lb_b)
        Me.Controls.Add(Me.Lb_a)
        Me.Controls.Add(Me.Tb_a)
        Me.Controls.Add(Me.tb_b)
        Me.Name = "Form2"
        Me.Text = "Cal Sederhana"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_b As System.Windows.Forms.TextBox
    Friend WithEvents Tb_a As System.Windows.Forms.TextBox
    Friend WithEvents Lb_a As System.Windows.Forms.Label
    Friend WithEvents Lb_b As System.Windows.Forms.Label
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents t_hasil As System.Windows.Forms.TextBox
    Friend WithEvents txt_hasil As System.Windows.Forms.Label
    Friend WithEvents btn_p As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
