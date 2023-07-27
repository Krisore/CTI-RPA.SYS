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
            TabControl = new TabControl();
            RecordTab = new TabPage();
            WatchToolStrip = new ToolStrip();
            SaveScript = new FontAwesome.Sharp.IconToolStripButton();
            RightDivider1 = new ToolStripSeparator();
            Divider = new ToolStripSeparator();
            StopButton = new FontAwesome.Sharp.IconToolStripButton();
            RecordButton = new FontAwesome.Sharp.IconToolStripButton();
            InsertScriptButton = new FontAwesome.Sharp.IconToolStripButton();
            AddStepButton = new FontAwesome.Sharp.IconToolStripButton();
            SelectObjectButton = new FontAwesome.Sharp.IconToolStripButton();
            Divider1 = new ToolStripSeparator();
            ClearButton = new FontAwesome.Sharp.IconToolStripButton();
            Divider2 = new ToolStripSeparator();
            PlayButton = new FontAwesome.Sharp.IconToolStripButton();
            RightDivider = new ToolStripSeparator();
            Playback = new TabPage();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            macroLog = new DataGridView();
            splitContainer1 = new SplitContainer();
            toolStrip2 = new ToolStrip();
            toolStripContainer1 = new ToolStripContainer();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            printToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            cutToolStripButton = new ToolStripButton();
            copyToolStripButton = new ToolStripButton();
            pasteToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            helpToolStripButton = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            statusStrip1 = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            MainToolStrip.SuspendLayout();
            TabControl.SuspendLayout();
            RecordTab.SuspendLayout();
            WatchToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)macroLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainToolStrip
            // 
            MainToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            MainToolStrip.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator1 });
            MainToolStrip.Location = new Point(0, 0);
            MainToolStrip.Name = "MainToolStrip";
            MainToolStrip.Size = new Size(1132, 25);
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
            // TabControl
            // 
            TabControl.Controls.Add(RecordTab);
            TabControl.Controls.Add(Playback);
            TabControl.Dock = DockStyle.Top;
            TabControl.Font = new Font("Fira Code", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            TabControl.Location = new Point(0, 25);
            TabControl.Margin = new Padding(3, 4, 3, 4);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1132, 125);
            TabControl.TabIndex = 1;
            // 
            // RecordTab
            // 
            RecordTab.Controls.Add(WatchToolStrip);
            RecordTab.Location = new Point(4, 34);
            RecordTab.Margin = new Padding(3, 4, 3, 4);
            RecordTab.Name = "RecordTab";
            RecordTab.Padding = new Padding(3, 4, 3, 4);
            RecordTab.Size = new Size(1124, 87);
            RecordTab.TabIndex = 0;
            RecordTab.Text = "Watch";
            RecordTab.UseVisualStyleBackColor = true;
            // 
            // WatchToolStrip
            // 
            WatchToolStrip.Font = new Font("Fira Code", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            WatchToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            WatchToolStrip.Items.AddRange(new ToolStripItem[] { SaveScript, RightDivider1, Divider, StopButton, RecordButton, InsertScriptButton, AddStepButton, SelectObjectButton, Divider1, ClearButton, Divider2, PlayButton, RightDivider });
            WatchToolStrip.Location = new Point(3, 4);
            WatchToolStrip.Name = "WatchToolStrip";
            WatchToolStrip.Size = new Size(1118, 76);
            WatchToolStrip.TabIndex = 0;
            WatchToolStrip.Text = "toolStrip1";
            // 
            // SaveScript
            // 
            SaveScript.ForeColor = Color.Black;
            SaveScript.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            SaveScript.IconColor = Color.FromArgb(64, 64, 64);
            SaveScript.IconFont = FontAwesome.Sharp.IconFont.Solid;
            SaveScript.ImageScaling = ToolStripItemImageScaling.None;
            SaveScript.ImageTransparentColor = Color.Magenta;
            SaveScript.Name = "SaveScript";
            SaveScript.Size = new Size(90, 73);
            SaveScript.Text = "Save Script";
            SaveScript.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // RightDivider1
            // 
            RightDivider1.Alignment = ToolStripItemAlignment.Right;
            RightDivider1.Name = "RightDivider1";
            RightDivider1.Size = new Size(6, 76);
            // 
            // Divider
            // 
            Divider.Margin = new Padding(15, 0, 15, 0);
            Divider.Name = "Divider";
            Divider.Size = new Size(6, 76);
            // 
            // StopButton
            // 
            StopButton.Alignment = ToolStripItemAlignment.Right;
            StopButton.Font = new Font("Fira Code", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            StopButton.ForeColor = Color.Black;
            StopButton.IconChar = FontAwesome.Sharp.IconChar.Square;
            StopButton.IconColor = Color.FromArgb(13, 114, 194);
            StopButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            StopButton.ImageScaling = ToolStripItemImageScaling.None;
            StopButton.ImageTransparentColor = Color.Magenta;
            StopButton.Name = "StopButton";
            StopButton.Padding = new Padding(10, 0, 10, 0);
            StopButton.Size = new Size(72, 73);
            StopButton.Text = "Stop";
            StopButton.TextImageRelation = TextImageRelation.ImageAboveText;
            StopButton.Click += StopButton_Click;
            // 
            // RecordButton
            // 
            RecordButton.Alignment = ToolStripItemAlignment.Right;
            RecordButton.Font = new Font("Fira Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RecordButton.ForeColor = Color.Black;
            RecordButton.IconChar = FontAwesome.Sharp.IconChar.Circle;
            RecordButton.IconColor = Color.FromArgb(241, 85, 50);
            RecordButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            RecordButton.ImageScaling = ToolStripItemImageScaling.None;
            RecordButton.ImageTransparentColor = Color.Magenta;
            RecordButton.Name = "RecordButton";
            RecordButton.Padding = new Padding(10, 0, 10, 0);
            RecordButton.Size = new Size(82, 73);
            RecordButton.Text = "Record";
            RecordButton.TextAlign = ContentAlignment.BottomCenter;
            RecordButton.TextImageRelation = TextImageRelation.ImageAboveText;
            RecordButton.Click += RecordButton_Click;
            // 
            // InsertScriptButton
            // 
            InsertScriptButton.ForeColor = Color.Black;
            InsertScriptButton.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            InsertScriptButton.IconColor = Color.FromArgb(64, 64, 64);
            InsertScriptButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            InsertScriptButton.ImageScaling = ToolStripItemImageScaling.None;
            InsertScriptButton.ImageTransparentColor = Color.DarkViolet;
            InsertScriptButton.Name = "InsertScriptButton";
            InsertScriptButton.Size = new Size(104, 73);
            InsertScriptButton.Text = "Insert Script";
            InsertScriptButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // AddStepButton
            // 
            AddStepButton.Enabled = false;
            AddStepButton.Font = new Font("Fira Code", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            AddStepButton.ForeColor = Color.Black;
            AddStepButton.IconChar = FontAwesome.Sharp.IconChar.Add;
            AddStepButton.IconColor = Color.Black;
            AddStepButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddStepButton.IconSize = 51;
            AddStepButton.ImageScaling = ToolStripItemImageScaling.None;
            AddStepButton.ImageTransparentColor = Color.Magenta;
            AddStepButton.Name = "AddStepButton";
            AddStepButton.Size = new Size(68, 73);
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
            SelectObjectButton.IconSize = 50;
            SelectObjectButton.ImageScaling = ToolStripItemImageScaling.None;
            SelectObjectButton.ImageTransparentColor = Color.Magenta;
            SelectObjectButton.Name = "SelectObjectButton";
            SelectObjectButton.Size = new Size(104, 73);
            SelectObjectButton.Text = "Select Object";
            SelectObjectButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // Divider1
            // 
            Divider1.Name = "Divider1";
            Divider1.Size = new Size(6, 76);
            // 
            // ClearButton
            // 
            ClearButton.ForeColor = Color.Black;
            ClearButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            ClearButton.IconColor = Color.FromArgb(64, 64, 64);
            ClearButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ClearButton.ImageScaling = ToolStripItemImageScaling.None;
            ClearButton.ImageTransparentColor = Color.Magenta;
            ClearButton.Name = "ClearButton";
            ClearButton.Padding = new Padding(10, 0, 10, 0);
            ClearButton.Size = new Size(72, 73);
            ClearButton.Text = "Clear";
            ClearButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ClearButton.Click += ClearButton_Click;
            // 
            // Divider2
            // 
            Divider2.Name = "Divider2";
            Divider2.Size = new Size(6, 76);
            // 
            // PlayButton
            // 
            PlayButton.Alignment = ToolStripItemAlignment.Right;
            PlayButton.Font = new Font("Fira Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PlayButton.ForeColor = Color.Black;
            PlayButton.IconChar = FontAwesome.Sharp.IconChar.Play;
            PlayButton.IconColor = Color.FromArgb(101, 239, 67);
            PlayButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PlayButton.ImageAlign = ContentAlignment.TopCenter;
            PlayButton.ImageScaling = ToolStripItemImageScaling.None;
            PlayButton.ImageTransparentColor = Color.Magenta;
            PlayButton.Name = "PlayButton";
            PlayButton.Padding = new Padding(10, 0, 10, 0);
            PlayButton.Size = new Size(72, 73);
            PlayButton.Text = "Play";
            PlayButton.TextImageRelation = TextImageRelation.ImageAboveText;
            PlayButton.Click += PlayButton_Click;
            // 
            // RightDivider
            // 
            RightDivider.Alignment = ToolStripItemAlignment.Right;
            RightDivider.Name = "RightDivider";
            RightDivider.Size = new Size(6, 76);
            // 
            // Playback
            // 
            Playback.Location = new Point(4, 34);
            Playback.Margin = new Padding(3, 4, 3, 4);
            Playback.Name = "Playback";
            Playback.Padding = new Padding(3, 4, 3, 4);
            Playback.Size = new Size(1124, 87);
            Playback.TabIndex = 1;
            Playback.Text = "Playback";
            Playback.UseVisualStyleBackColor = true;
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
            macroLog.Size = new Size(769, 590);
            macroLog.TabIndex = 2;
            macroLog.DataError += macroLog_DataError;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 150);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(toolStrip2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(toolStripContainer1);
            splitContainer1.Panel2.ForeColor = Color.Black;
            splitContainer1.Size = new Size(1132, 615);
            splitContainer1.SplitterDistance = 359;
            splitContainer1.TabIndex = 3;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.Left;
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(26, 615);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(panel1);
            toolStripContainer1.ContentPanel.Size = new Size(769, 590);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(769, 615);
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 590);
            panel1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, printToolStripButton, toolStripSeparator, cutToolStripButton, copyToolStripButton, pasteToolStripButton, toolStripSeparator2, helpToolStripButton, toolStripTextBox1, iconToolStripButton1, toolStripSeparator3 });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(766, 25);
            toolStrip1.TabIndex = 0;
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(23, 22);
            newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(23, 22);
            openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(23, 22);
            saveToolStripButton.Text = "&Save";
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
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // cutToolStripButton
            // 
            cutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutToolStripButton.Image = (Image)resources.GetObject("cutToolStripButton.Image");
            cutToolStripButton.ImageTransparentColor = Color.Magenta;
            cutToolStripButton.Name = "cutToolStripButton";
            cutToolStripButton.Size = new Size(23, 22);
            cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButton.Image = (Image)resources.GetObject("copyToolStripButton.Image");
            copyToolStripButton.ImageTransparentColor = Color.Magenta;
            copyToolStripButton.Name = "copyToolStripButton";
            copyToolStripButton.Size = new Size(23, 22);
            copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            pasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pasteToolStripButton.Image = (Image)resources.GetObject("pasteToolStripButton.Image");
            pasteToolStripButton.ImageTransparentColor = Color.Magenta;
            pasteToolStripButton.Name = "pasteToolStripButton";
            pasteToolStripButton.Size = new Size(23, 22);
            pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // helpToolStripButton
            // 
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
            iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconToolStripButton1.IconColor = Color.FromArgb(64, 64, 64);
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
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 568);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(769, 22);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1132, 765);
            Controls.Add(splitContainer1);
            Controls.Add(TabControl);
            Controls.Add(MainToolStrip);
            Font = new Font("Fira Code", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.WhiteSmoke;
            ImeMode = ImeMode.Off;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RPA-CTI";
            Load += MainForm_Load_1;
            MainToolStrip.ResumeLayout(false);
            MainToolStrip.PerformLayout();
            TabControl.ResumeLayout(false);
            RecordTab.ResumeLayout(false);
            RecordTab.PerformLayout();
            WatchToolStrip.ResumeLayout(false);
            WatchToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)macroLog).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private TabControl TabControl;
        private TabPage RecordTab;
        private TabPage Playback;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private DataGridView macroLog;
        private ToolStrip WatchToolStrip;
        private FontAwesome.Sharp.IconToolStripButton PlayButton;
        private FontAwesome.Sharp.IconToolStripButton RecordButton;
        private FontAwesome.Sharp.IconToolStripButton StopButton;
        private ToolStripSeparator Divider;
        private FontAwesome.Sharp.IconToolStripButton InsertScriptButton;
        private SplitContainer splitContainer1;
        private ToolStrip toolStrip2;
        private FontAwesome.Sharp.IconToolStripButton AddStepButton;
        private FontAwesome.Sharp.IconToolStripButton SelectObjectButton;
        private ToolStripSeparator Divider1;
        private FontAwesome.Sharp.IconToolStripButton ClearButton;
        private ToolStripSeparator Divider2;
        private FontAwesome.Sharp.IconToolStripButton SaveScript;
        private ToolStripSeparator RightDivider;
        private ToolStripSeparator RightDivider1;
        private Panel panel1;
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton printToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton cutToolStripButton;
        private ToolStripButton copyToolStripButton;
        private ToolStripButton pasteToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton helpToolStripButton;
        private ToolStripTextBox toolStripTextBox1;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private ToolStripSeparator toolStripSeparator3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel;
        private ToolStripProgressBar toolStripProgressBar1;
    }
}