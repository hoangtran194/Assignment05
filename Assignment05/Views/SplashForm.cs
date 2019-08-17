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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();           
        }

        private void splashScreenTimer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            splashScreenTimer.Enabled = false;
            Program.startForm.Show();            
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            splashScreenTimer.Enabled = true;
        }
    }
}
