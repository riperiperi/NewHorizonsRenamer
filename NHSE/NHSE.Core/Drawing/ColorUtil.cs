﻿using System.Drawing;
using System.Linq;

namespace NHSE.Core
{
    public static class ColorUtil
    {
        public static readonly Color[] Colors = new[]
        {
            0xD9D9D9, 0xCCD9E8, 0x7F7F7F, 0xD5D5D5, 0xF7F7F7, 0xCFCFCF, 0xB4B4B4, 0xF1F1F1,
            0xFFFFFF, 0x7F7F7F, 0x7F7F7F, 0xB6B6B6, 0x7FBBEB, 0xFFFFFF, 0x7FB2E5, 0xF9FBFD,
            0xDFE6ED, 0x7F7F7F, 0xFFFFF0, 0x7F7F7F, 0xF7F7F7, 0x7F7F7F, 0xE3E3E3, 0xFFFFFF,
            0xB1B1B1, 0x7F7F7F, 0xFFFFFF, 0xF7FBFF, 0xFCF5EB, 0x7FFFFF, 0xBFFFE9, 0xF7FFFF,
            0xFAFAED, 0xFFF1E1, 0x7F7F7F, 0xFFF5E6, 0x7F7FFF, 0xC495F0, 0xD29494, 0xEEDBC3,
            0xAFCECF, 0xBFFF7F, 0xE8B48E, 0xFFBFA7, 0xB1CAF6, 0xFFFBED, 0xED899D, 0x7FFFFF,
            0x7F7FC5, 0x7FC5C5, 0xDBC285, 0xD4D4D4, 0x7FB17F, 0xDEDBB5, 0xC57FC5, 0xAAB597,
            0xFFC57F, 0xCC98E5, 0xC57F7F, 0xF4CABC, 0xC7DDC5, 0xA39EC5, 0x97A7A7, 0x7FE6E8,
            0xC97FE9, 0xFF89C9, 0x7FDFFF, 0xB4B4B4, 0x8EC7FF, 0xD89090, 0xFFFCF7, 0x90C590,
            0xFF7FFF, 0xEDEDED, 0xFBFBFF, 0xFFEB7F, 0xECD28F, 0xBFBFBF, 0x7FBF7F, 0xD6FF97,
            0xF7FFF7, 0xFFB4D9, 0xE6ADAD, 0xA57FC0, 0xFFFFF7, 0xF7F2C5, 0xF2F2FC, 0xFFF7FA,
            0xBDFD7F, 0xFFFCE6, 0xD6EBF2, 0xF7BFBF, 0xEFFFFF, 0xFCFCE8, 0xE9E9E9, 0xC7F6C7,
            0xFFDAE0, 0xFFCFBC, 0x8FD8D4, 0xC3E6FC, 0xBBC3CC, 0xD7E1EE, 0xFFFFEF, 0x7FFF7F,
            0x98E698, 0xFCF7F2, 0xFF7FFF, 0xBF7F7F, 0xB2E6D4, 0x7F7FE6, 0xDCAAE9, 0xC9B7ED,
            0x9DD9B8, 0xBDB3F6, 0x7FFCCC, 0xA3E8E5, 0xE38AC2, 0x8C8CB7, 0xFAFFFC, 0xFFF1F0,
            0xFFF1DA, 0xFFEED6, 0x7F7FBF, 0xFEFAF2, 0xBFBF7F, 0xB5C691, 0xFFD27F, 0xFFA27F,
            0xECB7EA, 0xF6F3D4, 0xCBFDCB, 0xD7F6F6, 0xEDB7C9, 0xFFF7EA, 0xFFECDC, 0xE6C29F,
            0xFFDFE5, 0xEECFEE, 0xD7EFF2, 0xBF7FBF, 0xFF7F7F, 0xDDC7C7, 0xA0B4F0, 0xC5A289,
            0xFCBFB8, 0xF9D1AF, 0x96C5AB, 0xFFFAF6, 0xCFA896, 0xDFDFDF, 0xC3E6F5, 0xB4ACE6,
            0xB7BFC7, 0xFFFCFC, 0x7FFFBF, 0xA2C0D9, 0xE8D9C5, 0x7FBFBF, 0xEBDFEB, 0xFFB1A3,
            0x9FEFE7, 0xF6C0F6, 0xFAEED9, 0xFFFFFF, 0xFAFAFA, 0xFFFF7F, 0xCCE698, 0xF7F7F7,
            0xFFFFFF, 0xCFCFCF, 0xDCE8F4, 0xEBF1F8, 0xF7F7F7, 0x99CCFF,
        }.Select(z => Color.FromArgb(z | -0x1000000)).ToArray();

        public static Color Blend(Color color, Color backColor, double amount)
        {
            byte r = (byte)((color.R * amount) + (backColor.R * (1 - amount)));
            byte g = (byte)((color.G * amount) + (backColor.G * (1 - amount)));
            byte b = (byte)((color.B * amount) + (backColor.B * (1 - amount)));
            return Color.FromArgb(r, g, b);
        }
    }
}
