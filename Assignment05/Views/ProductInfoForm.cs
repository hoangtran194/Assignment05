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

namespace Assignment05.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        public void saveFile()
        {

            string fileName = "product.txt";
                Ultilities.WriteSerialObjectToFile(fileName, Program.product);
            this.Hide();
            Program.orderForm.Show();
               
        }

        private void selectAnotherProductButton_Click(object sender, EventArgs e)
        {
            backToSelectProduct();
        }

        private void backToSelectProduct()
        {
            this.Hide();
            Program.selectForm.Show();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            updateData();

        }

        public void updateData()
        {
            Product product = Program.product;
            productIDTextBox.Text = product.productID.ToString();
            conditionTextbox.Text = product.condition;
            costTextbox.Text = "$" + Math.Round((double)product.cost, 2, MidpointRounding.ToEven).ToString();

            platformTextbox.Text = product.platform;
            osTextbox.Text = product.OS;
            manufacturerTextbox.Text = product.manufacturer;
            modelTextbox.Text = product.model;

            memoryTextbox.Text = product.RAM_size;
            lcdSizeTextbox.Text = product.screensize;
            hddTextbox.Text = product.HDD_size;
            cpuBrandTextbox.Text = product.CPU_brand;
            cpuNumberTextbox.Text = product.CPU_number;
            gpuTypeTextbox.Text = product.GPU_Type;
            cpuTypeTextbox.Text = product.CPU_type;
            cpuSpeedTextbox.Text = product.CPU_speed;
            webcamTextbox.Text = product.webcam;
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backToSelectProduct();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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
                    updateData();
                }
            }
        }
    }
}
