using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTI_RPA.MODEL;
using Point = System.Drawing.Point;
using Coordinante = CTI_RPA.MODEL.Point;
namespace CTI_RPA.SYS
{
    public partial class PopCreateScript : Form
    {

        public static List<string> functionResults = new List<string>();
        BindingSource bindingSource = new BindingSource();
        public PopCreateScript()
        {
            InitializeComponent();
        }

        private void scriptDirectoryBtn_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            var result = folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                scriptDirectory.Text = folder.SelectedPath;
            }
        }
        private void addFunctionBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Add Function", "Start Recording?", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                PopStartModelWindow();
            }
        }

        private void PopStartModelWindow()
        {
            PopStartModal popStartModal = new PopStartModal();
            popStartModal.ShowDialog();
        }

        private void recordBtn_Click(object sender, EventArgs e)
        {

        }

        internal void ReceivedData(string step)
        {
            functionResults.Add(step);
        }
        private void PopCreateScript_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = functionResults;
            listBox1.DataSource = bindingSource;
        }

        private void PopCreateScript_Activated(object sender, EventArgs e)
        {
            bindingSource.ResetBindings(true);
        }
    }
}
