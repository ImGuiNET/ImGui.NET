param (
    [Parameter(Mandatory=$false)][string]$repository,
    [Parameter(Mandatory=$true)][string]$tag
)

if( -not $repository )
{
    $repository="https://github.com/mellinoe/imgui.net-nativebuild"
}

Write-Host Downloading native binaries from GitHub Releases...

if (Test-Path $PSScriptRoot\deps\cimgui\)
{
    Remove-Item $PSScriptRoot\deps\cimgui\ -Force -Recurse | Out-Null
}
New-Item -ItemType Directory -Force -Path $PSScriptRoot\deps\cimgui\win-x64 | Out-Null

[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12

$client = New-Object System.Net.WebClient

$client.DownloadFile(
    "$repository/releases/download/$tag/cimgui.win-x64.dll",
    "$PSScriptRoot/deps/cimgui/win-x64/$configuration/cimgui.dll")
if( -not $? )
{
    $msg = $Error[0].Exception.Message
    Write-Error "Couldn't download x64 cimgui.dll. This most likely indicates the Windows native build failed."
    exit
}

Write-Host "- cimgui.dll (x64)"

$client.DownloadFile(
    "https://github.com/mellinoe/imgui.net-nativebuild/releases/download/$tag/definitions.json",
    "$PSScriptRoot/src/CodeGenerator/definitions/cimgui/definitions.json")
if( -not $? )
{
    $msg = $Error[0].Exception.Message
    Write-Error "Couldn't download definitions.json."
    exit
}

Write-Host - definitions.json

$client.DownloadFile(
    "https://github.com/mellinoe/imgui.net-nativebuild/releases/download/$tag/structs_and_enums.json",
    "$PSScriptRoot/src/CodeGenerator/definitions/cimgui/structs_and_enums.json")
if( -not $? )
{
    $msg = $Error[0].Exception.Message
    Write-Error "Couldn't download structs_and_enums.json."
    exit
}

Write-Host - structs_and_enums.json
