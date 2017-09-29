namespace ImGuiNET
{
    /// <summary>
    /// Enumeration for ColorEdit3() / ColorEdit4() / ColorPicker3() / ColorPicker4() / ColorButton()
    /// </summary>
    public enum ColorEditFlags : int
    {
        Default = 0,
        NoAlpha = 1 << 1,          
        NoPicker = 1 << 2,  
        NoOptions = 1 << 3, 
        NoSmallPreview = 1 << 4,
        NoInputs = 1 << 5,        
        NoTooltip = 1 << 6,  
        NoLabel = 1 << 7,          
        NoSidePreview = 1 << 8,   
        AlphaBar = 1 << 9,      
        AlphaPreview = 1 << 10,  
        AlphaPreviewHalf = 1 << 11,  
        HDR = 1 << 12,          
        RGB = 1 << 13,  
        HSV = 1 << 14,  
        HEX = 1 << 15,  
        Uint8 = 1 << 16,
        Float = 1 << 17, 
        PickerHueBar = 1 << 18,  
        PickerHueWheel = 1 << 19,
    }
}
