#ImGui.NET

This is a wrapper for the immediate mode GUI library, ImGui (https://github.com/ocornut/imgui). This utilizes the C API, provided by the cimgui project (https://github.com/Extrawurst/cimgui). ImGui.NET lets you build graphical interfaces using a simple immediate-mode style. Included is a basic sample program that shows how to use the library, which renders the ImGui output using OpenGL via OpenTK.

A [NuGet package](https://www.nuget.org/packages/ImGui.NET) is available at nuget.org

![alt tag](http://i.imgur.com/02RGlsW.png)

#Building

Currently, you need VS 2015 to build this. You must have the "Visual Studio Tools for Universal Windows App" optional component installed in order to use the new NuGet features (check the VS installer menu to add it), as well as have an up-to-date NuGet plugin (check the VS extension manager). Simply restore all of the NuGet packages (nuget.exe restore or similar) and run msbuild on the project files or solution. Building in VS will automatically restore the NuGet packages as necessary. It is not necessary to build the SampleProgram project unless you wish to test it out.

The cimgui dependencies included in this repository are currently only built for x64 Windows. If you use this library from somewhere else, you will need to recompile the native assemblies for your target platform. The project home pages for the project is linked below, and the project is very easy to build. OpenTK is also included in the repository, using a version of the library ported to .NET Core.

I have tested the current state of the library on x64 Windows 8.1, 10, and Ubuntu 15.04.

#Usage
ImGui.NET currently provides a raw, thin wrapper around the ImGui native API, and does not attempt to apply any higher-level abstractions over it. It is currently very much like using the native library, which is very simple, flexible, and robust.  The easiest way to figure out how to use the library is to read the documentation of imgui itself, mostly in the imgui.cpp, and imgui.h files, as well as the exported functions in cimgui.h. Looking at the sample program code will also give some indication about basic usage. In the future, I plan to create a more comprehensive C# wrapper with higher-level abstractions and better use of C#/.NET features.

#Known Issues
* There are not wrapper methods for all of the exported native functions from cimgui. All of the functionality is exposed through the ImGuiNative class, but the interface there is very raw and requires unsafe code. Right now I am working to add safe wrappers for each of the native methods, emulating the original optional arguments and allowing you to use strictly-safe code with ImGui.
* There is not an easy deployment story for different platforms. You need to build the native components yourself on each platform. The included native binary is only for x64 Windows.

#See Also
https://github.com/ocornut/imgui
> ImGui is a bloat-free graphical user interface library for C++. It outputs vertex buffers that you can render in your 3D-pipeline enabled application. It is portable, renderer agnostic and self-contained (no external dependencies). It is based on an "immediate mode" graphical user interface paradigm which enables you to build user interfaces with ease.

https://github.com/Extrawurst/cimgui
> This is a thin c-api wrapper for the excellent C++ intermediate gui imgui. This library is intended as a intermediate layer to be able to use imgui from other languages that can interface with C .
