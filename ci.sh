IMGUI_NET_SRC="$PWD/src"
IMGUI_NET_GEN_FOLDER="$PWD/bin/Release/CodeGenerator/netcoreapp3.1/gen"

echo "\033[32m Cleaning folders... \033[0m"
rm -f $IMGUI_NET_SRC/ImGui.NET/Generated/*.*
rm -f $IMGUI_NET_SRC/ImGuizmo.NET/Generated/*.*
rm -f $IMGUI_NET_SRC/ImNodes.NET/Generated/*.*
rm -f $IMGUI_NET_SRC/ImPlot.NET/Generated/*.*

echo "\n \033[32mGenerating code ... \033[0m\n"
cd "$IMGUI_NET_SRC/CodeGenerator"
dotnet run --configuration Release

echo "\n \033[32mCopying files to folders ... \033[0m\n"
cp -R $IMGUI_NET_GEN_FOLDER/cimgui/. $IMGUI_NET_SRC/ImGui.NET/Generated/
cp -R $IMGUI_NET_GEN_FOLDER/cimguizmo/. $IMGUI_NET_SRC/ImGuizmo.NET/Generated/
cp -R $IMGUI_NET_GEN_FOLDER/cimnodes/. $IMGUI_NET_SRC/ImNodes.NET/Generated/
cp -R $IMGUI_NET_GEN_FOLDER/cimplot/. $IMGUI_NET_SRC/ImPlot.NET/Generated/

echo "\n \033[35mFinished"
