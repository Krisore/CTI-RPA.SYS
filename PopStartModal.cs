using CTI_RPA.MODEL;
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
using Point = System.Drawing.Point;
using CursorCoordinate = CTI_RPA.MODEL.Point;
namespace CTI_RPA.SYS
{
    public partial class PopStartModal : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetCursorPos(int x, int y);
        private IKeyboardMouseEvents _keyboardEvents;
        private Point _cursorCoordinate = new();
        public PopStartModal()
        {
            InitializeComponent();
        }
        private void addFunctionBtn_Click(object sender, EventArgs e)
        {
            //Display Dialog to run background work
            var result = MessageBox.Show(text: @"Start Recording?", @"Add Function?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                UnSubscribe();
                Subscribe(Hook.GlobalEvents());
            }
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
            _cursorCoordinate = cursorPosition;
            if (e.Clicks != 1 && e.Clicks == 2)
            {
                functionName.Text = "AddDoubleClick()";
                UnSubscribe();
            }
            if (e.Clicks == 1)
            {
                functionName.Text = "OnClick";
                UnSubscribe();
            }
        }

        private void Mouse_Events_MouseMove(object? sender, MouseEventArgs e)
        {
            cursorPoint.Text = $"(x:{e.X}, y:{e.Y})";
        }
        public void UnSubscribe()
        {
            if (_keyboardEvents == null) return;
            _keyboardEvents.MouseMove -= Mouse_Events_MouseMove;
            _keyboardEvents.Dispose();
            _keyboardEvents = null!;
        }

        private void addObject_Click(object sender, EventArgs e)
        {
            SetCursorPos(0, 0);
        }

        private void PopStartModal_Load(object sender, EventArgs e)
        {
            UnSubscribe();
            Subscribe(Hook.GlobalEvents());
        }

        private void PopStartModal_Closing(object sender, FormClosingEventArgs e)
        {
            UnSubscribe();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            var popCreateScript = new PopCreateScript();
            FunctionResult function = new FunctionResult()
            {
                Id = 0,
                FunctionName = functionName.Text,
                Location = new CursorCoordinate(_cursorCoordinate.X, _cursorCoordinate.Y),
                Description = descriptionField.Text
            };
            popCreateScript.ReceivedData(functionName.Text);
            var result = MessageBox.Show("Function Saved!", "Script is Successfully saved!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
    }
}
