net stop WSearch
REG add "HKLM\SYSTEM\CurrentControlSet\Services\WSearch" /v Start /t REG_DWORD /d 4 /f