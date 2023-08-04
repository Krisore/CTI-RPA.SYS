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
            MainToolStrip = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            newProjectToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            macroLog = new DataGridView();
            toolStripContainer1 = new ToolStripContainer();
            panel1 = new Panel();
            statusStrip1 = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStrip1 = new ToolStrip();
            toolStripSeparator = new ToolStripSeparator();
            helpToolStripButton = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            ScriptLabel = new ToolStripLabel();
            newToolStripButton1 = new ToolStripButton();
            openToolStripButton1 = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            printToolStripButton = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            cutToolStripButton1 = new ToolStripButton();
            copyToolStripButton1 = new ToolStripButton();
            pasteToolStripButton1 = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            RecordTab = new TabPage();
            WatchToolStrip = new ToolStrip();
            RightDivider1 = new ToolStripSeparator();
            Divider = new ToolStripSeparator();
            StopButton = new FontAwesome.Sharp.IconToolStripButton();
            RecordButton = new FontAwesome.Sharp.IconToolStripButton();
            InsertScriptButton = new FontAwesome.Sharp.IconToolStripButton();
            Divider1 = new ToolStripSeparator();
            AddStepButton = new FontAwesome.Sharp.IconToolStripButton();
            SelectObjectButton = new FontAwesome.Sharp.IconToolStripButton();
            ClearButton = new FontAwesome.Sharp.IconToolStripButton();
            Divider2 = new ToolStripSeparator();
            PlayButton = new FontAwesome.Sharp.IconToolStripButton();
            RightDivider = new ToolStripSeparator();
            scheduler = new FontAwesome.Sharp.IconToolStripButton();
            TabControl = new TabControl();
            tabPage1 = new TabPage();
            folderBrowserDialog1 = new FolderBrowserDialog();
            MainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)macroLog).BeginInit();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            RecordTab.SuspendLayout();
            WatchToolStrip.SuspendLayout();
            TabControl.SuspendLayout();
            SuspendLayout();
            // 
            // MainToolStrip
            // 
            MainToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            MainToolStrip.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator1 });
            MainToolStrip.Location = new Point(0, 0);
            MainToolStrip.Name = "MainToolStrip";
            MainToolStrip.Size = new Size(1219, 25);
            MainToolStrip.TabIndex = 0;
            MainToolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { newProjectToolStripMenuItem, openToolStripMenuItem, settingsToolStripMenuItem, exitToolStripMenuItem });
            toolStripDropDownButton1.ForeColor = Color.Black;
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(38, 22);
            toolStripDropDownButton1.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            newProjectToolStripMenuItem.Size = new Size(138, 22);
            newProjectToolStripMenuItem.Text = "New Project";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(138, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(138, 22);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(138, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // macroLog
            // 
            macroLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            macroLog.BackgroundColor = Color.FromArgb(224, 224, 224);
            macroLog.BorderStyle = BorderStyle.None;
            macroLog.CellBorderStyle = DataGridViewCellBorderStyle.None;
            macroLog.Dock = DockStyle.Fill;
            macroLog.GridColor = SystemColors.ActiveCaptionText;
            macroLog.Location = new Point(0, 0);
            macroLog.Margin = new Padding(10);
            macroLog.Name = "macroLog";
            macroLog.ReadOnly = true;
            macroLog.RowTemplate.Height = 25;
            macroLog.Size = new Size(1219, 582);
            macroLog.TabIndex = 2;
            macroLog.DataError += MacroLog_DataError;
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(panel1);
            toolStripContainer1.ContentPanel.Size = new Size(1219, 582);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(0, 142);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(1219, 607);
            toolStripContainer1.TabIndex = 3;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // panel1
            // 
            panel1.Controls.Add(statusStrip1);
            panel1.Controls.Add(macroLog);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1219, 582);
            panel1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 560);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1219, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 17);
            StatusLabel.Text = "Status:";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator, helpToolStripButton, toolStripTextBox1, iconToolStripButton1, toolStripSeparator3, ScriptLabel, newToolStripButton1, openToolStripButton1, saveToolStripButton, printToolStripButton, toolStripSeparator5, cutToolStripButton1, copyToolStripButton1, pasteToolStripButton1, toolStripSeparator6 });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(993, 25);
            toolStrip1.TabIndex = 0;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.Alignment = ToolStripItemAlignment.Right;
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Image = (Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = Color.Magenta;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(23, 22);
            helpToolStripButton.Text = "He&lp";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Alignment = ToolStripItemAlignment.Right;
            toolStripTextBox1.BorderStyle = BorderStyle.FixedSingle;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(250, 25);
            // 
            // iconToolStripButton1
            // 
            iconToolStripButton1.Alignment = ToolStripItemAlignment.Right;
            iconToolStripButton1.ForeColor = Color.Black;
            iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconToolStripButton1.IconColor = Color.FromArgb(255, 128, 0);
            iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton1.ImageTransparentColor = Color.Magenta;
            iconToolStripButton1.Name = "iconToolStripButton1";
            iconToolStripButton1.Size = new Size(93, 22);
            iconToolStripButton1.Text = "Data Source:";
            iconToolStripButton1.ToolTipText = "Data Source";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator3.Margin = new Padding(300, 0, 0, 0);
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // ScriptLabel
            // 
            ScriptLabel.Alignment = ToolStripItemAlignment.Right;
            ScriptLabel.ForeColor = Color.Black;
            ScriptLabel.Name = "ScriptLabel";
            ScriptLabel.Size = new Size(137, 22);
            ScriptLabel.Text = "Script Name: (No Name)";
            // 
            // newToolStripButton1
            // 
            newToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton1.Image = (Image)resources.GetObject("newToolStripButton1.Image");
            newToolStripButton1.ImageTransparentColor = Color.Magenta;
            newToolStripButton1.Name = "newToolStripButton1";
            newToolStripButton1.Size = new Size(23, 22);
            newToolStripButton1.Text = "&New";
            // 
            // openToolStripButton1
            // 
            openToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton1.Image = (Image)resources.GetObject("openToolStripButton1.Image");
            openToolStripButton1.ImageTransparentColor = Color.Magenta;
            openToolStripButton1.Name = "openToolStripButton1";
            openToolStripButton1.Size = new Size(23, 22);
            openToolStripButton1.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(23, 22);
            saveToolStripButton.Text = "&Save";
            saveToolStripButton.Click += saveToolStripButton_Click_1;
            // 
            // printToolStripButton
            // 
            printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printToolStripButton.Image = (Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = Color.Magenta;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new Size(23, 22);
            printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // cutToolStripButton1
            // 
            cutToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutToolStripButton1.Image = (Image)resources.GetObject("cutToolStripButton1.Image");
            cutToolStripButton1.ImageTransparentColor = Color.Magenta;
            cutToolStripButton1.Name = "cutToolStripButton1";
            cutToolStripButton1.Size = new Size(23, 22);
            cutToolStripButton1.Text = "C&ut";
            // 
            // copyToolStripButton1
            // 
            copyToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButton1.Image = (Image)resources.GetObject("copyToolStripButton1.Image");
            copyToolStripButton1.ImageTransparentColor = Color.Magenta;
            copyToolStripButton1.Name = "copyToolStripButton1";
            copyToolStripButton1.Size = new Size(23, 22);
            copyToolStripButton1.Text = "&Copy";
            // 
            // pasteToolStripButton1
            // 
            pasteToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pasteToolStripButton1.Image = (Image)resources.GetObject("pasteToolStripButton1.Image");
            pasteToolStripButton1.ImageTransparentColor = Color.Magenta;
            pasteToolStripButton1.Name = "pasteToolStripButton1";
            pasteToolStripButton1.Size = new Size(23, 22);
            pasteToolStripButton1.Text = "&Paste";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
            // 
            // RecordTab
            // 
            RecordTab.BackColor = Color.Transparent;
            RecordTab.Controls.Add(WatchToolStrip);
            RecordTab.Location = new Point(4, 30);
            RecordTab.Margin = new Padding(3, 4, 3, 4);
            RecordTab.Name = "RecordTab";
            RecordTab.Padding = new Padding(3, 4, 3, 4);
            RecordTab.Size = new Size(1211, 83);
            RecordTab.TabIndex = 0;
            RecordTab.Text = "Record & Edit";
            // 
            // WatchToolStrip
            // 
            WatchToolStrip.Dock = DockStyle.Fill;
            WatchToolStrip.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            WatchToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            WatchToolStrip.Items.AddRange(new ToolStripItem[] { RightDivider1, Divider, StopButton, RecordButton, InsertScriptButton, Divider1, AddStepButton, SelectObjectButton, ClearButton, Divider2, PlayButton, RightDivider, scheduler });
            WatchToolStrip.Location = new Point(3, 4);
            WatchToolStrip.Name = "WatchToolStrip";
            WatchToolStrip.RenderMode = ToolStripRenderMode.Professional;
            WatchToolStrip.Size = new Size(1205, 75);
            WatchToolStrip.TabIndex = 0;
            WatchToolStrip.Text = "toolStrip1";
            // 
            // RightDivider1
            // 
            RightDivider1.Alignment = ToolStripItemAlignment.Right;
            RightDivider1.Margin = new Padding(0, 0, 5, 0);
            RightDivider1.Name = "RightDivider1";
            RightDivider1.Size = new Size(6, 75);
            // 
            // Divider
            // 
            Divider.Margin = new Padding(5, 0, 0, 0);
            Divider.Name = "Divider";
            Divider.Size = new Size(6, 75);
            // 
            // StopButton
            // 
            StopButton.Alignment = ToolStripItemAlignment.Right;
            StopButton.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            StopButton.ForeColor = Color.Black;
            StopButton.IconChar = FontAwesome.Sharp.IconChar.Square;
            StopButton.IconColor = Color.FromArgb(13, 114, 194);
            StopButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            StopButton.IconSize = 40;
            StopButton.ImageAlign = ContentAlignment.BottomCenter;
            StopButton.ImageScaling = ToolStripItemImageScaling.None;
            StopButton.ImageTransparentColor = Color.Magenta;
            StopButton.Name = "StopButton";
            StopButton.Padding = new Padding(10, 0, 10, 0);
            StopButton.Size = new Size(64, 72);
            StopButton.Text = "Stop";
            StopButton.TextImageRelation = TextImageRelation.ImageAboveText;
            StopButton.Click += StopButton_Click;
            // 
            // RecordButton
            // 
            RecordButton.Alignment = ToolStripItemAlignment.Right;
            RecordButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RecordButton.ForeColor = Color.Black;
            RecordButton.IconChar = FontAwesome.Sharp.IconChar.Circle;
            RecordButton.IconColor = Color.FromArgb(241, 85, 50);
            RecordButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            RecordButton.IconSize = 40;
            RecordButton.ImageScaling = ToolStripItemImageScaling.None;
            RecordButton.ImageTransparentColor = Color.Magenta;
            RecordButton.Name = "RecordButton";
            RecordButton.Padding = new Padding(10, 0, 10, 0);
            RecordButton.Size = new Size(76, 72);
            RecordButton.Text = "Record";
            RecordButton.TextAlign = ContentAlignment.BottomCenter;
            RecordButton.TextImageRelation = TextImageRelation.ImageAboveText;
            RecordButton.Click += RecordButton_Click_1;
            // 
            // InsertScriptButton
            // 
            InsertScriptButton.ForeColor = Color.Black;
            InsertScriptButton.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            InsertScriptButton.IconColor = Color.FromArgb(64, 64, 64);
            InsertScriptButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            InsertScriptButton.IconSize = 40;
            InsertScriptButton.ImageScaling = ToolStripItemImageScaling.None;
            InsertScriptButton.ImageTransparentColor = Color.DarkViolet;
            InsertScriptButton.Name = "InsertScriptButton";
            InsertScriptButton.Size = new Size(75, 72);
            InsertScriptButton.Text = "Insert Script";
            InsertScriptButton.TextImageRelation = TextImageRelation.ImageAboveText;
            InsertScriptButton.Click += InsertScriptButton_Click;
            // 
            // Divider1
            // 
            Divider1.Name = "Divider1";
            Divider1.Size = new Size(6, 75);
            // 
            // AddStepButton
            // 
            AddStepButton.Enabled = false;
            AddStepButton.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            AddStepButton.ForeColor = Color.Black;
            AddStepButton.IconChar = FontAwesome.Sharp.IconChar.Add;
            AddStepButton.IconColor = Color.Black;
            AddStepButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddStepButton.IconSize = 40;
            AddStepButton.ImageScaling = ToolStripItemImageScaling.None;
            AddStepButton.ImageTransparentColor = Color.Magenta;
            AddStepButton.Name = "AddStepButton";
            AddStepButton.Size = new Size(55, 72);
            AddStepButton.Text = "Add Step";
            AddStepButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // SelectObjectButton
            // 
            SelectObjectButton.Enabled = false;
            SelectObjectButton.ForeColor = Color.Black;
            SelectObjectButton.IconChar = FontAwesome.Sharp.IconChar.ObjectUngroup;
            SelectObjectButton.IconColor = Color.Black;
            SelectObjectButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            SelectObjectButton.IconSize = 40;
            SelectObjectButton.ImageScaling = ToolStripItemImageScaling.None;
            SelectObjectButton.ImageTransparentColor = Color.Magenta;
            SelectObjectButton.Name = "SelectObjectButton";
            SelectObjectButton.Size = new Size(83, 72);
            SelectObjectButton.Text = "Select Object";
            SelectObjectButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ClearButton
            // 
            ClearButton.ForeColor = Color.Black;
            ClearButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            ClearButton.IconColor = Color.FromArgb(64, 64, 64);
            ClearButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ClearButton.IconSize = 40;
            ClearButton.ImageScaling = ToolStripItemImageScaling.None;
            ClearButton.ImageTransparentColor = Color.Magenta;
            ClearButton.Name = "ClearButton";
            ClearButton.Padding = new Padding(10, 0, 10, 0);
            ClearButton.Size = new Size(64, 72);
            ClearButton.Text = "Clear";
            ClearButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ClearButton.Click += ClearButton_Click;
            // 
            // Divider2
            // 
            Divider2.Name = "Divider2";
            Divider2.Size = new Size(6, 75);
            // 
            // PlayButton
            // 
            PlayButton.Alignment = ToolStripItemAlignment.Right;
            PlayButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PlayButton.ForeColor = Color.Black;
            PlayButton.IconChar = FontAwesome.Sharp.IconChar.Play;
            PlayButton.IconColor = Color.FromArgb(101, 239, 67);
            PlayButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PlayButton.IconSize = 40;
            PlayButton.ImageAlign = ContentAlignment.BottomCenter;
            PlayButton.ImageScaling = ToolStripItemImageScaling.None;
            PlayButton.ImageTransparentColor = Color.Magenta;
            PlayButton.Name = "PlayButton";
            PlayButton.Padding = new Padding(10, 0, 10, 0);
            PlayButton.Size = new Size(64, 72);
            PlayButton.Text = "Play";
            PlayButton.TextImageRelation = TextImageRelation.ImageAboveText;
            PlayButton.Click += PlayButton_Click;
            // 
            // RightDivider
            // 
            RightDivider.Alignment = ToolStripItemAlignment.Right;
            RightDivider.Name = "RightDivider";
            RightDivider.Size = new Size(6, 75);
            // 
            // scheduler
            // 
            scheduler.Enabled = false;
            scheduler.ForeColor = Color.Black;
            scheduler.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            scheduler.IconColor = Color.Black;
            scheduler.IconFont = FontAwesome.Sharp.IconFont.Solid;
            scheduler.IconSize = 40;
            scheduler.ImageScaling = ToolStripItemImageScaling.None;
            scheduler.ImageTransparentColor = Color.Magenta;
            scheduler.Name = "scheduler";
            scheduler.Size = new Size(96, 72);
            scheduler.Text = "Task Scheduler";
            scheduler.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(RecordTab);
            TabControl.Controls.Add(tabPage1);
            TabControl.Dock = DockStyle.Top;
            TabControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TabControl.Location = new Point(0, 25);
            TabControl.Margin = new Padding(3, 4, 3, 4);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1219, 117);
            TabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1211, 83);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Version Control";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1219, 749);
            Controls.Add(toolStripContainer1);
            Controls.Add(TabControl);
            Controls.Add(MainToolStrip);
            Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.WhiteSmoke;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Process Automation";
            Load += MainForm_Load;
            MainToolStrip.ResumeLayout(false);
            MainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)macroLog).EndInit();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            RecordTab.ResumeLayout(false);
            RecordTab.PerformLayout();
            WatchToolStrip.ResumeLayout(false);
            WatchToolStrip.PerformLayout();
            TabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStripButton newToolStripButton1;
        private ToolStripButton openToolStripButton1;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton printToolStripButton;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton cutToolStripButton1;
        private ToolStripButton copyToolStripButton1;
        private ToolStripButton pasteToolStripButton1;
        private ToolStripSeparator toolStripSeparator6;
        private FontAwesome.Sharp.IconToolStripButton scheduler;
        private TabPage tabPage1;
    }
}