using CleverBoard.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Python.Runtime;
using System.Threading;
using static Python.Runtime.Py;
using System.Diagnostics;

namespace CleverBoard.Hotkey
{
    public class HotkeyListener
    {
        public bool IsListening;
        private  IntPtr _handle;

 
        public void SetHandle(IntPtr handle) {
            _handle = handle;
        }
        ~HotkeyListener()
        {
            StopListening();
        }

        public void StopListening()
        {
            if (!IsListening)
                return;
            IsListening = false;
            for (int id = 0; id <= Program.BindingManager.Bindings.Count; ++id)
                Win32.UnregisterHotKey(this._handle, id);
        }

        public void StartListening()
        {
            if (IsListening)
                return;
            IsListening = true;
            int num = 0;
            foreach (HotkeyBinding binding in Program.BindingManager.Bindings)
            {
                if (binding.Enabled == false)
                    continue;
                Win32.RegisterHotKey(_handle, num++, HotkeyHelper.GetModifiers(binding.Hotkey.Ctrl, binding.Hotkey.Alt, binding.Hotkey.Shift), (uint)binding.Hotkey.Key);
            }
        }

        private void PythonSendDelegate(string input)
        {
            if (!PythonEngine.IsInitialized)
            {
                PythonEngine.Initialize();
            }

           /* string header = "def __mycode():\n";
            string footer = "async def __run():\n\t__mycode()\nawait __run()";

            string toRun = header;
            input = input.Replace("\r\n", "\n");
            foreach (var line in input.Split('\n'))
            {
                toRun += "\t" + line + "\n";
            }
            toRun += footer;
            */
            PythonEngine.Exec(input);





        }
            private void PythonSend(string input)
        {
            
                var t = new Thread(() => PythonSendDelegate(input));
                t.Start();
        }

        public void HotkeyCallback(Message m)
        {
            HotkeyBinding triggeredBinding =  Program.BindingManager.Get(m.WParam.ToInt32());


           /* uint pid;
            Win32Helper.GetWindowThreadProcessId(Win32Helper.GetForegroundWindow(), out pid);
            Process p = Process.GetProcessById((int)pid);
            string processName = p.ProcessName.ToLower();


            if (triggeredBinding.Blacklist)
            {
                foreach (var s in triggeredBinding.ProcessList)
                {
                    string sL = s.ToLower();
                    if (sL.EndsWith(".exe"))
                    {
                        sL = sL.Remove(sL.Length - 4, 4 );
                    }
                    if (sL == processName)
                    {

       
                        return;
                    }
                }

            } else {
                bool run = false;
                foreach (var s in triggeredBinding.ProcessList)
                {
                    if (s.ToLower() == processName)
                    {
                        run = true;
                        break;
                    }

                }
                if (!run)
                    return;
            }*/

            if (triggeredBinding.IsPython)
            {
          

                    if (triggeredBinding.CapsActionEnabled && Control.IsKeyLocked(Keys.Capital))
                        PythonSend(triggeredBinding.ActionAlternate);
                    else
                        PythonSend(triggeredBinding.Action);

                

            } else
            {
                if (triggeredBinding.CapsActionEnabled && Control.IsKeyLocked(Keys.Capital))
                    Win32.Send(triggeredBinding.ActionAlternate);
                else
                    Win32.Send(triggeredBinding.Action);
 
            }
            
            
           
        }
    }
}
