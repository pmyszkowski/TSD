#1 CPU
function CPU ()
{
    $cpu = Get-Process | Where-Object -Property CPU -ge 10
    $cpu = $cpu | Select-Object -Property Name, CPU 
    $cpu > cpu.txt
}

#2 MSDN
function MSDN()
{
    return findstr /n "PowerShell" .\MSDN.txt
}


#3 RSS
function RSS()
{
    return ([xml](get-content PowerShell.rss)).rss.channel.item | Select-Object title
}
