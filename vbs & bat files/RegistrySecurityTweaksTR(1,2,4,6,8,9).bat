reg add "hklm\system\currentcontrolset\services\lanmanserver\parameters" /v AutoShareWks /t REG_DWORD /d 0

reg add "hklm\Software\Microsoft\Windows\CurrentVersion\Policies\System" /v dontdisplaylastusername /t REG_DWORD /d 1

reg add "hklm\SYSTEM\CurrentControlSet\Services\RasMan\parameters" /v DisableSavePassword /t REG_DWORD /d 1

reg add "hklm\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management" /v ClearPageFileAtShutdown /t REG_DWORD /d 1

reg add "hklm\SYSTEM\CurrentControlSet\Control\Lsa" /v NoLMHash /t REG_DWORD /d 1

reg add "hklm\System\CurrentControlSet\Control\Lsa" /v RestrictAnonymous /t REG_DWORD /d 2

