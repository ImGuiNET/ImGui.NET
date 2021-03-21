using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace imnodesNET
{
    public unsafe partial struct Style
    {
        public float grid_spacing;
        public float node_corner_rounding;
        public float node_padding_horizontal;
        public float node_padding_vertical;
        public float node_border_thickness;
        public float link_thickness;
        public float link_line_segments_per_length;
        public float link_hover_distance;
        public float pin_circle_radius;
        public float pin_quad_side_length;
        public float pin_triangle_side_length;
        public float pin_line_thickness;
        public float pin_hover_radius;
        public float pin_offset;
        public StyleFlags flags;
        public fixed uint colors[16];
    }
    public unsafe partial struct StylePtr
    {
        public Style* NativePtr { get; }
        public StylePtr(Style* nativePtr) => NativePtr = nativePtr;
        public StylePtr(IntPtr nativePtr) => NativePtr = (Style*)nativePtr;
        public static implicit operator StylePtr(Style* nativePtr) => new StylePtr(nativePtr);
        public static implicit operator Style* (StylePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator StylePtr(IntPtr nativePtr) => new StylePtr(nativePtr);
        public ref float grid_spacing => ref Unsafe.AsRef<float>(&NativePtr->grid_spacing);
        public ref float node_corner_rounding => ref Unsafe.AsRef<float>(&NativePtr->node_corner_rounding);
        public ref float node_padding_horizontal => ref Unsafe.AsRef<float>(&NativePtr->node_padding_horizontal);
        public ref float node_padding_vertical => ref Unsafe.AsRef<float>(&NativePtr->node_padding_vertical);
        public ref float node_border_thickness => ref Unsafe.AsRef<float>(&NativePtr->node_border_thickness);
        public ref float link_thickness => ref Unsafe.AsRef<float>(&NativePtr->link_thickness);
        public ref float link_line_segments_per_length => ref Unsafe.AsRef<float>(&NativePtr->link_line_segments_per_length);
        public ref float link_hover_distance => ref Unsafe.AsRef<float>(&NativePtr->link_hover_distance);
        public ref float pin_circle_radius => ref Unsafe.AsRef<float>(&NativePtr->pin_circle_radius);
        public ref float pin_quad_side_length => ref Unsafe.AsRef<float>(&NativePtr->pin_quad_side_length);
        public ref float pin_triangle_side_length => ref Unsafe.AsRef<float>(&NativePtr->pin_triangle_side_length);
        public ref float pin_line_thickness => ref Unsafe.AsRef<float>(&NativePtr->pin_line_thickness);
        public ref float pin_hover_radius => ref Unsafe.AsRef<float>(&NativePtr->pin_hover_radius);
        public ref float pin_offset => ref Unsafe.AsRef<float>(&NativePtr->pin_offset);
        public ref StyleFlags flags => ref Unsafe.AsRef<StyleFlags>(&NativePtr->flags);
        public RangeAccessor<uint> colors => new RangeAccessor<uint>(NativePtr->colors, 16);
        public void Destroy()
        {
            imnodesNative.Style_destroy((Style*)(NativePtr));
        }
    }
}
