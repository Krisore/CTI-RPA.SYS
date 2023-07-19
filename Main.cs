using System.Linq;
using System.Runtime.InteropServices;
using Gma.System.MouseKeyHook;
using System.Diagnostics;
namespace CTI_RPA.SYS
{
    public partial class Main : Form
    {
       
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetCursorPos(int x, int y);
        private IKeyboardMouseEvents _keyboardEvents;
        private readonly List<Point> cursorPositions = new List<Point>();
        public Main()
        {
            InitializeComponent();
        }
        public void Subscribe(IKeyboardMouseEvents events)
        {
            _keyboardEvents = events;
            _keyboardEvents.MouseMove += Mouse_Events_MouseMove;
            _keyboardEvents.MouseDown += Mouse_Events_MouseDown;
            
        }

        private void Mouse_Events_MouseDown(object? sender, MouseEventArgs e)
        {
            Point cursorPosition = Cursor.Position;
            cursorPositions.Add(cursorPosition);
            label2.Text = $"x = {cursorPosition.X:0000}, y = {cursorPosition.Y:0000}";
        }

        private void Mouse_Events_MouseMove(object? sender, MouseEventArgs e)
        {
            label1.Text = $"x = {e.X:0000}, y = {e.Y:0000}";
        }

        public void UnSubscribe()
        {
            if (_keyboardEvents == null) return;
            _keyboardEvents.MouseMove -= Mouse_Events_MouseMove;
            _keyboardEvents.Dispose();
            _keyboardEvents = null;
        }

        private void addObject_Click(object sender, EventArgs e)
        {
            SetCursorPos(0, 0);
            label1.Text = $"x = {MousePosition.X:0000}, y = {MousePosition.Y:0000}";
            label2.Text = $"x = {MousePosition.X:0000}, y = {MousePosition.Y:0000}";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UnSubscribe();
            Subscribe(Hook.GlobalEvents());
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnSubscribe();
        }
    }
}