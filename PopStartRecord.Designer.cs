namespace CTI_RPA.SYS
{
    partial class PopStartRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopStartRecord));
            StartButton = new Button();
            CancelButton = new Button();
            QuestionLabel = new Label();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.FromArgb(101, 239, 67);
            resources.ApplyResources(StartButton, "StartButton");
            StartButton.Name = "StartButton";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.ControlLight;
            resources.ApplyResources(CancelButton, "CancelButton");
            CancelButton.Name = "CancelButton";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // QuestionLabel
            // 
            resources.ApplyResources(QuestionLabel, "QuestionLabel");
            QuestionLabel.ForeColor = SystemColors.ButtonFace;
            QuestionLabel.Name = "QuestionLabel";
            // 
            // PopStartRecord
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 61, 86);
            Controls.Add(QuestionLabel);
            Controls.Add(CancelButton);
            Controls.Add(StartButton);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "PopStartRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button CancelButton;
        private Label QuestionLabel;
    }
}