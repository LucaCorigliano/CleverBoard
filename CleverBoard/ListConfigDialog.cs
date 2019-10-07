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
    public partial class ListConfigDialog : Form
    {
        public ListConfigDialog()
        {
            InitializeComponent();
        }

        public BindingList<string> ProcessList;
        bool _blackList;
        public bool BlackList
        {
            get
            {
                return _blackList;
            }
            set
            {
                rdBlacklist.Checked = value;
                _blackList = value;
            }
        }


        private void OnLoad(object sender, EventArgs e)
        {
            listProcesses.DataSource = ProcessList;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(listProcesses.SelectedIndex >= 0)
            {
                ProcessList.RemoveAt(listProcesses.SelectedIndex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProcessList.Add(txtProcessName.Text);
        }
    }
}
