namespace CTI_RPA.SYS
{
    partial class PopCreateScript
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopCreateScript));
            toolGroupBox = new GroupBox();
            scriptDirectoryBtn = new Button();
            scriptDirectory = new TextBox();
            insertScriptBtn = new Button();
            addStepBtn = new Button();
            createScriptBtn = new Button();
            functionsGroup = new GroupBox();
            watchToolStrip = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton6 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            listBox1 = new ListBox();
            toolGroupBox.SuspendLayout();
            functionsGroup.SuspendLayout();
            watchToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // toolGroupBox
            // 
            toolGroupBox.Controls.Add(scriptDirectoryBtn);
            toolGroupBox.Controls.Add(scriptDirectory);
            toolGroupBox.Font = new Font("Fira Code", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            toolGroupBox.Location = new Point(27, 30);
            toolGroupBox.Name = "toolGroupBox";
            toolGroupBox.Size = new Size(1021, 66);
            toolGroupBox.TabIndex = 0;
            toolGroupBox.TabStop = false;
            toolGroupBox.Text = "Directory";
            // 
            // scriptDirectoryBtn
            // 
            scriptDirectoryBtn.Cursor = Cursors.Hand;
            scriptDirectoryBtn.FlatStyle = FlatStyle.Flat;
            scriptDirectoryBtn.Location = new Point(938, 20);
            scriptDirectoryBtn.Name = "scriptDirectoryBtn";
            scriptDirectoryBtn.Size = new Size(63, 35);
            scriptDirectoryBtn.TabIndex = 2;
            scriptDirectoryBtn.Text = "...";
            scriptDirectoryBtn.UseVisualStyleBackColor = true;
            scriptDirectoryBtn.Click += scriptDirectoryBtn_Click;
            // 
            // scriptDirectory
            // 
            scriptDirectory.BorderStyle = BorderStyle.FixedSingle;
            scriptDirectory.Cursor = Cursors.Hand;
            scriptDirectory.Location = new Point(31, 23);
            scriptDirectory.Name = "scriptDirectory";
            scriptDirectory.Size = new Size(885, 27);
            scriptDirectory.TabIndex = 0;
            // 
            // insertScriptBtn
            // 
            insertScriptBtn.FlatStyle = FlatStyle.Flat;
            insertScriptBtn.Location = new Point(841, 38);
            insertScriptBtn.Name = "insertScriptBtn";
            insertScriptBtn.Size = new Size(124, 35);
            insertScriptBtn.TabIndex = 3;
            insertScriptBtn.Text = "Insert Script";
            insertScriptBtn.UseVisualStyleBackColor = true;
            // 
            // addStepBtn
            // 
            addStepBtn.Cursor = Cursors.Hand;
            addStepBtn.FlatStyle = FlatStyle.Flat;
            addStepBtn.Font = new Font("Fira Code", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            addStepBtn.Location = new Point(31, 38);
            addStepBtn.Name = "addStepBtn";
            addStepBtn.Size = new Size(106, 35);
            addStepBtn.TabIndex = 1;
            addStepBtn.Text = "Add Step ";
            addStepBtn.UseVisualStyleBackColor = true;
            addStepBtn.Click += addFunctionBtn_Click;
            // 
            // createScriptBtn
            // 
            createScriptBtn.Cursor = Cursors.Hand;
            createScriptBtn.FlatStyle = FlatStyle.Flat;
            createScriptBtn.Font = new Font("Fira Code", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            createScriptBtn.Location = new Point(912, 653);
            createScriptBtn.Name = "createScriptBtn";
            createScriptBtn.Size = new Size(133, 41);
            createScriptBtn.TabIndex = 1;
            createScriptBtn.Text = "Save";
            createScriptBtn.UseVisualStyleBackColor = true;
            // 
            // functionsGroup
            // 
            functionsGroup.Controls.Add(insertScriptBtn);
            functionsGroup.Controls.Add(watchToolStrip);
            functionsGroup.Controls.Add(listBox1);
            functionsGroup.Controls.Add(addStepBtn);
            functionsGroup.Font = new Font("Fira Code", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            functionsGroup.Location = new Point(27, 132);
            functionsGroup.Name = "functionsGroup";
            functionsGroup.Size = new Size(1021, 504);
            functionsGroup.TabIndex = 3;
            functionsGroup.TabStop = false;
            functionsGroup.Text = "Functions";
            // 
            // watchToolStrip
            // 
            watchToolStrip.Dock = DockStyle.Right;
            watchToolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripSeparator2, toolStripButton6, toolStripSeparator3 });
            watchToolStrip.Location = new Point(994, 24);
            watchToolStrip.Name = "watchToolStrip";
            watchToolStrip.Size = new Size(24, 477);
            watchToolStrip.TabIndex = 2;
            watchToolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(21, 20);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.BackColor = SystemColors.ActiveCaptionText;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(21, 6);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(21, 20);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(21, 20);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(21, 20);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            toolStripButton5.Alignment = ToolStripItemAlignment.Right;
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(21, 20);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.ForeColor = SystemColors.ActiveCaptionText;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(21, 6);
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(21, 20);
            toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.BackColor = SystemColors.ActiveCaptionText;
            toolStripSeparator3.ForeColor = SystemColors.ActiveCaptionText;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(21, 6);
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(31, 92);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(934, 379);
            listBox1.TabIndex = 0;
            // 
            // PopCreateScript
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 706);
            Controls.Add(functionsGroup);
            Controls.Add(toolGroupBox);
            Controls.Add(createScriptBtn);
            Name = "PopCreateScript";
            Text = "CreateScript";
            Activated += PopCreateScript_Activated;
            Load += PopCreateScript_Load;
            toolGroupBox.ResumeLayout(false);
            toolGroupBox.PerformLayout();
            functionsGroup.ResumeLayout(false);
            functionsGroup.PerformLayout();
            watchToolStrip.ResumeLayout(false);
            watchToolStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox toolGroupBox;
        private TextBox scriptDirectory;
        private Button scriptDirectoryBtn;
        private Button createScriptBtn;
        private GroupBox functionsGroup;
        private Button addStepBtn;
        private ListBox listBox1;
        private ToolStrip watchToolStrip;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator3;
        private Button insertScriptBtn;
    }
}