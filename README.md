# ImGui.NET

This is a wrapper for the immediate mode GUI library, ImGui (https://github.com/ocornut/imgui). This utilizes the C API, provided by the cimgui project (https://github.com/Extrawurst/cimgui). ImGui.NET lets you build graphical interfaces using a simple immediate-mode style. Included is a basic sample program that shows how to use the library, which renders the ImGui output using OpenGL via OpenTK.

[![NuGet](https://img.shields.io/nuget/v/ImGui.NET.svg)]()

![alt tag](http://i.imgur.com/02RGlsW.png)

# Building

ImGui.NET can be built in Visual Studio or on the command line. The .NET Core SDK is needed to build on the command line, and it can be downloaded [here](https://www.microsoft.com/net/core). Visual Studio 2017 is the minimum VS version supported for building.

# Usage
ImGui.NET currently provides a raw wrapper around the ImGui native API, and also provides a very thin safe, managed API for convenience. It is currently very much like using the native library, which is very simple, flexible, and robust. The easiest way to figure out how to use the library is to read the documentation of imgui itself, mostly in the imgui.cpp, and imgui.h files, as well as the exported functions in cimgui.h. Looking at the sample program code will also give some indication about basic usage.

# Known Issues
* The only bundled native Linux binary is for Ubuntu 16.04. Other Linux distros may require a different binary. This can be produced by cloning the cimgui repository (see below), and building it.

# See Also
https://github.com/ocornut/imgui
> ImGui is a bloat-free graphical user interface library for C++. It outputs vertex buffers that you can render in your 3D-pipeline enabled application. It is portable, renderer agnostic and self-contained (no external dependencies). It is based on an "immediate mode" graphical user interface paradigm which enables you to build user interfaces with ease.

https://github.com/Extrawurst/cimgui
> This is a thin c-api wrapper for the excellent C++ intermediate gui imgui. This library is intended as a intermediate layer to be able to use imgui from other languages that can interface with C .
