using ImGuiInputTextFlags = System.Int32;
using ImWchar = System.UInt16;
using ImGuiKey = System.Int32;
using System.Runtime.InteropServices;

namespace ImGui
{
    // Shared state of InputText(), passed to callback when a ImGuiInputTextFlags_Callback* flag is used.
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ImGuiTextEditCallbackData
    {
        //ImGuiInputTextFlags EventFlag;      // One of ImGuiInputTextFlags_Callback* // Read-only
        //ImGuiInputTextFlags Flags;          // What user passed to InputText()      // Read-only
        //IntPtr UserData;       // What user passed to InputText()      // Read-only
        //bool ReadOnly;       // Read-only mode                       // Read-only

        //// CharFilter event:
        //ImWchar EventChar;      // Character input                      // Read-write (replace character or set to zero)

        //// Completion,History,Always events:
        //ImGuiKey EventKey;       // Key pressed (Up/Down/TAB)            // Read-only
        //char* Buf;            // Current text                         // Read-write (pointed data only)
        //int BufSize;        //                                      // Read-only
        bool BufDirty;       // Must set if you modify Buf directly  // Write
        int CursorPos;      //                                      // Read-write
        int SelectionStart; //                                      // Read-write (== to SelectionEnd when no selection)
        int SelectionEnd;   //                                      // Read-write

        // NB: calling those function loses selection.
        /*
        void DeleteChars(int pos, int bytes_count);
        void InsertChars(int pos, const char* text, const char* text_end = NULL);
        bool HasSelection() const { return SelectionStart != SelectionEnd; }
        */
    }
}
