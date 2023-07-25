using CTI_RPA.SYS.Model;
using Gma.System.MouseKeyHook;
using CTI_RPA.SYS.Services.Interface;

namespace CTI_RPA.SYS.Services
{
    public class MacroService : IMacroService
    {
        private IKeyboardMouseEvents _mGlobalHook;
        public  List<MacroAction> MacroActions { get; set; } = new();
        public BindingSource MacroActionsBindingSource { get; } = new();
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
        private void GlobalHookKeyDown(object? sender, KeyEventArgs e)
        {
            var macroAction = new MacroAction
            {
                MacroActionType = MacroActionType.KeyPress,
                EventName = $"Key Down: '{e.KeyCode}'",
                EventParameters = $"{e.KeyCode}",
                Value = $"{e.KeyData}",
                Comment = ""
            };
            MacroActions.Add(macroAction);
            MacroActionsBindingSource.ResetBindings(false);
        }
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
            //_mGlobalHook.KeyDown += GlobalHookKeyDown;
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

    }
}
