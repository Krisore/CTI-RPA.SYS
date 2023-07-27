using CTI_RPA.SYS.Model;
using Gma.System.MouseKeyHook;
using CTI_RPA.SYS.Services.Interface;
using WindowsInput;

namespace CTI_RPA.SYS.Services
{
    /// <summary> 
    /// This is Macro Service Class.
    /// </summary>
    public class MacroService : IMacroService
    {
        private IKeyboardMouseEvents _mGlobalHook;
        public  List<MacroAction> MacroActions { get; set; } = new ();
        public BindingSource MacroActionsBindingSource { get; } = new ();
        public MacroService(IKeyboardMouseEvents mGlobalHook)
        {
            _mGlobalHook = mGlobalHook;
            MacroActionsBindingSource.DataSource = MacroActions;
        }
        public void Subscribe()
        {
            _mGlobalHook = Hook.GlobalEvents();
            //_mGlobalHook.KeyDown += GlobalHookKeyDown;
            _mGlobalHook.KeyPress += GlobalHookKeyPress;
            _mGlobalHook.MouseDownExt += GlobalHookMouseDownExt;
        }
        //Note: KeyDown event for global hook.
        #region GlobalHookKeyDown

        //private void GlobalHookKeyDown(object? sender, KeyEventArgs e)
        //{
        //    var macroAction = new MacroAction
        //    {
        //        MacroActionType = MacroActionType.KeyPress,
        //        EventName = $"Key Down: '{e.KeyCode}'",
        //        EventParameters = $"{e.KeyCode}",
        //        Value = $"{e.KeyData}",
        //        Comment = ""
        //    };
        //    MacroActions.Add(macroAction);
        //    MacroActionsBindingSource.ResetBindings(false);
        //}

        #endregion
        public void GlobalHookKeyPress(object? sender, KeyPressEventArgs e)
        {
            var macroAction = new MacroAction()
            {
                MacroActionType = MacroActionType.KeyPress,
                EventName = $"Key Press: '{e.KeyChar}'",
                EventParameters = $"{e.KeyChar}",
                Value = $"{e.KeyChar}",
                Comment = ""
            };
            MacroActions.Add(macroAction);
            MacroActionsBindingSource.ResetBindings(false);
        }
        public void Unsubscribe()
        {
            //_mGlobalHook.KeyDown += GlobalHookKeyDown; On Global key including special keys.
            _mGlobalHook.KeyPress -= GlobalHookKeyPress;
            _mGlobalHook.MouseDownExt -= GlobalHookMouseDownExt;
            _mGlobalHook.Dispose();
        }
        public void GlobalHookMouseDownExt(object? sender, MouseEventExtArgs e)
        {
            var macroAction = new MacroAction()
            {
                MacroActionType = MacroActionType.MouseClick,
                EventName = $"{e.Button}",
                EventParameters = $"{e.X}, {e.Y}",
                Value = $"{e.Clicks}",
                Comment = ""
            };
            MacroActions.Add(macroAction);
            MacroActionsBindingSource.ResetBindings(false);
        }
        public bool IsMacroActionsNull() => MacroActions.Count == 0;
        public void ClearMacroActions()
        {
            MacroActionsBindingSource.Clear();
        }
        public void PlayMacroActions()
        {
            var inputSimulator = new InputSimulator();
            foreach (var action in MacroActions)
            {
                switch (action.MacroActionType)
                {
                    case MacroActionType.KeyPress when action.Value.Length == 1:
                        inputSimulator.Keyboard.TextEntry(action.Value);
                        break;
                    case MacroActionType.KeyPress:
                    {
                        var keys = action.Value.Split(',').Select(key => key.Trim().ToLower()).ToArray();
                        if (Enum.TryParse(keys.Last().ToUpper(), out VirtualKeyCode mainKeyCode))
                        {
                            var modifierKeyCodes = keys.Take(keys.Length - 1)
                                .Select(GetModifierKeyCode)
                                .ToArray();
                            // Press modifier keys first
                            foreach (var modifierKeyCode in modifierKeyCodes)
                            {
                                inputSimulator.Keyboard.KeyDown(modifierKeyCode);
                            }
                            // Press main key
                            inputSimulator.Keyboard.KeyPress(mainKeyCode);
                            // Release modifier keys
                            foreach (var modifierKeyCode in modifierKeyCodes.Reverse())
                            {
                                inputSimulator.Keyboard.KeyUp(modifierKeyCode);
                            }
                        }
                        break;
                    }
                    case MacroActionType.MouseClick:
                    {
                        int x = 0, y = 0;
                        var parameters = action.EventParameters.Split(',');
                        if (parameters.Length == 2)
                        {
                            _ = int.TryParse(parameters[0], out x);
                            _ = int.TryParse(parameters[1], out y);
                        }
                        Cursor.Position = new Point(x, y);
                        inputSimulator.Mouse.LeftButtonDown();
                        inputSimulator.Mouse.LeftButtonUp();
                        break;
                    }
                    case MacroActionType.MouseMove:
                        break;
                    case MacroActionType.MouseWheel:
                        break;
                    case MacroActionType.Interval:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Thread.Sleep(300);
            }
        }
        private static VirtualKeyCode GetModifierKeyCode(string modifier)
        {
            return modifier switch
            {
                "shift" => VirtualKeyCode.SHIFT,
                "ctrl" => VirtualKeyCode.CONTROL,
                "alt" => VirtualKeyCode.MENU,
                _ => VirtualKeyCode.None,
            };
        }
    }
}
