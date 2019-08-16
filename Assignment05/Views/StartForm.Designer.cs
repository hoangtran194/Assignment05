namespace Assignment05.Views
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveOrderButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 653);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(196, 490);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(232, 65);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveOrderButton
            // 
            this.saveOrderButton.Location = new System.Drawing.Point(196, 387);
            this.saveOrderButton.Name = "saveOrderButton";
            this.saveOrderButton.Size = new System.Drawing.Size(232, 65);
            this.saveOrderButton.TabIndex = 6;
            this.saveOrderButton.Text = "Open a Saved Order";
            this.saveOrderButton.UseVisualStyleBackColor = true;
            this.saveOrderButton.Click += new System.EventHandler(this.saveOrderButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(196, 265);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(232, 65);
            this.orderButton.TabIndex = 5;
            this.orderButton.Text = "Start a New Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(83, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(478, 33);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Welcome To Henry Computer Store";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 654);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveOrderButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveOrderButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label titleLabel;
    }
}