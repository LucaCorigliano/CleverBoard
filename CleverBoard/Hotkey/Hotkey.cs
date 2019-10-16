using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace CleverBoard.Hotkey
{
    public class Hotkey
    {
        public bool Ctrl;
        public bool Alt;
        public bool Shift;
        public bool CapsLock;

        public Keys Key;

        public override string ToString()
        {
            return  (Ctrl ? Properties.strings.CTRL + "+" : "") + (Alt ? Properties.strings.ALT + "+" : "") +  (Shift ? Properties.strings.SHIFT + "+" : "") + Helpers.HotkeyHelper.KeyToString(Key);
        }
        public Hotkey()
        {

            Key = Keys.None;
        }
    }
}
