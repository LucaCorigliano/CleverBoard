namespace CleverBoard
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
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.mainMenu.Size = new System.Drawing.Size(187, 126);
            // 
            // ButtonToggleStatus
            // 
            this.ButtonToggleStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonToggleStatus.Name = "ButtonToggleStatus";
            this.ButtonToggleStatus.Size = new System.Drawing.Size(186, 22);
            this.ButtonToggleStatus.Text = "Pause/Resume";
            this.ButtonToggleStatus.Click += new System.EventHandler(this.ToggleKeyboardListenState);
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(183, 6);
            // 
            // ButtonUAC
            // 
            this.ButtonUAC.Name = "ButtonUAC";
            this.ButtonUAC.Size = new System.Drawing.Size(186, 22);
            this.ButtonUAC.Text = "Request admin rights";
            this.ButtonUAC.Click += new System.EventHandler(this.RequestUAC);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(186, 22);
            this.ButtonSettings.Text = "Edit Rules...";
            this.ButtonSettings.Click += new System.EventHandler(this.OpenSettings);
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(183, 6);
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(186, 22);
            this.ButtonAbout.Text = "About";
            this.ButtonAbout.Click += new System.EventHandler(this.OpenAbout);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(186, 22);
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.Click += new System.EventHandler(this.ExitCleverBoard);
            // 
            // TraybarIcon
            // 
            this.TraybarIcon.ContextMenuStrip = this.mainMenu;
            this.TraybarIcon.Text = "CleverBoard - Running";
            this.TraybarIcon.Visible = true;
            this.TraybarIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ToggleKeyboardListenState);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.Text = "CleverBoard";
            this.Load += new System.EventHandler(this.MainForm_Load);
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