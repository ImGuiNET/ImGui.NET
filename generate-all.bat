@setlocal
@echo off

dotnet run -p src\CodeGenerator\CodeGenerator.csproj src\ImGui.NET\Generated cimgui true
dotnet run -p src\CodeGenerator\CodeGenerator.csproj src\ImPlot.NET\Generated cimplot false
dotnet run -p src\CodeGenerator\CodeGenerator.csproj src\ImNodes.NET\Generated cimnodes true
dotnet run -p src\CodeGenerator\CodeGenerator.csproj src\ImGuizmo.NET\Generated cimguizmo true
