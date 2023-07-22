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
    public partial class LoaderIntro : System.Windows.Forms.Form
    {
        public LoaderIntro()
        {
            InitializeComponent();
        }
        private void LoaderIntro_Load(object sender, EventArgs e)
        {
            LoadingTimer.Start();
        }
        private void CloseLoadingScreen()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(CloseLoadingScreen));
                return;
            }
            Close();
        }
        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            filled.Width += 3;
            if (filled.Width >= 466)
            {
                CloseLoadingScreen();
            }
        }
    }
}
