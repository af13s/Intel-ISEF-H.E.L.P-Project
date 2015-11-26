<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registy Tweaks"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(64, 63)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Backup"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 38)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 15)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(43, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Yes"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Continue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 94)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(131, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Prevent Admin Shares"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(12, 117)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(150, 17)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "Dont show last login name"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(12, 140)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(135, 17)
        Me.CheckBox3.TabIndex = 5
        Me.CheckBox3.Text = "Disable password save"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(12, 163)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(161, 17)
        Me.CheckBox4.TabIndex = 6
        Me.CheckBox4.Text = "Clear Page File on shutdown"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(12, 186)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(128, 17)
        Me.CheckBox5.TabIndex = 7
        Me.CheckBox5.Text = "Password Hash Save"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(12, 209)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(128, 17)
        Me.CheckBox6.TabIndex = 8
        Me.CheckBox6.Text = "Restrict Anon Access"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(228, 238)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
End Class
