using CTI_RPA.SYS.Model;
using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTI_RPA.SYS.Services.Interface
{
    public interface IMacroService
    {
        List<MacroAction> MacroActions { get; set; }
        BindingSource MacroActionsBindingSource { get; }
        public void Subscribe();
        public void Unsubscribe();
        public bool IsMacroActionsNull();
        public void ClearMacroActions();
        public void PlayMacroActions();
        public void SaveScript(List<MacroAction> macroActions, string filePath);

        void InsertScript(string filePath);
    }
}
