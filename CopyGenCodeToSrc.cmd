@setlocal
@echo off

del /F /Q %~dp0src\ImGui.NET\Generated\*.*
del /F /Q %~dp0src\ImGuizmo.NET\Generated\*.*
del /F /Q %~dp0src\ImNodes.NET\Generated\*.*
del /F /Q %~dp0src\ImPlot.NET\Generated\*.*

copy %~dp0bin\Release\CodeGenerator\netcoreapp3.1\gen\cimgui\*.* %~dp0src\ImGui.NET\Generated
copy %~dp0bin\Release\CodeGenerator\netcoreapp3.1\gen\cimguizmo\*.* %~dp0src\ImGuizmo.NET\Generated
copy %~dp0bin\Release\CodeGenerator\netcoreapp3.1\gen\cimnodes\*.* %~dp0src\ImNodes.NET\Generated
copy %~dp0bin\Release\CodeGenerator\netcoreapp3.1\gen\cimplot\*.* %~dp0src\ImPlot.NET\Generated
