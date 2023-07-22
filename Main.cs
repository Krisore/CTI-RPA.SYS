
using System.Runtime.InteropServices;
using Gma.System.MouseKeyHook;
using System.Linq;
using System.Text;
using CTI_RPA.MODEL;
using Point = System.Drawing.Point;

namespace CTI_RPA.SYS
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private IKeyboardMouseEvents _mGlobalHook;
        private List<MacroAction> _macroActions = new List<MacroAction>();
        readonly BindingSource _bindingSource = new BindingSource();
        StringBuilder _currentWord = new StringBuilder();
        DateTime lastKetPress = DateTime.MinValue;
        public MainForm()
        {
            InitializeComponent();
            macroLog.DataSource = _bindingSource;
            _bindingSource.DataSource = _macroActions;
        }
        private void MainForm_Load_1(object sender, EventArgs e)
        {
            if (macroLog.DataSource != null) return;
            PlayButton.Enabled = false;
            stopButton.Enabled = false;
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
                stopButton.Enabled = true;
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
            //_mGlobalHook.KeyDown += GlobalHookKeyDown;
        }

        //private void GlobalHookKeyDown(object? sender, KeyEventArgs e)
        //{
        //    var macroAction = new MacroAction()
        //    {
        //        OnType = EventType.Keyboard,
        //        EventName = $"KeyPress",
        //        EventParameters = $"{e.KeyData}",
        //        Value = $"{e.KeyCode}",
        //        Comment = ""
        //    };
        //    _macroActions.Add(macroAction);
        //    bindingSource.ResetBindings(false);
        //}

        private void GlobalHookKeyPress(object? sender, KeyPressEventArgs e)
        {

            var macroAction = new MacroAction()
                {
                    OnType = EventType.Keyboard,
                    EventName = $"KeyPress",
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
                OnType = EventType.MouseClick,
                EventName = $"{e.Button}",
                EventParameters = $"{e.X}, {e.Y}",
                Value = $"{e.Timestamp:##.###}",
                Comment = ""
            };
            _macroActions.Add(macroAction);
            _bindingSource.ResetBindings(false);
        }


        private void stopButton_Click(object sender, EventArgs e)
        {
            Unsubscribe();
        }
    }
}