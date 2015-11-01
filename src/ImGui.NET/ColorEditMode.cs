using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImGui
{
    /// <summary>
    /// Enumeration for ColorEditMode()
    /// </summary>
    public enum ColorEditMode
    {
        UserSelect = -2,
        UserSelectShowButton = -1,
        RGB = 0,
        HSV = 1,
        HEX = 2
    }
}
