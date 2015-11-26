Imports Microsoft.VisualBasic.Devices
Imports System.Management

Public Class Form1



    Dim ramcheck, proccheck, hardcheck, vidmcheck, hardreq As Boolean

    Dim ProcGHZ, ts, fs As Long


    Enum InfoTypes
        AmountOfMemory
        VideoCardMem
    End Enum

    Public Function GetInfo(ByVal InfoType As InfoTypes) As String
        Dim info As New ComputerInfo : Dim value, vgamem As String

        Dim searcher As New Management.ManagementObjectSearcher( _
            "root\CIMV2", "SELECT * FROM Win32_VideoController")

        'RAM CALC
        If InfoType = InfoTypes.AmountOfMemory Then
            value = Math.Round(((((CDbl(Convert.ToDouble(Val(info.TotalPhysicalMemory))) / 1024)) / 1024) / 1024), 2)

            'Video RAM
        ElseIf InfoType = InfoTypes.VideoCardMem Then
            For Each queryObject As ManagementObject In searcher.Get
                vgamem = queryObject.GetPropertyValue("AdapterRAM").ToString
            Next
            value = Math.Round(((((CDbl(Convert.ToDouble(Val(vgamem))) / 1024)) / 1024) / 1024), 2)
        End If
        Return value
    End Function

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Hardware msges

        'ram 
        If CheckBox9.Checked = True Then
            If ramcheck = True Then
                MsgBox("You have sufficient RAM Specifications")
            Else
                MsgBox("RAM Upgrade is recommended")
            End If
        End If

        If CheckBox11.Checked = True Then
            If hardcheck = True Then
                MsgBox("You have sufficient hard drive space")
            Else
                MsgBox("Hard Drive space upgrade is recommended")
            End If
        End If

        If CheckBox11.Checked = True Then
            If hardreq = True Then
                MsgBox("You have sufficient free space")
            Else
                MsgBox("You lack free space to function optimally, Uninstall programs, Disk Clean Up, and Cache Clean up are recommended and will be automatically selected")
            End If
        End If

        If CheckBox10.Checked = True Then
            If proccheck = True Then
                MsgBox("You have sufficient Processor Specifications")

            Else
                If RadioButton2.Checked Or RadioButton4.Checked = True Then
                    MsgBox("Processor upgrade is recommended, performance enhancements are recommended and will be automatically enabled")
                ElseIf RadioButton1.Checked Or RadioButton3.Checked = True Then
                    MsgBox("For Gaming and Multimedia multi-core processors are recommended, performance enhancements are recommended and will be automatically enabled")
                End If
            End If

        End If

        If CheckBox12.Checked = True Then
            If vidmcheck = True Then
                MsgBox("You have sufficient video memory")
            Else
                MsgBox("VideoCard upgrade is recommended")
            End If
        End If

        'Maintenance Operations-----------------------------------------------------------------------------------------
        ' Disk Clean Up
        If CheckBox15.Checked = True Then
            If IO.File.Exists("C:\Windows\System32\cleanmgr.exe") Then
                Dim Drive As String = "C"
                Dim _process = New Process()

                With _process
                    .StartInfo.FileName = "cleanmgr.exe"
                    .StartInfo.WorkingDirectory = "C:\Windows\System32"
                    .StartInfo.Arguments = String.Format( _
                        Globalization.CultureInfo.InvariantCulture, "/d{0}", Drive)
                    .EnableRaisingEvents = True
                    .StartInfo.CreateNoWindow = False
                    .StartInfo.UseShellExecute = False
                    .StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    .StartInfo.RedirectStandardOutput = True
                    .StartInfo.RedirectStandardError = True
                    .Start()
                    .WaitForExit()
                End With
            Else
                MessageBox.Show("Failed to find Disk cleaner.")
            End If
        End If
        'Defragment
        If CheckBox13.Checked = True Then
            'System.Diagnostics.Process.Start("C:\Windows\System32\dfrg.msc").WaitForExit()
        End If

        'Add / Remove Progs
        If CheckBox14.Checked = True Then

            System.Diagnostics.Process.Start("C:\Windows\System32\Cmd.exe")
            SendKeys.Send("control appwiz.cpl,,0")
            SendKeys.Send("{ENTER}")

        End If

        'Disk Check
        If CheckBox17.Checked = True Then
            System.Diagnostics.Process.Start("chkdsk.exe", "C:").WaitForExit()
        End If

        'Updates
        If CheckBox18.Checked = True Then
            System.Diagnostics.Process.Start("C:\Users\Florial\Documents\Science Fair Project\vbs & bat files\CheckUpdates.vbs")
        End If

        'Malware Scan *Windows Defender
        If CheckBox19.Checked = True Then
            System.Diagnostics.Process.Start("C:\Windows\explorer.exe", arguments:="shell:::{D8559EB9-20C0-410E-BEDA-7ED416AECC2A}")
        End If

        'cache clean up
        If CheckBox2.Checked = True Then
            For Each foundFile As String In My.Computer.FileSystem.GetFiles( _
        My.Computer.FileSystem.SpecialDirectories.MyDocuments, _
        FileIO.SearchOption.SearchAllSubDirectories, "C:\Documents and Settings\" + System.Environment.UserName + "\Local Settings\Application Data\Mozilla\Firefox\Profiles\<­ randomtext>.default\Cache", "C:\Documents and Settings\" + System.Environment.UserName + "\Local Settings\Application Data\Google\Chrome\User Data\Default\Cache")

                My.Computer.FileSystem.DeleteFile(foundFile, _
                    FileIO.UIOption.AllDialogs, _
                    FileIO.RecycleOption.DeletePermanently)
            Next
        End If

        '----------------------------------------------------------------------------------------------------------------------------

        Form2.Show()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        For Each Checkbox In GroupBox3.Controls
            Checkbox.Checked = False
        Next

            For Each Checkbox In GroupBox4.Controls
                Checkbox.Checked = False
            Next


    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged


        Button3.PerformClick()
        CheckBox13.Checked = True
        CheckBox14.Checked = True
        CheckBox15.Checked = True
        CheckBox17.Checked = True


        For Each CheckBox In GroupBox3.Controls
            CheckBox.checked = True
        Next

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        Button3.PerformClick()
        CheckBox18.Checked = True
        CheckBox13.Checked = True
        CheckBox17.Checked = True
        CheckBox10.Checked = True
        CheckBox11.Checked = True
        If hardreq = False Then
            CheckBox15.Checked = True
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged

        ts = My.Computer.FileSystem.GetDriveInfo("C:\").TotalSize / 1024 / 1024 / 1024
        fs = My.Computer.FileSystem.GetDriveInfo("C:\").AvailableFreeSpace / 1024 / 1024 / 1024

        If ts / 5 < fs Then
            hardreq = True
        Else
            hardreq = False
        End If


        If RadioButton3.Checked = True Then
            If ts >= 500 Then
                hardcheck = True
            Else
                hardcheck = False
            End If
        End If

        If RadioButton1.Checked = True Then
            If ts >= 250 Then
                hardcheck = True
            Else
                hardcheck = False
            End If
        End If

        If RadioButton2.Checked Or RadioButton4.Checked = True Then
            If ts >= 100 Then
                hardcheck = True
            Else
                hardcheck = False
            End If
        End If



    End Sub

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged

        If RadioButton1.Checked Or RadioButton2.Checked = True Then
            If GetInfo(InfoTypes.AmountOfMemory) >= 2 Then
                ramcheck = True
            Else
                ramcheck = False
            End If
        End If


        If RadioButton2.Checked Or RadioButton4.Checked = True Then
            If GetInfo(InfoTypes.AmountOfMemory) >= 1 Then
                ramcheck = True
            Else
                ramcheck = False
            End If
        End If


    End Sub

    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged

        ProcGHZ = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "~MHz", Nothing)

        If RadioButton1.Checked Or RadioButton3.Checked = True Then
            If System.Environment.ProcessorCount > 1 And ProcGHZ >= 2.3 Then
                proccheck = True
            Else
                proccheck = False
            End If
        End If

        If RadioButton2.Checked Or RadioButton4.Checked = True Then
            If ProcGHZ >= 1 Then
                proccheck = True
            Else
                proccheck = False
            End If
        End If


    End Sub

    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged

        If RadioButton3.Checked Or RadioButton2.Checked Or RadioButton4.Checked = True Then
            vidmcheck = True
        End If

        If RadioButton1.Checked = True Then
            If GetInfo(InfoTypes.AmountOfMemory) >= 1 Then
                vidmcheck = True
            Else
                vidmcheck = False
            End If
        End If

    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged

        Button3.PerformClick()
        MsgBox("Custom user group hardware suggestions cannot be determined because of undefined usage/purpose.")



    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

        Button3.PerformClick()
        CheckBox10.Checked = True
        CheckBox11.Checked = True
        CheckBox9.Checked = True
        CheckBox13.Checked = True
        CheckBox17.Checked = True

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged

        Button3.PerformClick()
        CheckBox9.Checked = True
        CheckBox10.Checked = True
        CheckBox13.Checked = True
        CheckBox14.Checked = True
        CheckBox15.Checked = True
        CheckBox2.Checked = True
        CheckBox17.Checked = True
        CheckBox19.Checked = True
        CheckBox18.Checked = True
    End Sub

    Private Sub FAQToolStripMenuItem_Clibck(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FAQToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()
        Form2.Close()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()


    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = False Then
            Form2.GroupBox2.Enabled = False
        Else
            Form2.GroupBox2.Enabled = True
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = False Then
            Form2.GroupBox1.Enabled = False
        Else
            Form2.GroupBox1.Enabled = True
        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged

        If CheckBox4.Checked = False Then
            Form2.GroupBox4.Enabled = False
        Else
            Form2.GroupBox4.Enabled = True
        End If

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged

        If CheckBox5.Checked = False Then
            Form2.GroupBox3.Enabled = False
        Else
            Form2.GroupBox3.Enabled = True
        End If

    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged

        If CheckBox6.Checked = False Then
            Form4.Enabled = False
        Else
            Form4.Enabled = True
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Form3.RadioButton1.Checked = True Then
            Me.CheckBox1.Checked = True
            Me.CheckBox5.Checked = True
            Me.CheckBox6.Checked = True
            Form2.RadioButton4.Checked = True
            Form2.CheckBox3.Checked = True
            Me.CheckBox3.Checked = True
        End If

    End Sub
End Class
