using Assignment05.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBoxForm.ShowDialog();
        
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView gridview = sender as DataGridView;
            var rowIndex = gridview.CurrentCell.RowIndex;
            var rows = gridview.Rows;
            var columnCount = gridview.ColumnCount;
            var cells = rows[rowIndex].Cells;

            rows[rowIndex].Selected = true;

            string outputString = string.Empty;

            if (Program.product == null)
            {
                Program.product = new Product();
            }

            Program.product.productID       = short.Parse(cells[(int)ProductField.PRODUCT_ID].Value.ToString());
            Program.product.cost            = decimal.Parse(cells[(int)ProductField.COST].Value.ToString());
            Program.product.manufacturer    = cells[(int)ProductField.MANUFACTURER].Value.ToString();
            Program.product.model           = cells[(int)ProductField.MODEL].Value.ToString();
            Program.product.RAM_type        = cells[(int)ProductField.RAM_TYPE].Value.ToString();
            Program.product.RAM_size        = cells[(int)ProductField.RAM_SIZE].Value.ToString();
            Program.product.displaytype     = cells[(int)ProductField.DISPLAY_TYPE].Value.ToString();
            Program.product.screensize      = cells[(int)ProductField.SCREEN_SIZE].Value.ToString();
            Program.product.resolution      = cells[(int)ProductField.RESOLUTION].Value.ToString();
            Program.product.CPU_Class       = cells[(int)ProductField.CPU_CLASS].Value.ToString();
            Program.product.CPU_type        = cells[(int)ProductField.CPU_TYPE].Value.ToString();
            Program.product.CPU_brand       = cells[(int)ProductField.CPU_BRANDS].Value.ToString();
            Program.product.CPU_speed       = cells[(int)ProductField.CPU_SPEED].Value.ToString();
            Program.product.CPU_number      = cells[(int)ProductField.CPU_NUMBER].Value.ToString();
            Program.product.condition       = cells[(int)ProductField.CONDITION].Value.ToString();
            Program.product.OS              = cells[(int)ProductField.OS].Value.ToString();
            Program.product.platform        = cells[(int)ProductField.PLATFORM].Value.ToString();
            Program.product.HDD_size        = cells[(int)ProductField.HDD_SIZE].Value.ToString();
            Program.product.HDD_speed       = cells[(int)ProductField.HDD_SPEED].Value.ToString();
            Program.product.GPU_Type        = cells[(int)ProductField.GPU_TYPE].Value.ToString();
            Program.product.optical_drive   = cells[(int)ProductField.OPTICAL_DRIVE].Value.ToString();
            Program.product.Audio_type      = cells[(int)ProductField.AUDIO_TYPE].Value.ToString();
            Program.product.LAN             = cells[(int)ProductField.LAN].Value.ToString();
            Program.product.WIFI            = cells[(int)ProductField.WIFI].Value.ToString();
            Program.product.width           = cells[(int)ProductField.WIDTH].Value.ToString();
            Program.product.height          = cells[(int)ProductField.HEIGHT].Value.ToString();
            Program.product.depth           = cells[(int)ProductField.DEPTH].Value.ToString();
            Program.product.weight          = cells[(int)ProductField.WEIGHT].Value.ToString();
            Program.product.moust_type      = cells[(int)ProductField.MOUST_TYPE].Value.ToString();
            Program.product.power           = cells[(int)ProductField.POWER].Value.ToString();
            Program.product.webcam          = cells[(int)ProductField.WEBCAM].Value.ToString();

            Product product = Program.product;

            selectionTextBox.Text = product.manufacturer + " " + product.model + " Price at: $" + Math.Round((double)product.cost,2, MidpointRounding.ToEven);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfo.Show();
            Program.productInfo.updateData();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.startForm.Show();
        }
    }
}
