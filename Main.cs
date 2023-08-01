using CTI_RPA.SYS.Services.Interface;
namespace CTI_RPA.SYS;
public partial class MainForm : Form
{
    /// <summary>
    /// Represents the main form of the CTI_RPA application for recording macro actions.
    /// </summary>
    public readonly BindingSource BindingSource = new();
    private readonly IMacroService _macroService;
    private readonly IFileManagerService fileManager;
    public MainForm(IMacroService macroService, IFileManagerService fileManager)
    {
        _macroService = macroService;
        this.fileManager = fileManager;
        InitializeComponent();
        BindingSource.DataSource = _macroService.MacroActionsBindingSource;
        macroLog.DataSource = BindingSource;
        BindingSource.ResetBindings(false);
    }
    private DialogResult PopDialogResult()
    {
        var popStartRecord = new PopStartRecord();
        popStartRecord.TopMost = true;
        popStartRecord.StartPosition = FormStartPosition.Manual;
        popStartRecord.Location = new Point(Screen.PrimaryScreen.Bounds.Width - popStartRecord.Width, Screen.PrimaryScreen.Bounds.Height - popStartRecord.Height);
        popStartRecord.ShowDialog(this);
        popStartRecord.Dispose();
        return popStartRecord.DialogResult;
    }
    private void StopButton_Click(object sender, EventArgs e)
    {
        RecordButton.Enabled = true;
        ClearButton.Enabled = true;
        StopButton.Enabled = false;
        macroLog.ReadOnly = false;
        _macroService.Unsubscribe();
    }
    private void PlayButton_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
        RecordButton.Enabled = true;
        StopButton.Enabled = false;
        _macroService.PlayMacroActions();
    }
    private void ClearButton_Click(object sender, EventArgs e)
    {
        _macroService.ClearMacroActions();
        if (_macroService.IsMacroActionsNull())
        {
            RecordButton.Enabled = true;
            StopButton.Enabled = false;
            PlayButton.Enabled = false;
            ClearButton.Enabled = false;
        }
        BindingSource.ResetBindings(false);
    }
    private void MacroLog_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        if (e.Context == DataGridViewDataErrorContexts.Formatting)
        {
            // Handle formatting errors (e.g., converting data to display values)
            // You can display a message to the user or log the error as needed
            MessageBox.Show(@"Data formatting error occurred. Please check the entered values.", @"Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else if (e.Exception is FormatException)
        {
            // Handle data conversion errors (e.g., converting user input to the data type of the cell)
            // You can display a message to the user or log the error as needed
            MessageBox.Show(@"Invalid data format. Please enter a valid value.", @"Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            // Handle other data errors (e.g., data validation errors)
            // You can display a message to the user or log the error as needed
            MessageBox.Show(@"An error occurred while processing data.", @"Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // Mark the error as handled to prevent further default error handling
        e.ThrowException = false;
    }
    private void SaveToolStripButton_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(@"Save Script", @"Save your recorded script?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        if (result == DialogResult.OK && !_macroService.IsMacroActionsNull())
        {
            fileManager.SaveFile(_macroService.MacroActions, @"C:\Users\OJT\source\repos\Krisore\CTI-RPA.SYS\SavedFile\test.xlsx");
        }
        else
        {
            MessageBox.Show(@"No recorded Macro", @"Tch. ", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
    private void InsertScriptButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog()
        {
            Filter = @"Excel Files|*.xls;*.xlsx;*.xlsm",
            Title = @"Select a Excel File"
        };
        if (openFileDialog.ShowDialog() != DialogResult.OK) return;
        var result = MessageBox.Show(@"Script will be loaded, Are you sure?", @"Insert Script", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        if (result != DialogResult.OK) return;
        _macroService.OnLoadScript(fileManager.LoadFile(openFileDialog.FileName));
        MessageBox.Show(@"Script is loaded from Excel successfully!", @"Load from Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        BindingSource.ResetBindings(false);
        RecordButton.Enabled = false;
        PlayButton.Enabled = true;
        StopButton.Enabled = false;
        ClearButton.Enabled = true;
    }
    private void RecordButton_Click_1(object sender, EventArgs e)
    {
        RecordButton.Enabled = false;
        StopButton.Enabled = true;
        WindowState = FormWindowState.Minimized;
        macroLog.ReadOnly = true;
        if (PopDialogResult() == DialogResult.OK)
        {
            ClearButton.Enabled = false;
            PlayButton.Enabled = true;
            StopButton.Enabled = true;
            this.WindowState = FormWindowState.Minimized;
            _macroService.Subscribe();
        }
        else
        {
            RecordButton.Enabled = true;
            WindowState = FormWindowState.Normal;
        }
    }
    private void MainForm_Load(object sender, EventArgs e)
    {
        if (_macroService.MacroActions.Count() != 0) return;
        PlayButton.Enabled = false;
        StopButton.Enabled = false;
        ClearButton.Enabled = false;
    }
    //Note: Minimize or Hide the Main Form while recording or playback.
    //Undone: Inserting Data Source
    //Undone: Reading key shorcut
    //TODO: Add a key shortcut to stop the recording
    //TODO: Add Step for manual edit of script.
    //TODO: Select Object for manual select of step.
    //TODO: File Explorer & File management
    //TODO: Enhance async Task 
}
