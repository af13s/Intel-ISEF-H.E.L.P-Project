Imports Microsoft.VisualBasic.Devices
Imports System.Management

Public Class Form3
    Dim totalspace, freespaceD1, ProcMHz As Long
    Dim DirectXVNUM As Double
    Dim DirectXV As String
    Dim RAM, ProcSped, FreeSpace, DirXCheck, syscheck As Integer
    Dim conf As Integer
    Dim xbit As Boolean

    Enum InfoTypes
        OperatingSystemName
        AmountOfMemory
        VideoCardMem

    End Enum


    Public Function GetInfo(ByVal InfoType As InfoTypes) As String
        Dim info As New ComputerInfo : Dim value, vganame, vgamem, proc As String

        Dim seacher As New Management.ManagementObjectSearcher( _
            "root\CIMV2", "SELECT * FROM Win32_VideoController")

        Dim searcher1 As New Management.ManagementObjectSearcher( _
            "SELECT * FROM Win32_Processor")


        ' os identify
        If InfoType = InfoTypes.OperatingSystemName Then
            value = info.OSFullName
     
            'RAM CALC
        ElseIf InfoType = InfoTypes.AmountOfMemory Then
            value = Math.Round(((((CDbl(Convert.ToDouble(Val(info.TotalPhysicalMemory))) / 1024)) / 1024) / 1024), 2)

        End If

        Return value
    End Function

    

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        xbit = System.Environment.Is64BitOperatingSystem

        totalspace = My.Computer.FileSystem.GetDriveInfo("C:\").TotalSize / 1024 / 1024 /1024

        freespaceD1 = My.Computer.FileSystem.GetDriveInfo("C:\").AvailableFreeSpace / 1024 / 1024 / 1024

        ProcMHz = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "~MHz", Nothing)

        DirectXV = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\MICROSOFT\DirectX", "Version", Nothing)

        DirectXV = DirectXV.Substring(0, 4)
        DirectXVNUM = DirectXV

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        


        conf = 0
        If RadioButton1.Checked = True Then conf += 1
        If RadioButton2.Checked = True Then conf += 1
        If RadioButton3.Checked = True Then conf += 1
        If RadioButton4.Checked = True Then conf += 1
        If ProgressBar1.Value = ProgressBar1.Maximum Then conf += 1


        If conf = 3 Then

            If RadioButton1.Checked = True Then Form1.Show()
            If RadioButton2.Checked = True Then Form1.Show()

            If RadioButton4.Checked = True Then
                Dim obj As Object
                obj = GetObject("winmgmts:{impersonationLevel=impersonate}!root/default:SystemRestore")
                'The date and ID are auto added
                Call obj.CreateRestorePoint("H.E.L.P Restore Point", 12, 100)
            End If




            If RadioButton3.Checked = True Then
                Dim response
                response = MsgBox("You have chosen not to back up your settings, continue without back up? ", vbYesNo)
                MsgBox("System Restore Point was not created.")
                If response = vbNo Then
                    MsgBox("Your settings are being backed with the creation of a system restore point.")
                    Dim obj As Object
                    obj = GetObject("winmgmts:{impersonationLevel=impersonate}!root/default:SystemRestore")
                    Call obj.CreateRestorePoint("H.E.L.P Restore Point", 12, 100)
                End If
                Me.Hide()
            End If

        Else

            Dim response
            response = MsgBox("Please complete the form before proceeding.", vbRetryCancel)

        End If







    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If GetInfo(InfoTypes.OperatingSystemName) <> "Microsoft Windows 7" Then
            MsgBox("This program was designed for Microsoft Windows 7 machines.")
            MsgBox("Your Operating System : " + GetInfo(InfoTypes.OperatingSystemName))
            Label5.Text = "N/A"
            ProgressBar1.Increment(100)
        Else

            ' check ram
            If xbit = False & GetInfo(InfoTypes.AmountOfMemory) >= 1 Then
            ElseIf xbit = True & GetInfo(InfoTypes.AmountOfMemory) >= 2 Then
                RAM = 1
                ProgressBar1.Increment(25)

            Else
                RAM = 0
                ProgressBar1.Increment(25)
                MsgBox("Insufficient virtual memory (RAM)")
            End If

            If xbit = False And freespaceD1 >= 16 Then
            ElseIf xbit = True And freespaceD1 = 20 Then
                FreeSpace = 1
                ProgressBar1.Increment(25)
            Else
                FreeSpace = 0
                ProgressBar1.Increment(25)
                MsgBox("Insufficient harddisk space")
            End If

            If ProcMHz >= 1000 Then
                ProcSped = 1
                ProgressBar1.Increment(25)
            Else
                ProcSped = 0
                ProgressBar1.Increment(25)
                MsgBox("Insufficient processor speed")
            End If

            If DirectXVNUM >= 4.09 Then
                DirXCheck = 1
                ProgressBar1.Increment(25)
            Else
                DirXCheck = 0
                ProgressBar1.Increment(25)
                MsgBox("DirectX should be updated")
            End If

            syscheck = RAM + ProcSped + FreeSpace + DirXCheck

            If syscheck = 4 Then
                Label5.Text = "Passed"
            Else
                Label5.Text = "Failed"
            End If
        End If
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        AboutBox1.Show()


    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class