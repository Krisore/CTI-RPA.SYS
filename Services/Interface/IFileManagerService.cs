
using CTI_RPA.SYS.Model;

namespace CTI_RPA.SYS.Services.Interface
{
    public interface IFileManagerService
    {
        public void SaveFile(List<MacroAction> macroActions);
    }
}
