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
            PlayButton = new FontAwesome.Sharp.IconToolStripButton();
            RecordButton = new FontAwesome.Sharp.IconToolStripButton();
            stopButton = new FontAwesome.Sharp.IconToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            insertScriptButton = new FontAwesome.Sharp.IconToolStripButton();
            Playback = new TabPage();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            macroLog = new DataGridView();
            splitContainer1 = new SplitContainer();
            toolStrip2 = new ToolStrip();
            Column1 = new DataGridViewTextBoxColumn();
            MainToolStrip.SuspendLayout();
            TabControl.SuspendLayout();
            RecordTab.SuspendLayout();
            WatchToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)macroLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            WatchToolStrip.Items.AddRange(new ToolStripItem[] { PlayButton, RecordButton, stopButton, toolStripSeparator4, insertScriptButton });
            WatchToolStrip.Location = new Point(3, 4);
            WatchToolStrip.Name = "WatchToolStrip";
            WatchToolStrip.Size = new Size(1118, 76);
            WatchToolStrip.TabIndex = 0;
            WatchToolStrip.Text = "toolStrip1";
            // 
            // PlayButton
            // 
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
            // 
            // RecordButton
            // 
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
            // stopButton
            // 
            stopButton.Font = new Font("Fira Code", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            stopButton.ForeColor = Color.Black;
            stopButton.IconChar = FontAwesome.Sharp.IconChar.Square;
            stopButton.IconColor = Color.FromArgb(13, 114, 194);
            stopButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            stopButton.ImageScaling = ToolStripItemImageScaling.None;
            stopButton.ImageTransparentColor = Color.Magenta;
            stopButton.Name = "stopButton";
            stopButton.Padding = new Padding(10, 0, 10, 0);
            stopButton.Size = new Size(72, 73);
            stopButton.Text = "Stop";
            stopButton.TextImageRelation = TextImageRelation.ImageAboveText;
            stopButton.Click += stopButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 76);
            // 
            // insertScriptButton
            // 
            insertScriptButton.Alignment = ToolStripItemAlignment.Right;
            insertScriptButton.ForeColor = Color.Black;
            insertScriptButton.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            insertScriptButton.IconColor = Color.FromArgb(0, 192, 192);
            insertScriptButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            insertScriptButton.ImageScaling = ToolStripItemImageScaling.None;
            insertScriptButton.ImageTransparentColor = Color.DarkViolet;
            insertScriptButton.Name = "insertScriptButton";
            insertScriptButton.Size = new Size(104, 73);
            insertScriptButton.Text = "Insert Script";
            insertScriptButton.TextImageRelation = TextImageRelation.ImageAboveText;
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
            macroLog.BackgroundColor = Color.FromArgb(224, 224, 224);
            macroLog.BorderStyle = BorderStyle.None;
            macroLog.CellBorderStyle = DataGridViewCellBorderStyle.None;
            macroLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            macroLog.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            macroLog.Dock = DockStyle.Fill;
            macroLog.GridColor = SystemColors.ActiveCaptionText;
            macroLog.Location = new Point(0, 0);
            macroLog.Margin = new Padding(3, 4, 3, 4);
            macroLog.Name = "macroLog";
            macroLog.RowTemplate.Height = 25;
            macroLog.Size = new Size(769, 615);
            macroLog.TabIndex = 2;
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
            splitContainer1.Panel2.Controls.Add(macroLog);
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
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.Name = "Column1";
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
        private FontAwesome.Sharp.IconToolStripButton stopButton;
        private ToolStripSeparator toolStripSeparator4;
        private FontAwesome.Sharp.IconToolStripButton insertScriptButton;
        private SplitContainer splitContainer1;
        private ToolStrip toolStrip2;
        private DataGridViewTextBoxColumn Column1;
    }
}