Public Class Form7

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Form1.CheckBox6.Checked = False Then
            Me.Close()
            Form8.Show()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then
            Shell("C:\Users\Florial\Documents\Science Fair Project\vbs & bat files\RegistryBackup.bat")
        End If

        If CheckBox1.Checked = True Then
            Shell("C:\Users\Florial\Documents\Science Fair Project\vbs & bat files\regedit1.bat")
        End If

        If CheckBox2.Checked = True Then
            Shell("C:\Users\Florial\Documents\Science Fair Project\vbs & bat files\regedit2.bat")
        End If

        If CheckBox3.Checked = True Then
            Shell("C:\Users\Florial\Documents\Science Fair Project\vbs & bat files\regedit3.bat")
        End If

        If CheckBox4.Checked = True Then
            Shell("C:\Users\Florial\Documents\Science Fair Project\vbs & bat files\regedit4.bat")
        End If

        If CheckBox5.Checked = True Then
            Shell("C:\Users\Florial\Documents\Science Fair Project\vbs & bat files\regedit5.bat")
        End If

        If CheckBox6.Checked = True Then
            Shell("C:\Users\Florial\Documents\Science Fair Project\vbs & bat files\regedit6.bat")
        End If

        Me.Hide()


    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Dim response

        response = MsgBox("Are you sure you dont want to back up registry?", vbYesNo)
        If response = vbNo Then
            RadioButton1.PerformClick()
        End If

    End Sub
End Class