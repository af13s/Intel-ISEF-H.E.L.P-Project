Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("C:\Windows\System32\Cmd.exe")
        SendKeys.Send("control appwiz.cpl,,0")
        SendKeys.Send("{ENTER}")

        Form8.Show()

    End Sub
End Class