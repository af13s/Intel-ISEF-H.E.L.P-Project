
Imports System.ServiceProcess
Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load





    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        CheckBox4.Checked = True
        CheckBox5.Checked = True
        CheckBox7.Checked = True

        RadioButton13.Checked = True
        RadioButton16.Checked = True
        RadioButton19.Checked = True
        RadioButton22.Checked = True

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        CheckBox2.Checked = True
        CheckBox4.Checked = True
        CheckBox6.Checked = True

        RadioButton4.Checked = True
        RadioButton16.Checked = True
        RadioButton25.Checked = True

    End Sub

    Private Sub RadioButton27_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton27.CheckedChanged

        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox6.Checked = True

        RadioButton4.Checked = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        

        Shell("cmd.exe")
        If CheckBox1.Checked = True Then
            SendKeys.Send("net stop ErSvc /yes")
        End If
        If CheckBox2.Checked = True Then
            SendKeys.Send("net stop WMPNetworkSvc /yes")
        End If
        If CheckBox3.Checked = True Then
            SendKeys.Send("net stop RDSessMgr /yes")
        End If
        If CheckBox4.Checked = True Then
            SendKeys.Send("net stop iphlpsvc /yes")
        End If
        If CheckBox5.Checked = True Then
            SendKeys.Send("net stop SCardSvr /yes")
        End If
        If CheckBox6.Checked = True Then
            SendKeys.Send("net stop ehrecvr /yes")
        End If

        If RadioButton4.Checked = True Then
            SendKeys.Send("net stop TabletInputService / yes")
        End If

        If RadioButton7.Checked Then
            SendKeys.Send("net stop  CISVC /yes")
        End If

        If RadioButton10.Checked And RadioButton13.Checked = True Then
            SendKeys.Send("net stop CscService /yes")
        End If

        If RadioButton16.Checked = True Then
            SendKeys.Send("net stop napagent /yes")
        End If

        If RadioButton19.Checked And RadioButton22.Checked = True Then
            SendKeys.Send("net stop Fax /yes")
        End If


        If RadioButton25.Checked = True Then
            SendKeys.Send("net stop HomeGroupProvider / yes")
        End If

        Form5.Show()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged



    End Sub
End Class