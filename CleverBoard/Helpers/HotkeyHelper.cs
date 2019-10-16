using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CleverBoard.Helpers
{
    public static class HotkeyHelper
    {
    
        public static string KeyToString(Keys keys)
        {


            uint num = Win32.MapVirtualKey((uint)keys, 0U);



            switch (keys)
            {
                case Keys.Prior:
                case Keys.Next:
                case Keys.End:
                case Keys.Home:
                case Keys.Left:
                case Keys.Up:
                case Keys.Right:
                case Keys.Down:
                case Keys.Insert:
                case Keys.Delete:
                case Keys.Divide:
                case Keys.NumLock:
                    num |= 256U;
                    break;
            }
            StringBuilder lpString = new StringBuilder(260);
            if (Win32.GetKeyNameText(num << 16, lpString, 260) == 0)
                return Properties.strings.None;
            return lpString.ToString();
        }
        public static uint GetModifiers(bool Ctrl, bool Alt, bool Shift)
        {
            return 0u + (Ctrl ? 1u : 0u) + (Alt ? 2u : 0u) + (Shift ? 4u : 0u);
        }

    }
}
