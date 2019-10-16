namespace CleverBoard.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ButtonToggleStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonUAC = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TraybarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonToggleStatus,
            this.Separator1,
            this.ButtonUAC,
            this.ButtonSettings,
            this.Separator2,
            this.ButtonAbout,
            this.ButtonExit});
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // ButtonToggleStatus
            // 
            resources.ApplyResources(this.ButtonToggleStatus, "ButtonToggleStatus");
            this.ButtonToggleStatus.Name = "ButtonToggleStatus";
            this.ButtonToggleStatus.Click += new System.EventHandler(this.ToggleKeyboardListenState);
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            resources.ApplyResources(this.Separator1, "Separator1");
            // 
            // ButtonUAC
            // 
            this.ButtonUAC.Name = "ButtonUAC";
            resources.ApplyResources(this.ButtonUAC, "ButtonUAC");
            this.ButtonUAC.Click += new System.EventHandler(this.RequestUAC);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Name = "ButtonSettings";
            resources.ApplyResources(this.ButtonSettings, "ButtonSettings");
            this.ButtonSettings.Click += new System.EventHandler(this.OpenSettings);
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            resources.ApplyResources(this.Separator2, "Separator2");
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.Name = "ButtonAbout";
            resources.ApplyResources(this.ButtonAbout, "ButtonAbout");
            this.ButtonAbout.Click += new System.EventHandler(this.OpenAbout);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Name = "ButtonExit";
            resources.ApplyResources(this.ButtonExit, "ButtonExit");
            this.ButtonExit.Click += new System.EventHandler(this.ExitCleverBoard);
            // 
            // TraybarIcon
            // 
            this.TraybarIcon.ContextMenuStrip = this.mainMenu;
            resources.ApplyResources(this.TraybarIcon, "TraybarIcon");
            this.TraybarIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ToggleKeyboardListenState);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MainForm";
            this.mainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem ButtonToggleStatus;
        private System.Windows.Forms.ToolStripMenuItem ButtonExit;
        private System.Windows.Forms.ToolStripMenuItem ButtonUAC;
        private System.Windows.Forms.ToolStripMenuItem ButtonSettings;
        private System.Windows.Forms.ToolStripMenuItem ButtonAbout;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.NotifyIcon TraybarIcon;
    }
}