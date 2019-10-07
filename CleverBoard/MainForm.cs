using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverBoard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Program.HotkeyListener.SetHandle(Handle);
            StartHotkeys();
        }



        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(false);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != Helpers.Win32Helper.WM_HOTKEY)
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

            MessageBox.Show("Unimplemented");
          /*  StopHotkeys();
            if (MiscHelper.Elevate(Application.ExecutablePath, "nocheck"))
                return;
            int num = (int)MessageBox.Show(Program.Locale.Get("Please choose Yes when prompted for user elevation."), Program.Locale.Get("CleverBoard"), MessageBoxButtons.OK);
            StartHotkeys();

    */
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
            MessageBox.Show("Unimplemented");
            /*
            StopHotkeys();
            TraybarIcon.Visible = false;
            int num = (int)new FormAbout().ShowDialog();
            StartHotkeys();
            TraybarIcon.Visible = true;

            */
        }

        private void ToggleAutorun(object sender, EventArgs e)
        {
            MessageBox.Show("Unimplemented");
            /*
            bool flag = InstallManager.IsInstalled();
            if (InstallManager.IsInstalled())
                InstallManager.Uninstall();
            else
                InstallManager.Install();
            ((ToolStripMenuItem)sender).Checked = !flag;
            */
        }

        private void StopHotkeys()
        {
   
            Program.HotkeyListener.StopListening();
            TraybarIcon.Text = ("CleverBoard - Paused");
            TraybarIcon.Icon = Properties.Resources.cleverboard_disabled;
        }

        private void StartHotkeys()
        {
            Program.HotkeyListener.StartListening();
            TraybarIcon.Text = ("CleverBoard - Running");
            TraybarIcon.Icon = Properties.Resources.cleverboard;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
