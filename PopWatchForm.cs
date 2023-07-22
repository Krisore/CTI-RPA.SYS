using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTI_RPA.SYS
{
    public partial class PopWatchForm : Form
    {
        public PopWatchForm()
        {
            InitializeComponent();
        }

        private void directoryBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                directoryTextBox.Text = folder.SelectedPath;
            }
        }
    }
}
