using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sms
{
    public partial class SalesReturnWindow : Sample2
    {
        public SalesReturnWindow()
        {
            InitializeComponent();
        }

        Retrieval r = new Retrieval();
        Regex rg = new Regex("^[0-9]+$");   
        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (salesIDTxt.Text != "")
            {
                if (rg.Match(salesIDTxt.Text).Success)
                {
                    r.showSalesDataViaID(Convert.ToInt64(salesIDTxt.Text), dataGridView1, saleidgv,barcodegv,productgv,quantitygv,pricegv
                        , productdiscgv, perprototalgv,totaldisgv,totAmountGV,amountgivengv,amountreturnedgv,
                        dategv,usergv,paygv,proIDGV);

                   foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                       row.Cells["pricegv"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["pricegv"].Value));
                       row.Cells["productdiscgv"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["productdiscgv"].Value));
                       row.Cells["perprototalgv"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["perprototalgv"].Value));
                    }


                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells["dateGV"].Value);
                    usertxt.Text = dataGridView1.Rows[0].Cells["usergv"].Value.ToString();
                    paytypetxt.Text = dataGridView1.Rows[0].Cells["paygv"].Value.ToString();
                    amtgivenTxt.Text = dataGridView1.Rows[0].Cells["amountgivengv"].Value.ToString();
                    totdisctxt.Text = Math.Ceiling(Convert.ToSingle(dataGridView1.Rows[0].Cells["totaldisgv"].Value.ToString())).ToString();
                    Totamttxt.Text = Math.Ceiling(Convert.ToSingle(dataGridView1.Rows[0].Cells["totAmountGV"].Value.ToString())).ToString();



                }
                else
                {
                    salesIDTxt.Text = "";
                    salesIDTxt.Focus();
                    dateTimePicker1.Value = DateTime.Now;
                    usertxt.Text = "";
                    paytypetxt.Text = "";
                    amtgivenTxt.Text = "";
                    totdisctxt.Text = "";
                    Totamttxt.Text = "";
                }
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
                usertxt.Text = "";
                amtgivenTxt.Text = "";
                totdisctxt.Text = "";
                paytypetxt.Text = "";
                totdisctxt.Text = "";
                Totamttxt.Text = "";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
