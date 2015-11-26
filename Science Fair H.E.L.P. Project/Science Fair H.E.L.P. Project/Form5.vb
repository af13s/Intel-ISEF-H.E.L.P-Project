Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        MsgBox("ReadyBoost allows for the usage of a portable storage device to be used to improve data management. Hard drives with lower RPM < 5400 benefit, however hard drives with faster RPM > 7200 may benefit more performance from turning the service off. Recommended for older hard drives or  those with space shortage. If unsure enable Readyboost.")

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("Provides optimal performance for data, data vulnerable if drive frequently removed")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If RadioButton1.Checked = True Then

            MsgBox("Insert a flash drive or flash memory card into the computer, compatible with ReadyBoost")
            MsgBox("Choose ReadyBoost from autoplay")
            MsgBox("Allocate Memory")
        End If

        If RadioButton4.Checked = True Then
            Shell("Cmd.exe")
            SendKeys.Send("Dskcache + P")
            SendKeys.Send("{ENTER}")
        End If



        If RadioButton5.Checked = True Then
            RadioButton1.Checked = True
        ElseIf RadioButton6.Checked = True Then
            RadioButton2.Checked = True
        End If

        Form6.Show()


    End Sub
End Class