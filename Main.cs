
using Gma.System.MouseKeyHook;
using System.Text;
using CTI_RPA.SYS.Model;
using Point = System.Drawing.Point;

namespace CTI_RPA.SYS
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        /// <summary>
        ///  Represents the main form of the CTI_RPA application for recording macro actions.
        /// </summary>
        private IKeyboardMouseEvents _mGlobalHook;
        private List<MacroAction> _macroActions = new();
        readonly BindingSource _bindingSource = new();
        StringBuilder _currentWord = new();
        DateTime _lastKetPress = DateTime.MinValue;
        public MainForm()
        {
            _macroService = macroService;
            InitializeComponent();
            macroLog.DataSource = _bindingSource;
            _bindingSource.DataSource = _macroActions;
            _bindingSource.ResetBindings(false);
        }
        public void Subscribe(IKeyboardMouseEvents events)
        {
            if (macroLog.DataSource != null) return;
            PlayButton.Enabled = false;
            StopButton.Enabled = false;
        }
        private void RecordButton_Click(object sender, EventArgs e)
        {
            RecordButton.Enabled = false;
            this.WindowState = FormWindowState.Minimized;
            PopStartRecord popStartRecord = new PopStartRecord();
            popStartRecord.TopMost = true;
            popStartRecord.StartPosition = FormStartPosition.Manual;
            popStartRecord.Location = new Point(Screen.PrimaryScreen.Bounds.Width - popStartRecord.Width, Screen.PrimaryScreen.Bounds.Height - popStartRecord.Height);
            popStartRecord.ShowDialog(this);
            if (popStartRecord.DialogResult == DialogResult.OK)
            {
                PlayButton.Enabled = true;
                StopButton.Enabled = true;
                Subscribe();
            }
            else
            {
                RecordButton.Enabled = true;
            }
            popStartRecord.Dispose();
            this.WindowState = FormWindowState.Normal;

        }
        private void Subscribe()
        {
            _mGlobalHook = Hook.GlobalEvents();
            _mGlobalHook.KeyPress += GlobalHookKeyPress;
            _mGlobalHook.MouseDownExt += GlobalHookMouseDownExt;
        }
        private void GlobalHookKeyPress(object? sender, KeyPressEventArgs e)
        {

            var macroAction = new MacroAction()
            {
                MacroActionType = MacroActionType.KeyPress,
                EventName = $@"KeyPress",
                EventParameters = $"{e.KeyChar}",
                Value = $"{e.KeyChar}",
                Comment = ""
            };
            _macroActions.Add(macroAction);
            _bindingSource.ResetBindings(false);
        }

        private void Unsubscribe()
        {
            _mGlobalHook.KeyPress -= GlobalHookKeyPress;
            _mGlobalHook.MouseDownExt -= GlobalHookMouseDownExt;
            _mGlobalHook.Dispose();
        }

        private void GlobalHookMouseDownExt(object? sender, MouseEventExtArgs e)
        {
            var macroAction = new MacroAction()
            {
                MacroActionType = MacroActionType.MouseClick,
                EventName = $"{e.Button}",
                EventParameters = $"{e.X}, {e.Y}",
                Value = $"{e.Timestamp}",
                Comment = ""
            };
            _macroActions.Add(macroAction);
            _bindingSource.ResetBindings(false);
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            RecordButton.Enabled = true;
            Unsubscribe();
        }
        //TODO: Minimize or Hide the Main Form while recording or playback
        //TODO: Add Step for manual edit of script
        //TODO: Select Object for manual select of step
    }
}