using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment05.Models;
using Assignment05.Views;

namespace Assignment05
{
    public static class Program
    {
        public static AboutForm         aboutForm;          //About the program
        public static ProductInfoForm         productInfo;          //Order a new product form
        public static OrderForm   orderForm;    //Product detail form
        public static SelectForm        selectForm; //Select product form
        public static SplashForm        splashForm; //The flash screen
        public static StartForm         startForm;  //The option form
        public static AboutBoxForm      aboutBoxForm;

        public static Product product;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //product = new Product();


            aboutForm       = new AboutForm();
            productInfo = new ProductInfoForm();
            orderForm = new OrderForm();
            selectForm      = new SelectForm();
            splashForm      = new SplashForm();
            startForm       = new StartForm();
            aboutBoxForm    = new AboutBoxForm();

            Application.Run(splashForm);
            

        }
    }
}
