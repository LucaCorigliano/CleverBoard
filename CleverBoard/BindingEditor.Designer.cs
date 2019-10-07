namespace CleverBoard
{
    partial class BindingEditor
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHotkey = new System.Windows.Forms.TextBox();
            this.listBindings = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.chkAltCaps = new System.Windows.Forms.CheckBox();
            this.txtAltInput = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.chkDisable = new System.Windows.Forms.CheckBox();
            this.chkPython = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHotkey
            // 
            this.txtHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotkey.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotkey.Location = new System.Drawing.Point(7, 30);
            this.txtHotkey.Margin = new System.Windows.Forms.Padding(4);
            this.txtHotkey.Name = "txtHotkey";
            this.txtHotkey.ReadOnly = true;
            this.txtHotkey.Size = new System.Drawing.Size(422, 28);
            this.txtHotkey.TabIndex = 0;
            // 
            // listBindings
            // 
            this.listBindings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBindings.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBindings.FormattingEnabled = true;
            this.listBindings.ItemHeight = 21;
            this.listBindings.Items.AddRange(new object[] {
            "Test - CTRL+ALT+F5",
            "Test2 - F3",
            "Test3 - SHIFT+A"});
            this.listBindings.Location = new System.Drawing.Point(0, 0);
            this.listBindings.Margin = new System.Windows.Forms.Padding(4);
            this.listBindings.Name = "listBindings";
            this.listBindings.Size = new System.Drawing.Size(254, 445);
            this.listBindings.TabIndex = 10;
            this.listBindings.SelectedIndexChanged += new System.EventHandler(this.listBindings_ItemChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Choose the Hotkey:";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 340);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(174, 17);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Give a name to your Hotkey!";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(7, 361);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(422, 27);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "What should CleverBoard input for you?";
            // 
            // txtInput
            // 
            this.txtInput.AcceptsTab = true;
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(1, 23);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(400, 112);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // chkAltCaps
            // 
            this.chkAltCaps.AutoSize = true;
            this.chkAltCaps.Location = new System.Drawing.Point(3, 0);
            this.chkAltCaps.Margin = new System.Windows.Forms.Padding(4);
            this.chkAltCaps.Name = "chkAltCaps";
            this.chkAltCaps.Size = new System.Drawing.Size(248, 21);
            this.chkAltCaps.TabIndex = 3;
            this.chkAltCaps.Text = "Alternate input when CAPS LOCK is on";
            this.chkAltCaps.UseVisualStyleBackColor = true;
            this.chkAltCaps.CheckedChanged += new System.EventHandler(this.chkAltCaps_CheckedChanged);
            // 
            // txtAltInput
            // 
            this.txtAltInput.AcceptsTab = true;
            this.txtAltInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAltInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAltInput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltInput.Location = new System.Drawing.Point(1, 21);
            this.txtAltInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtAltInput.Name = "txtAltInput";
            this.txtAltInput.Size = new System.Drawing.Size(439, 109);
            this.txtAltInput.TabIndex = 4;
            this.txtAltInput.Text = "";
            this.txtAltInput.TextChanged += new System.EventHandler(this.txtAltInput_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(299, 396);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(200, 396);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(91, 30);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New Hotkey";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // chkDisable
            // 
            this.chkDisable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkDisable.AutoSize = true;
            this.chkDisable.Location = new System.Drawing.Point(10, 466);
            this.chkDisable.Margin = new System.Windows.Forms.Padding(4);
            this.chkDisable.Name = "chkDisable";
            this.chkDisable.Size = new System.Drawing.Size(138, 21);
            this.chkDisable.TabIndex = 9;
            this.chkDisable.Text = "Disable this Hotkey";
            this.chkDisable.UseVisualStyleBackColor = true;
            this.chkDisable.CheckedChanged += new System.EventHandler(this.checkDisable_CheckedChanged);
            // 
            // chkPython
            // 
            this.chkPython.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkPython.AutoSize = true;
            this.chkPython.Location = new System.Drawing.Point(10, 437);
            this.chkPython.Margin = new System.Windows.Forms.Padding(4);
            this.chkPython.Name = "chkPython";
            this.chkPython.Size = new System.Drawing.Size(224, 21);
            this.chkPython.TabIndex = 8;
            this.chkPython.Text = "Python Scripting (advanced users)";
            this.chkPython.UseVisualStyleBackColor = true;
            this.chkPython.CheckedChanged += new System.EventHandler(this.chkPython_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnExport);
            this.splitContainer1.Panel1.Controls.Add(this.btnImport);
            this.splitContainer1.Panel1.Controls.Add(this.listBindings);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnAdvance);
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.chkPython);
            this.splitContainer1.Panel2.Controls.Add(this.txtHotkey);
            this.splitContainer1.Panel2.Controls.Add(this.chkDisable);
            this.splitContainer1.Panel2.Controls.Add(this.txtName);
            this.splitContainer1.Panel2.Controls.Add(this.btnNew);
            this.splitContainer1.Panel2.Controls.Add(this.lblName);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Size = new System.Drawing.Size(700, 500);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 15;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(0, 470);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 30);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Export...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(135, 470);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(120, 30);
            this.btnImport.TabIndex = 16;
            this.btnImport.Text = "Import...";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnAdvance
            // 
            this.btnAdvance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdvance.Location = new System.Drawing.Point(299, 466);
            this.btnAdvance.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(130, 30);
            this.btnAdvance.TabIndex = 16;
            this.btnAdvance.Text = "Blacklist / Whitelist";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Visible = false;
            this.btnAdvance.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Location = new System.Drawing.Point(7, 65);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer2.Panel1.Controls.Add(this.txtInput);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer2.Panel2.Controls.Add(this.chkAltCaps);
            this.splitContainer2.Panel2.Controls.Add(this.txtAltInput);
            this.splitContainer2.Size = new System.Drawing.Size(422, 272);
            this.splitContainer2.SplitterDistance = 135;
            this.splitContainer2.TabIndex = 15;
            // 
            // BindingEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "BindingEditor";
            this.Text = "CleverBoard - Hotkey Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BindingEditor_FormClosing);
            this.Load += new System.EventHandler(this.BindingEditor_Load);
            this.Resize += new System.EventHandler(this.BindingEditor_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHotkey;
        private System.Windows.Forms.ListBox listBindings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.CheckBox chkAltCaps;
        private System.Windows.Forms.RichTextBox txtAltInput;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.CheckBox chkDisable;
        private System.Windows.Forms.CheckBox chkPython;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAdvance;
    }
}

