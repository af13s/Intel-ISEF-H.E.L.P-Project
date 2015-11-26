Public Class Form2
    Dim strcomputer As String
    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub FaqToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FaqToolStripMenuItem.Click
        AboutBox1.Show()

    End Sub

    Private Sub ResetToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        Form3.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Form1.Close()
        Form3.Close()
        Form4.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If CheckBox3.Checked = True Then
            'strcomputer = "C:"
            'Dim objWMIService As Object = GetObject("winmgmts:\\" & strcomputer & "\root\cimv2")

            'Dim colServiceList As Object = objWMIService.ExecQuery _
            '("Select * from Win32_Service where Name = 'wuauserv'")

            'For Each objService In colServiceList
            'objService.ChangeStartMode("Automatic")
            'Next


            Const AU_enabled = 0

            Dim objAutoUpdate As Object = CreateObject("Microsoft.Update.AutoUpdate")

            Dim objSettings As Object = objAutoUpdate.Settings

            objSettings.NotificationLevel = AU_enabled


        End If

        If RadioButton6.Checked = True Then
            System.Diagnostics.Process.Start("C:\Users\Florial\Documents\Science Fair Project\vbs & bat files\RegistrySecurityTweaksTR(1,2,4,6,8,9)")
        End If


        If RadioButton3.Checked = True Then
            My.Computer.Registry.SetValue("Hkey_Current_User\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects", "VisualFxSetting", 2)
        End If

        If RadioButton4.Checked = True Then
            My.Computer.Registry.SetValue("Hkey_Current_User\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects", "VisualFxSetting", 0)
        End If

        If RadioButton1.Checked = True Then

            For Each foundFile As String In My.Computer.FileSystem.GetFiles( _
        My.Computer.FileSystem.SpecialDirectories.MyDocuments, _
        FileIO.SearchOption.SearchAllSubDirectories, "C:\users\" + System.Environment.UserName + "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup")

                My.Computer.FileSystem.DeleteFile(foundFile, _
                    FileIO.UIOption.AllDialogs, _
                    FileIO.RecycleOption.DeletePermanently)
            Next

        End If
        Form4.Show()

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged

       

    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        MsgBox("Visual settings will not be changed.")

    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        MsgBox("A BackUp Will be automatically created in your hard drive main directory, 'C:'")
        Shell("C:\Users\Florial\Documents\Science Fair Project\vbs & bat files\RegistryBackup.bat")
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        MsgBox("Registry settings will not be changed")
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            Form7.Show()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged



    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub MenuStrip1_ItemClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class