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
New-Item -ItemType Directory -Force -Path $PSScriptRoot\deps\cimgui\linux-x64 | Out-Null
New-Item -ItemType Directory -Force -Path $PSScriptRoot\deps\cimgui\osx | Out-Null
New-Item -ItemType Directory -Force -Path $PSScriptRoot\deps\cimgui\win-x86 | Out-Null
New-Item -ItemType Directory -Force -Path $PSScriptRoot\deps\cimgui\win-x64 | Out-Null
New-Item -ItemType Directory -Force -Path $PSScriptRoot\deps\cimgui\win-arm64 | Out-Null

[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12

$client = New-Object System.Net.WebClient
$client.DownloadFile(
    "$repository/releases/download/$tag/cimgui.win-x86.dll",
    "$PSScriptRoot/deps/cimgui/win-x86/cimgui.dll")
if( -not $? )
{
    $msg = $Error[0].Exception.Message
    Write-Error "Couldn't download x86 cimgui.dll. This most likely indicates the Windows native build failed."
    exit
}

Write-Host "- cimgui.dll (x86)"

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
    "$repository/releases/download/$tag/cimgui.win-arm64.dll",
    "$PSScriptRoot/deps/cimgui/win-arm64/$configuration/cimgui.dll")
if( -not $? )
{
    $msg = $Error[0].Exception.Message
    Write-Error "Couldn't download arm64 cimgui.dll. This most likely indicates the Windows native build failed."
    exit
}

Write-Host "- cimgui.dll (arm64)"

$client.DownloadFile(
    "$repository/releases/download/$tag/cimgui.so",
    "$PSScriptRoot/deps/cimgui/linux-x64/cimgui.so")
if( -not $? )
{
    $msg = $Error[0].Exception.Message
    Write-Error "Couldn't download cimgui.so. This most likely indicates the Linux native build failed."
    exit
}

Write-Host - cimgui.so

$client.DownloadFile(
    "$repository/releases/download/$tag/cimgui.dylib",
    "$PSScriptRoot/deps/cimgui/osx/cimgui.dylib")
if( -not $? )
{
    $msg = $Error[0].Exception.Message
    Write-Error "Couldn't download cimgui.dylib. This most likely indicates the macOS native build failed."
    exit
}

Write-Host "- cimgui.dylib"

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
