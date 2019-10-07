using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverBoard
{
    static class Program
    {
        public static BindingManager BindingManager;
        public static HotkeyListener HotkeyListener;
       
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BindingManager = new BindingManager();
            BindingManager.Load();
            HotkeyListener = new HotkeyListener();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
