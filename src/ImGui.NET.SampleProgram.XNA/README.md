# ImGui.NET renderer for XNA-likes (FNA & MonoGame)

To run this sample program:

## MonoGame (default, NuGet package for "DesktopGL"-version already installed)
- Download the SDL2 dll from https://www.libsdl.org/download-2.0.php and copy it to the project output directory

## FNA
- Remove the MonoGame.Framework.DesktopGL NuGet package
- Download FNA from https://github.com/FNA-XNA/FNA/releases and add a reference to it
- Download the native FNA dependencies from https://github.com/FNA-XNA/FNA/wiki/3:-Distributing-FNA-Games and copy them to the project output directory
- Replace the marked MonoGame-specific parts of the code with their commented FNA counterparts (search for "FNA-specific")
