On Error Resume Next

strComputer = "."
arrTargetSvcs = Array("Alerter", "SCardSvr", "WZCSVC")

Set objWMIService = GetObject("winmgmts:" _
 & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")
Set colServices = objWMIService.ExecQuery("SELECT * FROM Win32_Service")

Wscript.Echo "Checking for target services ..."

For Each objService in colServices
  For Each strTargetSvc In arrTargetSvcs
    If LCase(objService.Name) = LCase(strTargetSvc) Then
      WScript.Echo VbCrLf & "Service Name: " & objService.Name
      WScript.Echo "  Status: " & objService.State
      Wscript.Echo "  Startup Type: " & objService.StartMode
      WScript.Echo "  Time: " & Now
      If objService.State = "Stopped" Then
        WScript.Echo "  Already stopped"
      Else
        intStop = objService.StopService
        If intStop = 0 Then
          WScript.Echo "  Stopped service"
        Else
          WScript.Echo "  Unable to stop service"
        End If
      End If
      If objService.StartMode = "Disabled" Then
        WScript.Echo "  Already disabled"
      Else
        intDisable = objService.ChangeStartMode("Disabled")
        If intDisable = 0 Then
          WScript.Echo "  Disabled service"
        Else
          WScript.Echo "  Unable to disable service"
        End If
      End If
    End If
  Next
Next