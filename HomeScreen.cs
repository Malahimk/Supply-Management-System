using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;


namespace sms
{
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();

        }
        




        private void HomeScreen_Load(object sender, EventArgs e)
        {
            userlabel.Text = Retrieval.EMP_NAME;
            MDI obj = new MDI();
            obj.logOutToolStripMenuItem.Enabled = true;
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
           // Users u = new Users();
            //MainClass.showWindow(u, this,MDI.ActiveForm);

            Users u = new Users();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            products u = new products();
            MainClass.showWindow(u, this, MDI.ActiveForm);

        }

        private void catBtn_Click(object sender, EventArgs e)
        {

            categories u = new categories();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Supplier u = new Supplier();
            MainClass.showWindow(u, this, MDI.ActiveForm);


        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            Purchase_Invoice u = new Purchase_Invoice();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            Stocks u = new Stocks();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            Sales u = new Sales();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void priceBtn_Click(object sender, EventArgs e)
        {
            ProductPricing u = new ProductPricing();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalesReturnWindow u = new SalesReturnWindow();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            login u = new login();
            MainClass.showWindow(u,this,MDI.ActiveForm);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void userlabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void Web_Click(object sender, EventArgs e)
        {
            Web u = new Web();
            MainClass.showWindow(u, this, MDI.ActiveForm);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Calculator u = new Calculator();
            MainClass.showWindow(u, this, MDI.ActiveForm);


        }
    }
}
