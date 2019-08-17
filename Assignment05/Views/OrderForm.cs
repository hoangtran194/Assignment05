using Assignment05.Models;
using FinalTestA.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Name: Tran Huy Hoang
/// ID: 300 979 272
/// </summary>
namespace Assignment05.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            
        }

        private void LoadData()
        {
            Product product = Program.product;

            if (product != null)
            {
                conditionTextbox.Text = product.condition;
                platformTextbox.Text = product.platform;
                manufactureTextBox.Text = product.manufacturer;
                modelTextbox.Text = product.model;

                lcdSizeTextbox.Text = product.screensize;
                memoryTextbox.Text = product.RAM_size;
                cpuBrandTextbox.Text = product.CPU_brand;
                cpuTypeTextbox.Text = product.CPU_type;
                cpuNumberTextbox.Text = product.CPU_number;
                cpuSpeedTextbox.Text = product.CPU_speed;
                hddTextbox.Text = product.HDD_size;
                gpuTypeTextbox.Text = product.GPU_Type;
                webcamTextbox.Text = product.webcam;
                osTextbox.Text = product.OS;

                priceTextbox.Text = Math.Round((double)product.cost, 2, MidpointRounding.ToEven).ToString();
                saleTaxTextbox.Text = Math.Round((double)product.cost * .13, 2, MidpointRounding.ToEven).ToString();
                totalTextbox.Text = Math.Round((double)product.cost * 1.13, 2, MidpointRounding.ToEven).ToString();

                //set the image

                if (product.platform.ToLower() == "laptop")
                {
                    computerPicturebox.Image = Image.FromFile("../../Resources/LaptopImage.png");
                }
                else
                {
                    computerPicturebox.Image = Image.FromFile("../../Resources/DesktopImage.png");
                }

                computerPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thank for ordering this item, the item will be delivered in 7-10 business days", "", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadFile();
        }

        public void loadFile()
        {
            string filePath = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\Results\\");
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                //openFileDialog.FilterIndex = 2;
                //openFileDialog.RestoreDirectory = true;
                //openFileDialog.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    Product product = Ultilities.ReadSerializedObjectFile<Product>(filePath);
                    Program.product = product;
                    LoadData();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\Results");

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            //saveFileDialog1.InitialDirectory = CombinedPath;
            saveFileDialog1.FileName = "Product.txt";
            //saveFileDialog1.InitialDirectory = "C:\\Users\\";
            //saveFileDialog1.InitialDirectory = "..\\..\\Results";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                Ultilities.WriteSerialObjectToFile(fileName, Program.product);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBoxForm.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your item description is printting");
        }


        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            loadFile();
        }
    }
}
