using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CleverBoard.Hotkey;
namespace CleverBoard
{
    static class Program
    {
        public static HotkeyBindingManager BindingManager;
        public static HotkeyListener HotkeyListener;

        public static object Resources { get; internal set; }

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if ((args.Length == 0 || args[0] != "nocheck") && Process.GetProcessesByName("CleverBoard").Length > 1)
            {
                
                Environment.Exit(2);
            }

            var basePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            Directory.SetCurrentDirectory(basePath);

            BindingManager = new HotkeyBindingManager();

            BindingManager.Load();
            HotkeyListener = new HotkeyListener();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MainForm());
        }
    }
}
