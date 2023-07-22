namespace CTI_RPA.SYS
{
    partial class LoaderIntro
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaderIntro));
            LoadingLabel = new Label();
            LoadingBar = new Panel();
            filled = new Panel();
            LoadingTimer = new System.Windows.Forms.Timer(components);
            ownerLabel = new Label();
            versionLabel = new Label();
            pictureBox1 = new PictureBox();
            LoadingBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoadingLabel
            // 
            LoadingLabel.AutoSize = true;
            LoadingLabel.BackColor = Color.FromArgb(249, 168, 38);
            LoadingLabel.BorderStyle = BorderStyle.FixedSingle;
            LoadingLabel.FlatStyle = FlatStyle.Flat;
            LoadingLabel.Font = new Font("Fira Code", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoadingLabel.ForeColor = Color.WhiteSmoke;
            LoadingLabel.Location = new Point(0, 93);
            LoadingLabel.Name = "LoadingLabel";
            LoadingLabel.Size = new Size(469, 45);
            LoadingLabel.TabIndex = 0;
            LoadingLabel.Text = "Robotics Process Application";
            LoadingLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoadingBar
            // 
            LoadingBar.Controls.Add(filled);
            LoadingBar.Location = new Point(0, 567);
            LoadingBar.Name = "LoadingBar";
            LoadingBar.Size = new Size(466, 22);
            LoadingBar.TabIndex = 1;
            // 
            // filled
            // 
            filled.BackColor = Color.FromArgb(128, 255, 128);
            filled.Location = new Point(0, 0);
            filled.Name = "filled";
            filled.Size = new Size(51, 29);
            filled.TabIndex = 0;
            // 
            // LoadingTimer
            // 
            LoadingTimer.Enabled = true;
            LoadingTimer.Interval = 15;
            LoadingTimer.Tick += LoadingTimer_Tick;
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.BackColor = Color.FromArgb(63, 61, 86);
            ownerLabel.FlatStyle = FlatStyle.Flat;
            ownerLabel.Font = new Font("Fira Code", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            ownerLabel.ForeColor = Color.WhiteSmoke;
            ownerLabel.Location = new Point(0, 60);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new Size(253, 24);
            ownerLabel.TabIndex = 2;
            ownerLabel.Text = "Corporate Technologies Inc.";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.BackColor = Color.FromArgb(63, 61, 86);
            versionLabel.FlatStyle = FlatStyle.Flat;
            versionLabel.Font = new Font("Fira Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            versionLabel.ForeColor = Color.WhiteSmoke;
            versionLabel.Location = new Point(368, 148);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(98, 21);
            versionLabel.TabIndex = 3;
            versionLabel.Text = "version 1.0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 238);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // LoaderIntro
            // 
            AutoScaleDimensions = new SizeF(7F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(466, 590);
            Controls.Add(versionLabel);
            Controls.Add(ownerLabel);
            Controls.Add(LoadingBar);
            Controls.Add(LoadingLabel);
            Controls.Add(pictureBox1);
            Font = new Font("Fira Code", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoaderIntro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoaderIntro";
            Load += LoaderIntro_Load;
            LoadingBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoadingLabel;
        private Panel LoadingBar;
        private Panel filled;
        private System.Windows.Forms.Timer LoadingTimer;
        private Label ownerLabel;
        private Label versionLabel;
        private PictureBox pictureBox1;
    }
}