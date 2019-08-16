namespace Assignment05.Views
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.splashScreenPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.splashScreenTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splashScreenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenPictureBox
            // 
            this.splashScreenPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splashScreenPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.splashScreenPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splashScreenPictureBox.BackgroundImage")));
            this.splashScreenPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splashScreenPictureBox.InitialImage = null;
            this.splashScreenPictureBox.Location = new System.Drawing.Point(-4, 0);
            this.splashScreenPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.splashScreenPictureBox.Name = "splashScreenPictureBox";
            this.splashScreenPictureBox.Size = new System.Drawing.Size(1178, 733);
            this.splashScreenPictureBox.TabIndex = 0;
            this.splashScreenPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Black;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 23);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(845, 61);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Welcome to Dollar Computer Store";
            // 
            // splashScreenTimer
            // 
            this.splashScreenTimer.Interval = 3000;
            this.splashScreenTimer.Tick += new System.EventHandler(this.splashScreenTimer_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.ControlBox = false;
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.splashScreenPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splashScreenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox splashScreenPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Timer splashScreenTimer;
    }
}