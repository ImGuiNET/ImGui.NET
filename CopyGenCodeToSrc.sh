IMGUI_NET_SRC="$PWD/src"
IMGUI_NET_GEN_FOLDER="$PWD/bin/Release/CodeGenerator/netcoreapp3.1/gen"

del /F /Q $IMGUI_NET_SRC/ImGui.NET/Generated/*.*
del /F /Q $IMGUI_NET_SRC/ImGuizmo.NET/Generated/*.*
del /F /Q $IMGUI_NET_SRC/ImNodes.NET/Generated/*.*
del /F /Q $IMGUI_NET_SRC/ImPlot.NET/Generated/*.*

cp $IMGUI_NET_GEN_FOLDER/cimgui/*.* $IMGUI_NET_SRC/ImGui.NET/Generated
cp $IMGUI_NET_GEN_FOLDER/cimguizmo/*.* $IMGUI_NET_SRC/ImGuizmo.NET/Generated
cp $IMGUI_NET_GEN_FOLDER/cimnodes/*.* $IMGUI_NET_SRC/ImNodes.NET/Generated
cp $IMGUI_NET_GEN_FOLDER/cimplot/*.* $IMGUI_NET_SRC/ImPlot.NET/Generated
