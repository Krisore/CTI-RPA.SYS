namespace CTI_RPA.SYS
{
    public partial class LoaderIntro : Form
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
                Invoke(CloseLoadingScreen);
                return;
            }
            Close();
        }
        private void LoadingTimer_Tick_1(object sender, EventArgs e)
        {
            filled.Width += 3;
            if (filled.Width >= 466)
            {
                CloseLoadingScreen();
            }
        }
    }
}
