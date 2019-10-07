using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CleverBoard
{
    public class Binding
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

            return  (Enabled ? "" : "[Disabled] ") + (IsPython ? "[Py] " : "") + Name + " - " + Hotkey.ToString();
        }

        public Binding()
        {

            Hotkey = new Hotkey();
            ProcessList = new BindingList<string>();
            Blacklist = true;
            Name = "New Hotkey";
            Enabled = true;


        }


    }
}
