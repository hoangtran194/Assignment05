namespace Assignment05.Views
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.conditionTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.platformTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.modelTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.manufactureTextBox = new System.Windows.Forms.TextBox();
            this.lcdSizeTextbox = new System.Windows.Forms.TextBox();
            this.memoryTextbox = new System.Windows.Forms.TextBox();
            this.cpuBrandTextbox = new System.Windows.Forms.TextBox();
            this.cpuTypeTextbox = new System.Windows.Forms.TextBox();
            this.cpuNumberTextbox = new System.Windows.Forms.TextBox();
            this.cpuSpeedTextbox = new System.Windows.Forms.TextBox();
            this.hddTextbox = new System.Windows.Forms.TextBox();
            this.gpuTypeTextbox = new System.Windows.Forms.TextBox();
            this.webcamTextbox = new System.Windows.Forms.TextBox();
            this.osTextbox = new System.Windows.Forms.TextBox();
            this.computerPicturebox = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.saleTaxTextbox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.totalTextbox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 38);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "System Components";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Condition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufacturer";
            // 
            // conditionTextbox
            // 
            this.conditionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionTextbox.Location = new System.Drawing.Point(199, 106);
            this.conditionTextbox.Name = "conditionTextbox";
            this.conditionTextbox.Size = new System.Drawing.Size(406, 38);
            this.conditionTextbox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(666, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Platform";
            // 
            // platformTextbox
            // 
            this.platformTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformTextbox.Location = new System.Drawing.Point(787, 107);
            this.platformTextbox.Name = "platformTextbox";
            this.platformTextbox.Size = new System.Drawing.Size(406, 38);
            this.platformTextbox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(694, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Model";
            // 
            // modelTextbox
            // 
            this.modelTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextbox.Location = new System.Drawing.Point(787, 172);
            this.modelTextbox.Name = "modelTextbox";
            this.modelTextbox.Size = new System.Drawing.Size(406, 38);
            this.modelTextbox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "LCD Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "Memory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 31);
            this.label8.TabIndex = 2;
            this.label8.Text = "CPU Brand";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 31);
            this.label9.TabIndex = 2;
            this.label9.Text = "CPU Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 31);
            this.label10.TabIndex = 2;
            this.label10.Text = "CPU Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 531);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 31);
            this.label11.TabIndex = 2;
            this.label11.Text = "CPU Speed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(113, 592);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 31);
            this.label12.TabIndex = 2;
            this.label12.Text = "HDD";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(52, 647);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 31);
            this.label13.TabIndex = 2;
            this.label13.Text = "GPU Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(73, 699);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 31);
            this.label14.TabIndex = 2;
            this.label14.Text = "Webcam";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(134, 749);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 31);
            this.label15.TabIndex = 2;
            this.label15.Text = "OS";
            // 
            // manufactureTextBox
            // 
            this.manufactureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufactureTextBox.Location = new System.Drawing.Point(199, 165);
            this.manufactureTextBox.Name = "manufactureTextBox";
            this.manufactureTextBox.Size = new System.Drawing.Size(406, 38);
            this.manufactureTextBox.TabIndex = 3;
            // 
            // lcdSizeTextbox
            // 
            this.lcdSizeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcdSizeTextbox.Location = new System.Drawing.Point(199, 226);
            this.lcdSizeTextbox.Name = "lcdSizeTextbox";
            this.lcdSizeTextbox.Size = new System.Drawing.Size(406, 38);
            this.lcdSizeTextbox.TabIndex = 3;
            // 
            // memoryTextbox
            // 
            this.memoryTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryTextbox.Location = new System.Drawing.Point(199, 282);
            this.memoryTextbox.Name = "memoryTextbox";
            this.memoryTextbox.Size = new System.Drawing.Size(406, 38);
            this.memoryTextbox.TabIndex = 3;
            // 
            // cpuBrandTextbox
            // 
            this.cpuBrandTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuBrandTextbox.Location = new System.Drawing.Point(199, 341);
            this.cpuBrandTextbox.Name = "cpuBrandTextbox";
            this.cpuBrandTextbox.Size = new System.Drawing.Size(406, 38);
            this.cpuBrandTextbox.TabIndex = 3;
            // 
            // cpuTypeTextbox
            // 
            this.cpuTypeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTypeTextbox.Location = new System.Drawing.Point(199, 402);
            this.cpuTypeTextbox.Name = "cpuTypeTextbox";
            this.cpuTypeTextbox.Size = new System.Drawing.Size(406, 38);
            this.cpuTypeTextbox.TabIndex = 3;
            // 
            // cpuNumberTextbox
            // 
            this.cpuNumberTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuNumberTextbox.Location = new System.Drawing.Point(199, 467);
            this.cpuNumberTextbox.Name = "cpuNumberTextbox";
            this.cpuNumberTextbox.Size = new System.Drawing.Size(406, 38);
            this.cpuNumberTextbox.TabIndex = 3;
            // 
            // cpuSpeedTextbox
            // 
            this.cpuSpeedTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuSpeedTextbox.Location = new System.Drawing.Point(199, 531);
            this.cpuSpeedTextbox.Name = "cpuSpeedTextbox";
            this.cpuSpeedTextbox.Size = new System.Drawing.Size(406, 38);
            this.cpuSpeedTextbox.TabIndex = 3;
            // 
            // hddTextbox
            // 
            this.hddTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddTextbox.Location = new System.Drawing.Point(199, 589);
            this.hddTextbox.Name = "hddTextbox";
            this.hddTextbox.Size = new System.Drawing.Size(406, 38);
            this.hddTextbox.TabIndex = 3;
            // 
            // gpuTypeTextbox
            // 
            this.gpuTypeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuTypeTextbox.Location = new System.Drawing.Point(199, 644);
            this.gpuTypeTextbox.Name = "gpuTypeTextbox";
            this.gpuTypeTextbox.Size = new System.Drawing.Size(406, 38);
            this.gpuTypeTextbox.TabIndex = 3;
            // 
            // webcamTextbox
            // 
            this.webcamTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webcamTextbox.Location = new System.Drawing.Point(199, 699);
            this.webcamTextbox.Name = "webcamTextbox";
            this.webcamTextbox.Size = new System.Drawing.Size(406, 38);
            this.webcamTextbox.TabIndex = 3;
            // 
            // osTextbox
            // 
            this.osTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osTextbox.Location = new System.Drawing.Point(199, 749);
            this.osTextbox.Name = "osTextbox";
            this.osTextbox.Size = new System.Drawing.Size(406, 38);
            this.osTextbox.TabIndex = 3;
            // 
            // computerPicturebox
            // 
            this.computerPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("computerPicturebox.Image")));
            this.computerPicturebox.Location = new System.Drawing.Point(892, 251);
            this.computerPicturebox.Name = "computerPicturebox";
            this.computerPicturebox.Size = new System.Drawing.Size(131, 137);
            this.computerPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerPicturebox.TabIndex = 4;
            this.computerPicturebox.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(705, 443);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 31);
            this.label16.TabIndex = 2;
            this.label16.Text = "Price";
            // 
            // priceTextbox
            // 
            this.priceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextbox.Location = new System.Drawing.Point(787, 443);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(406, 38);
            this.priceTextbox.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(647, 522);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 31);
            this.label17.TabIndex = 2;
            this.label17.Text = "Sales Tax";
            // 
            // saleTaxTextbox
            // 
            this.saleTaxTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleTaxTextbox.Location = new System.Drawing.Point(787, 519);
            this.saleTaxTextbox.Name = "saleTaxTextbox";
            this.saleTaxTextbox.Size = new System.Drawing.Size(406, 38);
            this.saleTaxTextbox.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(706, 599);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 31);
            this.label18.TabIndex = 2;
            this.label18.Text = "Total";
            // 
            // totalTextbox
            // 
            this.totalTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextbox.Location = new System.Drawing.Point(787, 596);
            this.totalTextbox.Name = "totalTextbox";
            this.totalTextbox.Size = new System.Drawing.Size(406, 38);
            this.totalTextbox.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(927, 687);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(118, 37);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(777, 687);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(118, 37);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.Location = new System.Drawing.Point(1075, 687);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(118, 37);
            this.finishButton.TabIndex = 8;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 789);
            this.ControlBox = false;
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.computerPicturebox);
            this.Controls.Add(this.osTextbox);
            this.Controls.Add(this.webcamTextbox);
            this.Controls.Add(this.gpuTypeTextbox);
            this.Controls.Add(this.hddTextbox);
            this.Controls.Add(this.cpuSpeedTextbox);
            this.Controls.Add(this.cpuNumberTextbox);
            this.Controls.Add(this.cpuTypeTextbox);
            this.Controls.Add(this.cpuBrandTextbox);
            this.Controls.Add(this.memoryTextbox);
            this.Controls.Add(this.lcdSizeTextbox);
            this.Controls.Add(this.manufactureTextBox);
            this.Controls.Add(this.totalTextbox);
            this.Controls.Add(this.saleTaxTextbox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.modelTextbox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.platformTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.conditionTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.Load += new System.EventHandler(this.ProductInfoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox conditionTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox platformTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox modelTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox manufactureTextBox;
        private System.Windows.Forms.TextBox lcdSizeTextbox;
        private System.Windows.Forms.TextBox memoryTextbox;
        private System.Windows.Forms.TextBox cpuBrandTextbox;
        private System.Windows.Forms.TextBox cpuTypeTextbox;
        private System.Windows.Forms.TextBox cpuNumberTextbox;
        private System.Windows.Forms.TextBox cpuSpeedTextbox;
        private System.Windows.Forms.TextBox hddTextbox;
        private System.Windows.Forms.TextBox gpuTypeTextbox;
        private System.Windows.Forms.TextBox webcamTextbox;
        private System.Windows.Forms.TextBox osTextbox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox saleTaxTextbox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox totalTextbox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.PictureBox computerPicturebox;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}