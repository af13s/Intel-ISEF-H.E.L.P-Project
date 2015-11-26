<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hardware Driver Update"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LinkLabel4)
        Me.GroupBox2.Controls.Add(Me.LinkLabel3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 63)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Graphics Card"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(21, 27)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(31, 13)
        Me.LinkLabel3.TabIndex = 0
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "AMD"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(102, 27)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(37, 13)
        Me.LinkLabel4.TabIndex = 1
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Nvidia"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(192, 129)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form8"
        Me.Text = "H.E.L.P."
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
End Class
