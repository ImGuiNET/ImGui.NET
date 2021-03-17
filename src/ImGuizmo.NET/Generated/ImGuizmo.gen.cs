using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using ImGuiNET;

namespace ImGuizmoNET
{
    public static unsafe partial class ImGuizmo
    {
        public static void AllowAxisFlip(bool value)
        {
            byte native_value = value ? (byte)1 : (byte)0;
            ImGuizmoNative.ImGuizmo_AllowAxisFlip(native_value);
        }
        public static void BeginFrame()
        {
            ImGuizmoNative.ImGuizmo_BeginFrame();
        }
        public static void DecomposeMatrixToComponents(ref float matrix, ref float translation, ref float rotation, ref float scale)
        {
            fixed (float* native_matrix = &matrix)
            {
                fixed (float* native_translation = &translation)
                {
                    fixed (float* native_rotation = &rotation)
                    {
                        fixed (float* native_scale = &scale)
                        {
                            ImGuizmoNative.ImGuizmo_DecomposeMatrixToComponents(native_matrix, native_translation, native_rotation, native_scale);
                        }
                    }
                }
            }
        }
        public static void DrawCubes(ref float view, ref float projection, ref float matrices, int matrixCount)
        {
            fixed (float* native_view = &view)
            {
                fixed (float* native_projection = &projection)
                {
                    fixed (float* native_matrices = &matrices)
                    {
                        ImGuizmoNative.ImGuizmo_DrawCubes(native_view, native_projection, native_matrices, matrixCount);
                    }
                }
            }
        }
        public static void DrawGrid(ref float view, ref float projection, ref float matrix, float gridSize)
        {
            fixed (float* native_view = &view)
            {
                fixed (float* native_projection = &projection)
                {
                    fixed (float* native_matrix = &matrix)
                    {
                        ImGuizmoNative.ImGuizmo_DrawGrid(native_view, native_projection, native_matrix, gridSize);
                    }
                }
            }
        }
        public static void Enable(bool enable)
        {
            byte native_enable = enable ? (byte)1 : (byte)0;
            ImGuizmoNative.ImGuizmo_Enable(native_enable);
        }
        public static bool IsOver()
        {
            byte ret = ImGuizmoNative.ImGuizmo_IsOverNil();
            return ret != 0;
        }
        public static bool IsOver(OPERATION op)
        {
            byte ret = ImGuizmoNative.ImGuizmo_IsOverOPERATION(op);
            return ret != 0;
        }
        public static bool IsUsing()
        {
            byte ret = ImGuizmoNative.ImGuizmo_IsUsing();
            return ret != 0;
        }
        public static bool Manipulate(ref float view, ref float projection, OPERATION operation, MODE mode, ref float matrix)
        {
            float* deltaMatrix = null;
            float* snap = null;
            float* localBounds = null;
            float* boundsSnap = null;
            fixed (float* native_view = &view)
            {
                fixed (float* native_projection = &projection)
                {
                    fixed (float* native_matrix = &matrix)
                    {
                        byte ret = ImGuizmoNative.ImGuizmo_Manipulate(native_view, native_projection, operation, mode, native_matrix, deltaMatrix, snap, localBounds, boundsSnap);
                        return ret != 0;
                    }
                }
            }
        }
        public static bool Manipulate(ref float view, ref float projection, OPERATION operation, MODE mode, ref float matrix, ref float deltaMatrix)
        {
            float* snap = null;
            float* localBounds = null;
            float* boundsSnap = null;
            fixed (float* native_view = &view)
            {
                fixed (float* native_projection = &projection)
                {
                    fixed (float* native_matrix = &matrix)
                    {
                        fixed (float* native_deltaMatrix = &deltaMatrix)
                        {
                            byte ret = ImGuizmoNative.ImGuizmo_Manipulate(native_view, native_projection, operation, mode, native_matrix, native_deltaMatrix, snap, localBounds, boundsSnap);
                            return ret != 0;
                        }
                    }
                }
            }
        }
        public static bool Manipulate(ref float view, ref float projection, OPERATION operation, MODE mode, ref float matrix, ref float deltaMatrix, ref float snap)
        {
            float* localBounds = null;
            float* boundsSnap = null;
            fixed (float* native_view = &view)
            {
                fixed (float* native_projection = &projection)
                {
                    fixed (float* native_matrix = &matrix)
                    {
                        fixed (float* native_deltaMatrix = &deltaMatrix)
                        {
                            fixed (float* native_snap = &snap)
                            {
                                byte ret = ImGuizmoNative.ImGuizmo_Manipulate(native_view, native_projection, operation, mode, native_matrix, native_deltaMatrix, native_snap, localBounds, boundsSnap);
                                return ret != 0;
                            }
                        }
                    }
                }
            }
        }
        public static bool Manipulate(ref float view, ref float projection, OPERATION operation, MODE mode, ref float matrix, ref float deltaMatrix, ref float snap, ref float localBounds)
        {
            float* boundsSnap = null;
            fixed (float* native_view = &view)
            {
                fixed (float* native_projection = &projection)
                {
                    fixed (float* native_matrix = &matrix)
                    {
                        fixed (float* native_deltaMatrix = &deltaMatrix)
                        {
                            fixed (float* native_snap = &snap)
                            {
                                fixed (float* native_localBounds = &localBounds)
                                {
                                    byte ret = ImGuizmoNative.ImGuizmo_Manipulate(native_view, native_projection, operation, mode, native_matrix, native_deltaMatrix, native_snap, native_localBounds, boundsSnap);
                                    return ret != 0;
                                }
                            }
                        }
                    }
                }
            }
        }
        public static bool Manipulate(ref float view, ref float projection, OPERATION operation, MODE mode, ref float matrix, ref float deltaMatrix, ref float snap, ref float localBounds, ref float boundsSnap)
        {
            fixed (float* native_view = &view)
            {
                fixed (float* native_projection = &projection)
                {
                    fixed (float* native_matrix = &matrix)
                    {
                        fixed (float* native_deltaMatrix = &deltaMatrix)
                        {
                            fixed (float* native_snap = &snap)
                            {
                                fixed (float* native_localBounds = &localBounds)
                                {
                                    fixed (float* native_boundsSnap = &boundsSnap)
                                    {
                                        byte ret = ImGuizmoNative.ImGuizmo_Manipulate(native_view, native_projection, operation, mode, native_matrix, native_deltaMatrix, native_snap, native_localBounds, native_boundsSnap);
                                        return ret != 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void RecomposeMatrixFromComponents(ref float translation, ref float rotation, ref float scale, ref float matrix)
        {
            fixed (float* native_translation = &translation)
            {
                fixed (float* native_rotation = &rotation)
                {
                    fixed (float* native_scale = &scale)
                    {
                        fixed (float* native_matrix = &matrix)
                        {
                            ImGuizmoNative.ImGuizmo_RecomposeMatrixFromComponents(native_translation, native_rotation, native_scale, native_matrix);
                        }
                    }
                }
            }
        }
        public static void SetDrawlist()
        {
            ImDrawList* drawlist = null;
            ImGuizmoNative.ImGuizmo_SetDrawlist(drawlist);
        }
        public static void SetDrawlist(ImDrawListPtr drawlist)
        {
            ImDrawList* native_drawlist = drawlist.NativePtr;
            ImGuizmoNative.ImGuizmo_SetDrawlist(native_drawlist);
        }
        public static void SetGizmoSizeClipSpace(float value)
        {
            ImGuizmoNative.ImGuizmo_SetGizmoSizeClipSpace(value);
        }
        public static void SetID(int id)
        {
            ImGuizmoNative.ImGuizmo_SetID(id);
        }
        public static void SetImGuiContext(IntPtr ctx)
        {
            ImGuizmoNative.ImGuizmo_SetImGuiContext(ctx);
        }
        public static void SetOrthographic(bool isOrthographic)
        {
            byte native_isOrthographic = isOrthographic ? (byte)1 : (byte)0;
            ImGuizmoNative.ImGuizmo_SetOrthographic(native_isOrthographic);
        }
        public static void SetRect(float x, float y, float width, float height)
        {
            ImGuizmoNative.ImGuizmo_SetRect(x, y, width, height);
        }
        public static void ViewManipulate(ref float view, float length, Vector2 position, Vector2 size, uint backgroundColor)
        {
            fixed (float* native_view = &view)
            {
                ImGuizmoNative.ImGuizmo_ViewManipulate(native_view, length, position, size, backgroundColor);
            }
        }
    }
}
