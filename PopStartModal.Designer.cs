namespace CTI_RPA.SYS
{
    partial class PopStartModal
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
            functionInfoGroup = new GroupBox();
            cursorPoint = new Label();
            locationLabel = new Label();
            functionName = new TextBox();
            groupBox1 = new GroupBox();
            descriptionField = new TextBox();
            saveBtn = new Button();
            functionInfoGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // functionInfoGroup
            // 
            functionInfoGroup.Controls.Add(cursorPoint);
            functionInfoGroup.Controls.Add(locationLabel);
            functionInfoGroup.Controls.Add(functionName);
            functionInfoGroup.Location = new Point(12, 28);
            functionInfoGroup.Name = "functionInfoGroup";
            functionInfoGroup.Size = new Size(503, 57);
            functionInfoGroup.TabIndex = 0;
            functionInfoGroup.TabStop = false;
            functionInfoGroup.Text = "Function Info";
            // 
            // cursorPoint
            // 
            cursorPoint.AutoSize = true;
            cursorPoint.Location = new Point(388, 25);
            cursorPoint.Name = "cursorPoint";
            cursorPoint.Size = new Size(33, 15);
            cursorPoint.TabIndex = 2;
            cursorPoint.Text = "(0, 0)";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(316, 25);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(56, 15);
            locationLabel.TabIndex = 1;
            locationLabel.Text = "Location:";
            // 
            // functionName
            // 
            functionName.Location = new Point(19, 22);
            functionName.Name = "functionName";
            functionName.Size = new Size(233, 23);
            functionName.TabIndex = 0;
            functionName.Text = "Function Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(descriptionField);
            groupBox1.Location = new Point(12, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 185);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Function Description";
            // 
            // descriptionField
            // 
            descriptionField.Location = new Point(19, 22);
            descriptionField.Multiline = true;
            descriptionField.Name = "descriptionField";
            descriptionField.Size = new Size(478, 148);
            descriptionField.TabIndex = 0;
            // 
            // saveBtn
            // 
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Location = new Point(429, 292);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(86, 34);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Add";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // PopStartModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 338);
            Controls.Add(saveBtn);
            Controls.Add(groupBox1);
            Controls.Add(functionInfoGroup);
            Name = "PopStartModal";
            Text = "PopStartModal";
            Load += PopStartModal_Load;
            functionInfoGroup.ResumeLayout(false);
            functionInfoGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox functionInfoGroup;
        private Label cursorPoint;
        private Label locationLabel;
        private TextBox functionName;
        private GroupBox groupBox1;
        private TextBox descriptionField;
        private Button saveBtn;
    }
}