using System.Diagnostics;
using CTI_RPA.SYS.Model;
using Gma.System.MouseKeyHook;
using CTI_RPA.SYS.Services.Interface;
using WindowsInput;
using System.Text;
using Timer = System.Windows.Forms.Timer;
using System.Text.RegularExpressions;

namespace CTI_RPA.SYS.Services;

/// <summary> 
/// This is Macro Service Class.
/// </summary>
public class MacroService : IMacroService
{
    private IKeyboardMouseEvents? _mGlobalHook;
    const int InterpolationSteps = 10;
    public List<MacroAction> MacroActions { get; set; } = new();
    public BindingSource MacroActionsBindingSource { get; } = new();
    public StringBuilder CurrentWord = new();
    private readonly Timer _textInputTimer;
    private const int TextInputTimeoutMilliseconds = 2000;
    private readonly Stopwatch _stopwatch = new ();
    private DateTime _previousActionTimestamp = DateTime.Now;
    public MacroService()
    {
        MacroActionsBindingSource.DataSource = MacroActions;
        _textInputTimer = new Timer();
        _textInputTimer.Interval = TextInputTimeoutMilliseconds;
        _textInputTimer.Tick += TextInputTimer_Tick;
    }
    #region KeypressTextInputTick
    private void TextInputTimer_Tick(object? sender, EventArgs e)
    {
        var macroAction = new MacroAction()
        {
            MacroActionType = MacroActionType.KeyPress,
            EventName = "Text Input",
            EventParameters = CurrentWord.ToString(),
            Value = CurrentWord.ToString(),
            Comment = ""
        };
        MacroActions.Add(macroAction);
        CurrentWord.Clear();
        _textInputTimer.Stop();
    }
    #endregion
    public void Subscribe()
    {
        _mGlobalHook = Hook.GlobalEvents();
        _mGlobalHook.KeyPress += GlobalHookKeyPress;
        _mGlobalHook.MouseDownExt += GlobalHookMouseDownExt;
        _mGlobalHook.MouseWheelExt += GlobalHookMouseWheelExt;
        //_mGlobalHook.MouseMoveExt += GlobalHookMouseMoveExt;
    }
    #region GlobalHookMouseMove

    //private void GlobalHookMouseMoveExt(object? sender, MouseEventExtArgs e)
    //{
    //    var macroAction = new MacroAction()
    //    {
    //        MacroActionType = MacroActionType.MouseMove,
    //        EventName = $"{e.Location}",
    //        EventParameters = $"{e.X},{e.Y}",
    //        Value = $"{e.Clicks}",
    //        Comment = ""
    //    };
    //    MacroActions.Add(macroAction);
    //    MacroActionsBindingSource.ResetBindings(false);
    //}

    #endregion
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
    private void GlobalHookMouseWheelExt(object? sender, MouseEventExtArgs e)
    {
        var macroAction = new MacroAction()
        {
            MacroActionType = MacroActionType.MouseWheel,
            EventName = $"Mouse Wheel: '{e.Delta}'",
            EventParameters = $"{e.Delta}",
            Value = $"Mouse wheel move at {e.Delta}",
            Comment = ""
        };
        MacroActions.Add(macroAction);
        MacroActionsBindingSource.ResetBindings(false);
    }
    public void GlobalHookKeyPress(object? sender, KeyPressEventArgs e)
    {
        // Use a regular expression pattern to check for letters and digits
        var regexPattern = @"^[a-zA-Z0-9@!$#&^%*():;.?>< =]$";
        var inputChar = e.KeyChar.ToString();

        // Check if the input character matches the regex pattern
        if (Regex.IsMatch(inputChar, regexPattern) && !string.IsNullOrEmpty(e.KeyChar.ToString()))
        {
            // If it's a letter or digit, add it to the current word
            CurrentWord.Append(e.KeyChar);

            // Reset the text input timer
            _textInputTimer.Stop();
            _textInputTimer.Start();
        }
        else if (!string.IsNullOrEmpty(e.KeyChar.ToString()))
        {
            // If it's not a letter, but we have a current word, then create a MacroAction for the text input
            if (CurrentWord.Length > 0)
            {
                var macroAction = new MacroAction()
                {
                    MacroActionType = MacroActionType.KeyPress,
                    EventName = "Text Input",
                    EventParameters = "",
                    Value = CurrentWord.ToString(),
                    Comment = ""
                };
                MacroActions.Add(macroAction);
                MacroActionsBindingSource.ResetBindings(false);
                // Reset the currentWord for the next input sequence
                CurrentWord.Clear();
            }
            switch (e.KeyChar)
            {
                // Check for special keys (Tab, Enter, etc.) and create corresponding MacroActions
                case (char)Keys.Tab:
                {
                    var macroAction = new MacroAction()
                    {
                        MacroActionType = MacroActionType.KeyPress,
                        EventName = "Special Key",
                        EventParameters = "",
                        Value = "Tab",
                        Comment = ""
                    };
                    MacroActions.Add(macroAction);
                    MacroActionsBindingSource.ResetBindings(false);
                    break;
                }
                case (char)Keys.Enter:
                {
                    var macroAction = new MacroAction()
                    {
                        MacroActionType = MacroActionType.KeyPress,
                        EventName = "Special Key",
                        EventParameters = "",
                        Value = "Enter",
                        Comment = ""
                    };
                    MacroActions.Add(macroAction);
                    MacroActionsBindingSource.ResetBindings(false);
                    break;
                }
                case (char)Keys.Back:
                {
                    var macroAction = new MacroAction()
                    {
                        MacroActionType = MacroActionType.KeyPress,
                        EventName = "Special Key",
                        EventParameters = "",
                        Value = "Back",
                        Comment = ""
                    };
                    MacroActions.Add(macroAction);
                    MacroActionsBindingSource.ResetBindings(false);
                    break;
                    }
            }
        }
        if (MacroActions.Count > 0)
        {
            MacroActions[^1].Interval = (int)_stopwatch.ElapsedMilliseconds;
        }
        _stopwatch.Restart();
    }
    public void Unsubscribe()
        {
            //_mGlobalHook.KeyDown += GlobalHookKeyDown; On Global key including special keys.
            _mGlobalHook.KeyPress -= GlobalHookKeyPress;
            _mGlobalHook.MouseDownExt -= GlobalHookMouseDownExt;
            _mGlobalHook.MouseWheelExt += GlobalHookMouseWheelExt;
            _mGlobalHook.Dispose();
        }
    public void GlobalHookMouseDownExt(object? sender, MouseEventExtArgs e)
    {
        if (CurrentWord.Length > 0)
        {
            var macroActionKeypress = new MacroAction()
            {
                MacroActionType = MacroActionType.KeyPress,
                EventName = "Text Input",
                EventParameters = "",
                Value = CurrentWord.ToString(),
                Comment = ""
            };
            MacroActions.Add(macroActionKeypress);

            // Reset the currentWord for the next input sequence
            CurrentWord.Clear();
        }
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
        _textInputTimer.Stop();
        if (MacroActions.Count > 0)
        {
            MacroActions[^1].Interval = (int)_stopwatch.ElapsedMilliseconds;
        }
        _stopwatch.Restart();
    }
    public bool IsMacroActionsNull() => MacroActions.Count == 0;
    public void ClearMacroActions() => MacroActionsBindingSource.Clear();
    public async Task PlayMacroActions()
    {
        var macroActionsCopy = new List<MacroAction>(MacroActions);
        var inputSimulator = new InputSimulator();
        var defaultDelay = 100;
        foreach (var action in macroActionsCopy)
        {
            switch (action.MacroActionType)
            {
                case MacroActionType.KeyPress when action.EventName.Equals("Text Input"):
                    foreach (var letter in action.Value)
                    {
                        inputSimulator.Keyboard.TextEntry(letter);
                        await Task.Delay(defaultDelay);
                    }
                    break;
                case MacroActionType.KeyPress when action.EventName.Equals("Special Key"):
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
                case MacroActionType.MouseWheel:
                {
                    if (int.TryParse(action.EventParameters, out var delta))
                    {
                        inputSimulator.Mouse.VerticalScroll(delta);
                    }
                    await Task.Delay(200);
                    break;
                }
                case MacroActionType.Interval:
                    // If it's an interval action, set the desired delay and wait
                    var desiredDelay = action.Interval > 0 ? action.Interval : defaultDelay;
                    await Task.Delay(100);
                    break;
                case MacroActionType.MouseMove:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            await Task.Delay(400);
        }
    }
    private int Interpolate(int start, int end, int currentStep, int totalStep)
    {
        return start + ((end - start) * currentStep / totalStep);
    }
    private static VirtualKeyCode GetModifierKeyCode(string modifier)
    {
        return modifier switch
        {
            "shift" => VirtualKeyCode.SHIFT,
            "ctrl" => VirtualKeyCode.CONTROL,
            "alt" => VirtualKeyCode.MENU,
            "tab" => VirtualKeyCode.TAB,
            "enter" => VirtualKeyCode.RETURN,
            "back" => VirtualKeyCode.BACK,
            _ => VirtualKeyCode.None,
        };
    }
    public void OnLoadScript(List<MacroAction> loadedMacroActions)
    {
        MacroActions.Clear();
        MacroActions.AddRange(loadedMacroActions);
        MacroActionsBindingSource.ResetBindings(false);
    }
}