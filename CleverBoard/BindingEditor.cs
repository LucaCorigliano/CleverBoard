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
    public partial class BindingEditor : Form
    {
        // Detecting if the app is saving, so that we don't have overlapping events
        bool isSaving = false;
        // Detecting if the app is deleting, so that we don't have overlapping events
        bool isDeleting = false;
        // Detecting first load in order to not save when not intended
        bool isFirstLoading = false;

        BindingSource bs = new BindingSource();
        public BindingEditor()
        {
         
            InitializeComponent();
      
        }

        private void LoadBinding(Binding binding)
        {
            txtName.Text = binding.Name;
            txtInput.Text = binding.Action;
            txtAltInput.Text = binding.ActionAlternate;
            txtHotkey.Text = binding.Hotkey.ToString();
            chkAltCaps.Checked = binding.CapsActionEnabled;
            txtAltInput.Enabled = chkAltCaps.Checked;
            chkDisable.Checked = !binding.Enabled;
            chkPython.Checked = binding.IsPython;
            UpdateTextBoxes();
        }

        private void DeleteBinding()
        {
            isDeleting = true;
            Program.BindingManager.Remove((Binding)listBindings.SelectedItem);
            isDeleting = false;
            if (Program.BindingManager.Bindings.Count == 0)
            {

                NewBinding();
            }
            if (listBindings.SelectedItem != null)
            {
                LoadBinding((Binding)listBindings.SelectedItem);
            }
            
          

        }
        private void SaveBinding()
        {
            if (isFirstLoading)
                return;
            isSaving = true;

            bs.ResetBindings(false);
            Program.BindingManager.Save();

            isSaving = false;
        }

        private void NewBinding()
        {
            Binding binding = new Binding();

            listBindings.SelectedIndex = Program.BindingManager.Add(binding);
            
        }
        


        // Workaround needed because in my testing CTRL+E and other stuff refused to be registered
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
      
            
            if (
                (msg.Msg == Helpers.Win32Helper.WM_KEYDOWN || msg.Msg == Helpers.Win32Helper.WM_SYSKEYDOWN)
                    && txtHotkey.Focused)
            {

                ((Binding)listBindings.SelectedItem).Hotkey.Ctrl = keyData.HasFlag(Keys.Control);
                ((Binding)listBindings.SelectedItem).Hotkey.Alt = keyData.HasFlag(Keys.Alt);
                ((Binding)listBindings.SelectedItem).Hotkey.Shift = keyData.HasFlag(Keys.Shift);

                Keys keyCode = keyData & Keys.KeyCode;
  

                switch (keyCode)
                {
                    case Keys.Alt:
                    case Keys.Control:
                    case Keys.ControlKey:
                    case Keys.Shift:
                    case Keys.ShiftKey:
                    case Keys.Menu:
                    case Keys.LMenu:
                    case Keys.RMenu:

                        ((Binding)listBindings.SelectedItem).Hotkey.Key = Keys.None;
                        break;

                    default:

                        ((Binding)listBindings.SelectedItem).Hotkey.Key = keyCode;
                        break;
                }
                txtHotkey.Text = ((Binding)listBindings.SelectedItem).Hotkey.ToString();
                bs.ResetBindings(false);

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void listBindings_ItemChanged(object sender, EventArgs e)
        {
            if (isSaving || isDeleting)
                return;
            
            SaveBinding();
            if (listBindings.SelectedItem != null)
            {
                LoadBinding((Binding)listBindings.SelectedItem);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
            ((Binding)listBindings.SelectedItem).Name = txtName.Text.Replace("|", " ");
            bs.ResetBindings(false);
        }

        private void txtAltInput_TextChanged(object sender, EventArgs e)
        {
            ((Binding)listBindings.SelectedItem).ActionAlternate = txtAltInput.Text;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            ((Binding)listBindings.SelectedItem).Action = txtInput.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewBinding();
            

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBinding();
        }

        private void BindingEditor_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.cleverboard;
            isFirstLoading = true;
            // Clear prop items
            listBindings.Items.Clear();
            bs.DataSource = Program.BindingManager.Bindings;
            listBindings.DataSource = bs;

            isFirstLoading = false;

            if (Program.BindingManager.Bindings.Count == 0)
            {

                NewBinding();
            }
        }

        private void chkAltCaps_CheckedChanged(object sender, EventArgs e)
        {
         
               txtAltInput.Enabled = chkAltCaps.Checked;
                ((Binding)listBindings.SelectedItem).CapsActionEnabled = chkAltCaps.Checked;

        }

        private void listBindings_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            Binding item = (Binding)listBindings.Items[e.Index];
            
           


            Font f = new Font( listBindings.Font, FontStyle.Bold);
            Brush b = new SolidBrush(e.ForeColor);

            e.Graphics.DrawString(item.Hotkey.ToString(), f, b, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void checkDisable_CheckedChanged(object sender, EventArgs e)
        {
            ((Binding)listBindings.SelectedItem).Enabled = !chkDisable.Checked;
            bs.ResetBindings(false);
        }

        private void UpdateTextBoxes()
        {

            if(chkPython.Checked)
            {
                txtAltInput.Font = new Font("Lucida Console", Font.Size);
                txtInput.Font = new Font("Lucida Console", Font.Size);
            } else
            {
                txtAltInput.Font = Font;
                txtInput.Font = Font;
            }
        }

        private void chkPython_CheckedChanged(object sender, EventArgs e)
        {
            ((Binding)listBindings.SelectedItem).IsPython = chkPython.Checked;
            UpdateTextBoxes();
            bs.ResetBindings(false);
        }

        private void BindingEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveBinding();
        }

        private void BindingEditor_Resize(object sender, EventArgs e)
        {

   
   //         txtInput.Size = new Size(txtInput.Width, txtInput.Height + (chkAltCaps.Top - txtInput.Bottom));
        //    txtAltInput.Size = new Size(txtAltInput.Width, txtAltInput.Height + (lblName.Top - txtAltInput.Bottom));
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CleverBoard XML Bindings (*.xml)|*.xml";
            sfd.DefaultExt = "xml";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Program.BindingManager.Save(sfd.FileName);
                } catch(Exception ex)
                {
                    MessageBox.Show(string.Format("Failed to export, please try again.\n\nException Details:\n{0}", ex.Message), Properties.Resources.ProgramName);
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CleverBoard XML Bindings (*.xml)|*.xml";
            ofd.DefaultExt = "xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Program.BindingManager.Load(ofd.FileName, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Failed to import, please try again.\n\nException Details:\n{0}", ex.Message), Properties.Resources.ProgramName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ListConfigDialog lcf = new ListConfigDialog();
            lcf.ProcessList = ((Binding)listBindings.SelectedItem).ProcessList;
            lcf.BlackList = ((Binding)listBindings.SelectedItem).Blacklist;

            lcf.ShowDialog();
            ((Binding)listBindings.SelectedItem).ProcessList = lcf.ProcessList ;
            ((Binding)listBindings.SelectedItem).Blacklist = lcf.BlackList ;

        }
    }

 

}
