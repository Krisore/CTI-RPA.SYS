using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTI_RPA.SYS.Model
{
    public enum MacroActionType
    {
        KeyPress,
        MouseClick,
        MouseMove,
        MouseWheel,
        Interval,
    }
    public class MacroAction
    {
        public MacroActionType MacroActionType { get; set; }
        public string EventName { get; set; } = string.Empty;
        public string EventParameters { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
    }
}
