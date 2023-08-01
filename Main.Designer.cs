namespace CTI_RPA.SYS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing"> true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.macroLog = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ScriptLabel = new System.Windows.Forms.ToolStripLabel();
            this.RecordTab = new System.Windows.Forms.TabPage();
            this.WatchToolStrip = new System.Windows.Forms.ToolStrip();
            this.RightDivider1 = new System.Windows.Forms.ToolStripSeparator();
            this.Divider = new System.Windows.Forms.ToolStripSeparator();
            this.StopButton = new FontAwesome.Sharp.IconToolStripButton();
            this.RecordButton = new FontAwesome.Sharp.IconToolStripButton();
            this.InsertScriptButton = new FontAwesome.Sharp.IconToolStripButton();
            this.Divider1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddStepButton = new FontAwesome.Sharp.IconToolStripButton();
            this.SelectObjectButton = new FontAwesome.Sharp.IconToolStripButton();
            this.ClearButton = new FontAwesome.Sharp.IconToolStripButton();
            this.Divider2 = new System.Windows.Forms.ToolStripSeparator();
            this.PlayButton = new FontAwesome.Sharp.IconToolStripButton();
            this.RightDivider = new System.Windows.Forms.ToolStripSeparator();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.MainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.macroLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.RecordTab.SuspendLayout();
            this.WatchToolStrip.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(1219, 25);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // macroLog
            // 
            this.macroLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.macroLog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.macroLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.macroLog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.macroLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.macroLog.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.macroLog.Location = new System.Drawing.Point(0, 0);
            this.macroLog.Margin = new System.Windows.Forms.Padding(10);
            this.macroLog.Name = "macroLog";
            this.macroLog.ReadOnly = true;
            this.macroLog.RowTemplate.Height = 25;
            this.macroLog.Size = new System.Drawing.Size(910, 582);
            this.macroLog.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 142);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStripContainer1);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Size = new System.Drawing.Size(1219, 607);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 3;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.SaveToolButton,
            this.toolStripSeparator2,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator4,
            this.helpToolStripButton1});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip3.Size = new System.Drawing.Size(24, 607);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(21, 20);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(21, 20);
            this.openToolStripButton.Text = "&Open";
            // 
            // SaveToolButton
            // 
            this.SaveToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolButton.Image")));
            this.SaveToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolButton.Name = "SaveToolButton";
            this.SaveToolButton.Size = new System.Drawing.Size(21, 20);
            this.SaveToolButton.Text = "&Save";
            this.SaveToolButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(21, 6);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(21, 20);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(21, 20);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(21, 20);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(21, 6);
            // 
            // helpToolStripButton1
            // 
            this.helpToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton1.Image")));
            this.helpToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton1.Name = "helpToolStripButton1";
            this.helpToolStripButton1.Size = new System.Drawing.Size(21, 20);
            this.helpToolStripButton1.Text = "He&lp";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(910, 582);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(910, 607);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.macroLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 582);
            this.panel1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(910, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(42, 17);
            this.StatusLabel.Text = "Status:";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator,
            this.helpToolStripButton,
            this.toolStripTextBox1,
            this.iconToolStripButton1,
            this.toolStripSeparator3,
            this.ScriptLabel});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(851, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(250, 25);
            // 
            // iconToolStripButton1
            // 
            this.iconToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconToolStripButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconToolStripButton1.Name = "iconToolStripButton1";
            this.iconToolStripButton1.Size = new System.Drawing.Size(93, 22);
            this.iconToolStripButton1.Text = "Data Source:";
            this.iconToolStripButton1.ToolTipText = "Data Source";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(300, 0, 0, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ScriptLabel
            // 
            this.ScriptLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ScriptLabel.Name = "ScriptLabel";
            this.ScriptLabel.Size = new System.Drawing.Size(137, 22);
            this.ScriptLabel.Text = "Script Name: (No Name)";
            // 
            // RecordTab
            // 
            this.RecordTab.BackColor = System.Drawing.Color.Transparent;
            this.RecordTab.Controls.Add(this.WatchToolStrip);
            this.RecordTab.Location = new System.Drawing.Point(4, 30);
            this.RecordTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RecordTab.Name = "RecordTab";
            this.RecordTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RecordTab.Size = new System.Drawing.Size(1211, 83);
            this.RecordTab.TabIndex = 0;
            this.RecordTab.Text = "Record & Edit";
            // 
            // WatchToolStrip
            // 
            this.WatchToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WatchToolStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WatchToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.WatchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RightDivider1,
            this.Divider,
            this.StopButton,
            this.RecordButton,
            this.InsertScriptButton,
            this.Divider1,
            this.AddStepButton,
            this.SelectObjectButton,
            this.ClearButton,
            this.Divider2,
            this.PlayButton,
            this.RightDivider});
            this.WatchToolStrip.Location = new System.Drawing.Point(3, 4);
            this.WatchToolStrip.Name = "WatchToolStrip";
            this.WatchToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.WatchToolStrip.Size = new System.Drawing.Size(1205, 75);
            this.WatchToolStrip.TabIndex = 0;
            this.WatchToolStrip.Text = "toolStrip1";
            // 
            // RightDivider1
            // 
            this.RightDivider1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.RightDivider1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.RightDivider1.Name = "RightDivider1";
            this.RightDivider1.Size = new System.Drawing.Size(6, 75);
            // 
            // Divider
            // 
            this.Divider.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(6, 75);
            // 
            // StopButton
            // 
            this.StopButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopButton.ForeColor = System.Drawing.Color.Black;
            this.StopButton.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.StopButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(114)))), ((int)(((byte)(194)))));
            this.StopButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.StopButton.IconSize = 40;
            this.StopButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StopButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopButton.Name = "StopButton";
            this.StopButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.StopButton.Size = new System.Drawing.Size(64, 72);
            this.StopButton.Text = "Stop";
            this.StopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // RecordButton
            // 
            this.RecordButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.RecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecordButton.ForeColor = System.Drawing.Color.Black;
            this.RecordButton.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.RecordButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(50)))));
            this.RecordButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.RecordButton.IconSize = 40;
            this.RecordButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.RecordButton.Size = new System.Drawing.Size(76, 72);
            this.RecordButton.Text = "Record";
            this.RecordButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RecordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click_1);
            // 
            // InsertScriptButton
            // 
            this.InsertScriptButton.ForeColor = System.Drawing.Color.Black;
            this.InsertScriptButton.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.InsertScriptButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InsertScriptButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InsertScriptButton.IconSize = 40;
            this.InsertScriptButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InsertScriptButton.ImageTransparentColor = System.Drawing.Color.DarkViolet;
            this.InsertScriptButton.Name = "InsertScriptButton";
            this.InsertScriptButton.Size = new System.Drawing.Size(75, 72);
            this.InsertScriptButton.Text = "Insert Script";
            this.InsertScriptButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.InsertScriptButton.Click += new System.EventHandler(this.InsertScriptButton_Click);
            // 
            // Divider1
            // 
            this.Divider1.Name = "Divider1";
            this.Divider1.Size = new System.Drawing.Size(6, 75);
            // 
            // AddStepButton
            // 
            this.AddStepButton.Enabled = false;
            this.AddStepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddStepButton.ForeColor = System.Drawing.Color.Black;
            this.AddStepButton.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.AddStepButton.IconColor = System.Drawing.Color.Black;
            this.AddStepButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddStepButton.IconSize = 40;
            this.AddStepButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddStepButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddStepButton.Name = "AddStepButton";
            this.AddStepButton.Size = new System.Drawing.Size(55, 72);
            this.AddStepButton.Text = "Add Step";
            this.AddStepButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SelectObjectButton
            // 
            this.SelectObjectButton.Enabled = false;
            this.SelectObjectButton.ForeColor = System.Drawing.Color.Black;
            this.SelectObjectButton.IconChar = FontAwesome.Sharp.IconChar.ObjectUngroup;
            this.SelectObjectButton.IconColor = System.Drawing.Color.Black;
            this.SelectObjectButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.SelectObjectButton.IconSize = 40;
            this.SelectObjectButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SelectObjectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectObjectButton.Name = "SelectObjectButton";
            this.SelectObjectButton.Size = new System.Drawing.Size(83, 72);
            this.SelectObjectButton.Text = "Select Object";
            this.SelectObjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ClearButton
            // 
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.ClearButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClearButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ClearButton.IconSize = 40;
            this.ClearButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ClearButton.Size = new System.Drawing.Size(64, 72);
            this.ClearButton.Text = "Clear";
            this.ClearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Divider2
            // 
            this.Divider2.Name = "Divider2";
            this.Divider2.Size = new System.Drawing.Size(6, 75);
            // 
            // PlayButton
            // 
            this.PlayButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayButton.ForeColor = System.Drawing.Color.Black;
            this.PlayButton.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.PlayButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(239)))), ((int)(((byte)(67)))));
            this.PlayButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PlayButton.IconSize = 40;
            this.PlayButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PlayButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.PlayButton.Size = new System.Drawing.Size(64, 72);
            this.PlayButton.Text = "Play";
            this.PlayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // RightDivider
            // 
            this.RightDivider.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.RightDivider.Name = "RightDivider";
            this.RightDivider.Size = new System.Drawing.Size(6, 75);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.RecordTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabControl.Location = new System.Drawing.Point(0, 25);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1219, 117);
            this.TabControl.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 749);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.MainToolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPA-CTI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.macroLog)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.RecordTab.ResumeLayout(false);
            this.RecordTab.PerformLayout();
            this.WatchToolStrip.ResumeLayout(false);
            this.WatchToolStrip.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private ToolStrip MainToolStrip;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem newProjectToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private DataGridView macroLog;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton helpToolStripButton;
        private ToolStripTextBox toolStripTextBox1;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private ToolStripSeparator toolStripSeparator3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripLabel ScriptLabel;
        private ToolStrip toolStrip3;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton SaveToolButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton copyToolStripButton;
        private ToolStripButton pasteToolStripButton;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton helpToolStripButton1;
        private ToolStripButton cutToolStripButton;
        private TabPage RecordTab;
        private ToolStrip WatchToolStrip;
        private ToolStripSeparator RightDivider1;
        private ToolStripSeparator Divider;
        private FontAwesome.Sharp.IconToolStripButton StopButton;
        private FontAwesome.Sharp.IconToolStripButton RecordButton;
        private FontAwesome.Sharp.IconToolStripButton InsertScriptButton;
        private ToolStripSeparator Divider1;
        private FontAwesome.Sharp.IconToolStripButton AddStepButton;
        private FontAwesome.Sharp.IconToolStripButton SelectObjectButton;
        private FontAwesome.Sharp.IconToolStripButton ClearButton;
        private ToolStripSeparator Divider2;
        private FontAwesome.Sharp.IconToolStripButton PlayButton;
        private ToolStripSeparator RightDivider;
        private TabControl TabControl;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}