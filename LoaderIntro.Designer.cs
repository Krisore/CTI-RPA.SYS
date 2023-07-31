using System.ComponentModel;
using Timer = System.Windows.Forms.Timer;

namespace CTI_RPA.SYS;

partial class LoaderIntro
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;
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
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaderIntro));
        this.LoadingLabel = new System.Windows.Forms.Label();
        this.LoadingBar = new System.Windows.Forms.Panel();
        this.filled = new System.Windows.Forms.Panel();
        this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
        this.ownerLabel = new System.Windows.Forms.Label();
        this.versionLabel = new System.Windows.Forms.Label();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.LoadingBar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // LoadingLabel
        // 
        this.LoadingLabel.AutoSize = true;
        this.LoadingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(168)))), ((int)(((byte)(38)))));
        this.LoadingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.LoadingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.LoadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.LoadingLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
        this.LoadingLabel.Location = new System.Drawing.Point(43, 83);
        this.LoadingLabel.Name = "LoadingLabel";
        this.LoadingLabel.Size = new System.Drawing.Size(369, 33);
        this.LoadingLabel.TabIndex = 0;
        this.LoadingLabel.Text = "Robotics Process Application";
        this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LoadingBar
        // 
        this.LoadingBar.Controls.Add(this.filled);
        this.LoadingBar.Location = new System.Drawing.Point(0, 567);
        this.LoadingBar.Name = "LoadingBar";
        this.LoadingBar.Size = new System.Drawing.Size(466, 22);
        this.LoadingBar.TabIndex = 1;
        // 
        // filled
        // 
        this.filled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        this.filled.Location = new System.Drawing.Point(0, 0);
        this.filled.Name = "filled";
        this.filled.Size = new System.Drawing.Size(51, 29);
        this.filled.TabIndex = 0;
        // 
        // LoadingTimer
        // 
        this.LoadingTimer.Enabled = true;
        this.LoadingTimer.Interval = 15;
        this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick_1);
        // 
        // ownerLabel
        // 
        this.ownerLabel.AutoSize = true;
        this.ownerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
        this.ownerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.ownerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.ownerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
        this.ownerLabel.Location = new System.Drawing.Point(43, 48);
        this.ownerLabel.Name = "ownerLabel";
        this.ownerLabel.Size = new System.Drawing.Size(195, 18);
        this.ownerLabel.TabIndex = 2;
        this.ownerLabel.Text = "Corporate Technologies Inc.";
        // 
        // versionLabel
        // 
        this.versionLabel.AutoSize = true;
        this.versionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
        this.versionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.versionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
        this.versionLabel.Location = new System.Drawing.Point(341, 127);
        this.versionLabel.Name = "versionLabel";
        this.versionLabel.Size = new System.Drawing.Size(71, 16);
        this.versionLabel.TabIndex = 3;
        this.versionLabel.Text = "version 1.0";
        // 
        // pictureBox1
        // 
        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        this.pictureBox1.Location = new System.Drawing.Point(12, 173);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(442, 388);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pictureBox1.TabIndex = 4;
        this.pictureBox1.TabStop = false;
        // 
        // LoaderIntro
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(466, 590);
        this.Controls.Add(this.LoadingLabel);
        this.Controls.Add(this.versionLabel);
        this.Controls.Add(this.ownerLabel);
        this.Controls.Add(this.LoadingBar);
        this.Controls.Add(this.pictureBox1);
        this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        this.Name = "LoaderIntro";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "LoaderIntro";
        this.LoadingBar.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion
    private Label LoadingLabel;
    private Panel LoadingBar;
    private Panel filled;
    private Timer LoadingTimer;
    private Label ownerLabel;
    private Label versionLabel;
    private PictureBox pictureBox1;
}
