$files = Get-ChildItem -Path $HOME/master-degree -Recurse

#1 Multiply 
function Multiply ($a, $b)
{
    return $a * $b
}

#2 Increment
function Increment ()
{
    param(
        [Parameter(Mandatory=$true)]$a, 
        [Parameter(Mandatory=$false)]$i = 1
    )
    return $a + $i
}

#3 Date
function Date ()
{
    return Get-Date -Format "dddd, MMMM dd, yyyy"
}

#4 Files by Extension
function Files_by_Extension {
    return $files | Sort-Object -Property Extension | Select-Object Name
}

#5 Files by Name
function Files_by_Name {
    return $files | Sort-Object -Property Name | Select-Object Name, Length
}

# 6 Hidden files
function Hidden_files {
    return Get-ChildItem -Hidden -Path $HOME/master-degree -Recurse
}

# 7 Bigger than 1MB
function Big_files {
    return $files | Where-Object {$_.Length -ge 1MB} | select Name, Length
}

