# ImGui.NET

This is a .NET wrapper for the immediate mode GUI library, Dear ImGui (https://github.com/ocornut/imgui). ImGui.NET lets you build graphical interfaces using a simple immediate-mode style. ImGui.NET is a .NET Standard library, and can be used on all major .NET runtimes and operating systems.

Included is a basic sample program that shows how to use the library, and renders the UI using [Veldrid](https://github.com/mellinoe/veldrid), a portable graphics library for .NET. By itself, Dear ImGui does not care what technology you use for rendering; it simply outputs textured triangles. Example renderers also exist for MonoGame and OpenTK (OpenGL).

This wrapper is built on top of [cimgui](https://github.com/Extrawurst/cimgui), which exposes a plain C API for Dear ImGui. If you are using Windows, OSX, or a mainline Linux distribution, then the ImGui.NET NuGet package comes bundled with a pre-built native library. If you are using another operating system, then you may need to build the native library yourself; see the cimgui repo for build instructions.

[![NuGet](https://img.shields.io/nuget/v/ImGui.NET.svg)](https://www.nuget.org/packages/ImGui.NET)

[![Join the chat at https://gitter.im/ImGui-NET/Lobby](https://badges.gitter.im/ImGui-NET/Lobby.svg)](https://gitter.im/ImGui-NET/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

# Building

ImGui.NET can be built in Visual Studio or on the command line. The .NET Core SDK is needed to build on the command line, and it can be downloaded [here](https://www.microsoft.com/net/core). Visual Studio 2017 is the minimum VS version supported for building.

# Usage

ImGui.NET currently provides a raw wrapper around the ImGui native API, and also provides a very thin safe, managed API for convenience. It is currently very much like using the native library, which is very simple, flexible, and robust. The easiest way to figure out how to use the library is to read the documentation of imgui itself, mostly in the imgui.cpp, and imgui.h files, as well as the exported functions in cimgui.h. Looking at the sample program code will also give some indication about basic usage.

# See Also

https://github.com/ocornut/imgui
> Dear ImGui is a bloat-free graphical user interface library for C++. It outputs optimized vertex buffers that you can render anytime in your 3D-pipeline enabled application. It is fast, portable, renderer agnostic and self-contained (no external dependencies).

> Dear ImGui is designed to enable fast iterations and to empower programmers to create content creation tools and visualization / debug tools (as opposed to UI for the average end-user). It favors simplicity and productivity toward this goal, and lacks certain features normally found in more high-level libraries.

> Dear ImGui is particularly suited to integration in games engine (for tooling), real-time 3D applications, fullscreen applications, embedded applications, or any applications on consoles platforms where operating system features are non-standard.

See the [official screenshot thread](https://github.com/ocornut/imgui/issues/123) for examples of many different kinds of interfaces created with Dear ImGui.

https://github.com/cimgui/cimgui
> This is a thin c-api wrapper for the excellent C++ intermediate gui imgui. This library is intended as a intermediate layer to be able to use imgui from other languages that can interface with C .
