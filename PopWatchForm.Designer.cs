namespace CTI_RPA.SYS
{
    partial class PopWatchForm
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
            label1 = new Label();
            sourceGroup = new GroupBox();
            directoryBtn = new Button();
            directoryTextBox = new TextBox();
            groupButtonSave = new GroupBox();
            save_btn = new Button();
            sourceGroup.SuspendLayout();
            groupButtonSave.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Fira Code", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(128, 237);
            label1.Name = "label1";
            label1.Size = new Size(177, 76);
            label1.TabIndex = 0;
            label1.Text = "Hello";
            // 
            // sourceGroup
            // 
            sourceGroup.Controls.Add(directoryBtn);
            sourceGroup.Controls.Add(directoryTextBox);
            sourceGroup.Location = new Point(12, 12);
            sourceGroup.Name = "sourceGroup";
            sourceGroup.Size = new Size(437, 59);
            sourceGroup.TabIndex = 1;
            sourceGroup.TabStop = false;
            sourceGroup.Text = "Data Source";
            // 
            // directoryBtn
            // 
            directoryBtn.BackColor = Color.FromArgb(224, 224, 224);
            directoryBtn.Location = new Point(388, 22);
            directoryBtn.Name = "directoryBtn";
            directoryBtn.Size = new Size(37, 23);
            directoryBtn.TabIndex = 1;
            directoryBtn.Text = "...";
            directoryBtn.UseVisualStyleBackColor = false;
            directoryBtn.Click += directoryBtn_Click;
            // 
            // directoryTextBox
            // 
            directoryTextBox.BorderStyle = BorderStyle.FixedSingle;
            directoryTextBox.Location = new Point(15, 22);
            directoryTextBox.Name = "directoryTextBox";
            directoryTextBox.Size = new Size(367, 23);
            directoryTextBox.TabIndex = 0;
            // 
            // groupButtonSave
            // 
            groupButtonSave.Controls.Add(save_btn);
            groupButtonSave.Location = new Point(12, 471);
            groupButtonSave.Name = "groupButtonSave";
            groupButtonSave.Size = new Size(431, 44);
            groupButtonSave.TabIndex = 1;
            groupButtonSave.TabStop = false;
            groupButtonSave.Text = "Action";
            // 
            // save_btn
            // 
            save_btn.BackColor = SystemColors.ButtonHighlight;
            save_btn.Location = new Point(350, 15);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(75, 23);
            save_btn.TabIndex = 0;
            save_btn.Text = "Proceed";
            save_btn.UseVisualStyleBackColor = false;
            // 
            // PopWatchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 527);
            Controls.Add(groupButtonSave);
            Controls.Add(sourceGroup);
            Controls.Add(label1);
            Name = "PopWatchForm";
            Text = "Watch Form";
            sourceGroup.ResumeLayout(false);
            sourceGroup.PerformLayout();
            groupButtonSave.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox sourceGroup;
        private TextBox directoryTextBox;
        private GroupBox groupButtonSave;
        private Button save_btn;
        private Button directoryBtn;
    }
}