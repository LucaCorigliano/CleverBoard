using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CleverBoard.Helpers;

namespace CleverBoard.Forms

{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Program.HotkeyListener.SetHandle(Handle);

         
            mainMenu.Renderer = new Controls.MyToolStripRenderer();


            if (UACHelper.IsAdmin())
                ButtonUAC.Visible = false;


            if(Program.BindingManager.Bindings.Count == 0)
            {
                if(MessageBox.Show(Properties.strings.NoHotkeys, Properties.strings.ProgramName, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new BindingEditor().ShowDialog();
                }
            }

            StartHotkeys();
        }



        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(false);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != Win32.WM_HOTKEY)
                return;
            Program.HotkeyListener.HotkeyCallback(m);
        }

        private void ToggleKeyboardListenState(object sender, object e)
        {
            if (Program.HotkeyListener.IsListening)
                StopHotkeys();
            else
                StartHotkeys();
        }

        private void ExitCleverBoard(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RequestUAC(object sender, EventArgs e)
        {

           
            StopHotkeys();

            if(MessageBox.Show(Properties.strings.UACElevate, Properties.strings.ProgramName, MessageBoxButtons.OKCancel) == DialogResult.OK)
                if (UACHelper.Elevate(Application.ExecutablePath, "nocheck"))
                    return;
            
            StartHotkeys();
    
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            StopHotkeys();
            TraybarIcon.Visible = false;
            new BindingEditor().ShowDialog();
            StartHotkeys();
            TraybarIcon.Visible = true;
        }

        private void OpenAbout(object sender, EventArgs e)
        {
         
            StopHotkeys();
            TraybarIcon.Visible = false;
           new AboutDialog().ShowDialog();
            StartHotkeys();
            TraybarIcon.Visible = true;

            
        }



        private void StopHotkeys()
        {
   
            Program.HotkeyListener.StopListening();
            TraybarIcon.Text = string.Format("{0} - {1}", Properties.strings.ProgramName, Properties.strings.Paused);
            TraybarIcon.Icon = Properties.Resources.cleverboard_disabled;
        }

        private void StartHotkeys()
        {
            Program.HotkeyListener.StartListening();
            TraybarIcon.Text = string.Format("{0} - {1}", Properties.strings.ProgramName, Properties.strings.Running);
            TraybarIcon.Icon = Properties.Resources.cleverboard;
        }


    }
}
