
using System.ComponentModel;

namespace CleverBoard.Hotkey
{
    public class HotkeyBinding
    {

        public string Name;
        public string Description;
        public bool Enabled;
        public Hotkey Hotkey;
        public bool IsPython;
        public bool Blacklist;
        public BindingList<string> ProcessList;
        public string Action;
        public bool CapsActionEnabled;
        public string ActionAlternate;


        public override string ToString()
        {

            return  (Enabled ? "" : "["+  Properties.strings.Disabled +"] ") + (IsPython ? "[Py] " : "") + Name + " - " + Hotkey.ToString();
        }

        public HotkeyBinding()
        {

            Hotkey = new Hotkey();
            ProcessList = new BindingList<string>();
            Blacklist = true;
            Name = Properties.strings.New_hotkey;
            Enabled = true;


        }


    }
}
