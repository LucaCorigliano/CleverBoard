namespace CleverBoard.Forms
{
    partial class ListConfigDialog
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
            this.listProcesses = new System.Windows.Forms.ListBox();
            this.lblProcesses = new System.Windows.Forms.Label();
            this.rdBlacklist = new System.Windows.Forms.RadioButton();
            this.rdWhitelist = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listProcesses
            // 
            this.listProcesses.FormattingEnabled = true;
            this.listProcesses.ItemHeight = 17;
            this.listProcesses.Location = new System.Drawing.Point(12, 29);
            this.listProcesses.Name = "listProcesses";
            this.listProcesses.Size = new System.Drawing.Size(299, 242);
            this.listProcesses.TabIndex = 0;
            // 
            // lblProcesses
            // 
            this.lblProcesses.AutoSize = true;
            this.lblProcesses.Location = new System.Drawing.Point(12, 9);
            this.lblProcesses.Name = "lblProcesses";
            this.lblProcesses.Size = new System.Drawing.Size(69, 17);
            this.lblProcesses.TabIndex = 2;
            this.lblProcesses.Text = "Processes:";
            // 
            // rdBlacklist
            // 
            this.rdBlacklist.AutoSize = true;
            this.rdBlacklist.Checked = true;
            this.rdBlacklist.Location = new System.Drawing.Point(98, 277);
            this.rdBlacklist.Name = "rdBlacklist";
            this.rdBlacklist.Size = new System.Drawing.Size(71, 21);
            this.rdBlacklist.TabIndex = 3;
            this.rdBlacklist.TabStop = true;
            this.rdBlacklist.Text = "Blacklist";
            this.rdBlacklist.UseVisualStyleBackColor = true;
            // 
            // rdWhitelist
            // 
            this.rdWhitelist.AutoSize = true;
            this.rdWhitelist.Location = new System.Drawing.Point(12, 277);
            this.rdWhitelist.Name = "rdWhitelist";
            this.rdWhitelist.Size = new System.Drawing.Size(75, 21);
            this.rdWhitelist.TabIndex = 4;
            this.rdWhitelist.Text = "Whitelist";
            this.rdWhitelist.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(220, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 31);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(126, 335);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 31);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(12, 304);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(299, 25);
            this.txtProcessName.TabIndex = 7;
            // 
            // ListConfigDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 377);
            this.Controls.Add(this.txtProcessName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rdWhitelist);
            this.Controls.Add(this.rdBlacklist);
            this.Controls.Add(this.lblProcesses);
            this.Controls.Add(this.listProcesses);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListConfigDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Blacklist / Whitelist";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listProcesses;
        private System.Windows.Forms.Label lblProcesses;
        private System.Windows.Forms.RadioButton rdBlacklist;
        private System.Windows.Forms.RadioButton rdWhitelist;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtProcessName;
    }
}