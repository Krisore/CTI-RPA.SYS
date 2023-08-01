using CTI_RPA.SYS.Services.Interface;
using OfficeOpenXml;
using CTI_RPA.SYS.Model;
namespace CTI_RPA.SYS.Services;
public class FileManagerService : IFileManagerService
{
    public List<MacroAction> LoadFile(string filePath)
    {
        var loadedMacroActions = ReadFromExcel(filePath);
        return loadedMacroActions;
    }
    private List<MacroAction> ReadFromExcel(string filePath)
    {
        List<MacroAction> macroActions = new List<MacroAction>();
        try
        {
            var file = new FileInfo(filePath);

            using ExcelPackage package = new ExcelPackage(file);
            ExcelWorksheet? worksheet = package.Workbook.Worksheets.FirstOrDefault();
            if (worksheet != null)
            {
                int rowCount = worksheet.Dimension.Rows;

                for (int i = 2; i <= rowCount; i++) // Start from the second row (assuming headers are in the first row)
                {
                    MacroAction macroAction = new MacroAction();

                    macroAction.MacroActionType = Enum.Parse<MacroActionType>(worksheet.Cells[i, 1].Value?.ToString() ?? "");

                    macroAction.EventName = worksheet.Cells[i, 2].Value?.ToString() ?? "";
                    macroAction.EventParameters = worksheet.Cells[i, 3].Value?.ToString() ?? "";
                    macroAction.Value = worksheet.Cells[i, 4].Value?.ToString() ?? "";
                    macroAction.Comment = worksheet.Cells[i, 5].Value?.ToString() ?? "";

                    macroActions.Add(macroAction);
                }
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions that might occur during reading from the Excel file
            MessageBox.Show("Error reading data from the Excel file: " + ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return macroActions;
    }
    public void SaveFile(List<MacroAction> macroActions, string filePath)
    {
        using var package = new ExcelPackage();
        var worksheet = package.Workbook.Worksheets.Add("MacroActions");

        // Add headers to the worksheet
        worksheet.Cells[1, 1].Value = "MacroActionType";
        worksheet.Cells[1, 2].Value = "EventName";
        worksheet.Cells[1, 3].Value = "EventParameters";
        worksheet.Cells[1, 4].Value = "Value";
        worksheet.Cells[1, 5].Value = "Comment";
        // Add data to the worksheet
        for (int i = 0; i < macroActions.Count; i++)
        {
            worksheet.Cells[i + 2, 1].Value = macroActions[i].MacroActionType.ToString();
            worksheet.Cells[i + 2, 2].Value = macroActions[i].EventName;
            worksheet.Cells[i + 2, 3].Value = macroActions[i].EventParameters;
            worksheet.Cells[i + 2, 4].Value = macroActions[i].Value;
            worksheet.Cells[i + 2, 5].Value = macroActions[i].Comment;
        }
        // Save the Excel package to the specified file path
        package.SaveAs(new FileInfo(filePath));
    }
}
