using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sms
{
    public partial class Sales : Sample2
    {
        public Sales()
        {
            InitializeComponent();
        }
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");


        private void Sales_Load(object sender, EventArgs e)
        {

        }
        Retrieval r = new Retrieval();
        string[] prodARR = new string[6];
        float GROSS = 0;
        private void BarCodeTxt_TextChanged(object sender, EventArgs e)
        {




        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            viewSalesInvoices vsi = new viewSalesInvoices();
            MainClass.showWindow(vsi, this, MDI.ActiveForm);
        }


        bool productCheck;
        private void BarCodeTxt_Validating(object sender, CancelEventArgs e)
        {
            if (BarCodeTxt.Text != "")
            {
                GrossTottxt.Text = "";
                TotDiscounttxt.Text = "";
                AmountGiventxt.Text = "";
                Changetxt.Text = "";
                int qCount = 0, sQuant = 0, nCount = 0;
                prodARR = r.getProductpriceWRTBarcode(BarCodeTxt.Text);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (prodARR[0] == row.Cells["proIDGV"].Value.ToString())
                    {
                        qCount = qCount + Convert.ToInt32(row.Cells["quantGV"].Value.ToString());
                    }

                }
                sQuant = Convert.ToInt32(r.getProductQuantity(Convert.ToInt32(prodARR[0])));
               // remainingStockTxt.Text = (sQuant - 1).ToString();
                nCount = sQuant - qCount;
                if (nCount <= 0)
                {

                }
                else
                {

                    if (dataGridView1.RowCount == 0)
                    {
                        dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[5]));
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["proIDGV"].Value.ToString() == prodARR[0])
                            {
                                productCheck = true;
                                break;
                            }
                            else
                            {
                                productCheck = false;
                                //dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[5]));
                            }


                        }
                        if (productCheck == true)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["proIDGV"].Value.ToString() == prodARR[0])
                                {
                                    float disc = 0;
                                    row.Cells["quantGV"].Value = Convert.ToInt32(row.Cells["quantGV"].Value.ToString()) + 1;
                                    if (row.Cells["discGV"].Value.ToString() != null)
                                    {
                                        disc = Convert.ToSingle(row.Cells["discGV"].Value.ToString()) + Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                                        row.Cells["discGV"].Value = disc;
                                    }
                                    float tot = Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quantGV"].Value.ToString()) - Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                                    row.Cells["TotGV"].Value = tot;
                                }
                            }

                        }
                        else
                        {
                            dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[5]));

                            //float tot = Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quantGV"].Value.ToString()) - Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                        }
                    }
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        GROSS += Convert.ToSingle(item.Cells["TotGV"].Value.ToString());
                    }
                    grosslabel.Text = Math.Round(GROSS,0).ToString();
                    GROSS = 0;
                    BarCodeTxt.Focus();
                    BarCodeTxt.Text = "";
                }









            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    GrossTottxt.Text = "";
                    TotDiscounttxt.Text = "";
                    AmountGiventxt.Text = "";
                    Changetxt.Text = "";
                    float gt, tot, dis;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int q = Convert.ToInt32(row.Cells["quantGV"].Value.ToString());


                    if (q == 1)
                    {
                        gt = Convert.ToSingle(grosslabel.Text);
                        gt = gt - Convert.ToSingle(row.Cells["TotGV"].Value.ToString());
                        grosslabel.Text = gt.ToString();
                        dataGridView1.Rows.Remove(row);
                    }
                    else if (q > 1)
                    {
                        q--;
                        row.Cells["quantGV"].Value = q;
                        dis = Convert.ToSingle(row.Cells["discGV"].Value.ToString()) - Convert.ToSingle(prodARR[4]);
                        row.Cells["discGV"].Value = dis;
                        tot = Convert.ToSingle(row.Cells["quantGV"].Value.ToString()) * Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) - dis;
                        row.Cells["TotGV"].Value = tot;

                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            GROSS += Convert.ToSingle(item.Cells["TotGV"].Value.ToString());
                        }
                        grosslabel.Text = GROSS.ToString();
                        GROSS = 0;



                    }

                }
            }
        }
        insertion i = new insertion();
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (AmountGiventxt.Text != "" && TotDiscounttxt.Text != "" && GrossTottxt.Text != "" && paymentDD.SelectedIndex != -1 && Changetxt.Text != "")
            {
                DialogResult dr = MessageBox.Show("\n\tTotal Amount : "+ GrossTottxt.Text+"\n\tTotal Discount : " + TotDiscounttxt.Text+ "\n\tAmount Given: "+ AmountGiventxt.Text+"\n\t Amount Returned : " + Changetxt.Text+ "\n\nAre you sure, submit current sales?", "Question...",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                i.insertSales(dataGridView1,"proIDGV","quantGV",Retrieval.USER_ID,DateTime.Now,Convert.ToSingle(GrossTottxt.Text),Convert.ToSingle(TotDiscounttxt.Text),Convert.ToSingle(AmountGiventxt.Text),Convert.ToSingle(Changetxt.Text),paymentDD.SelectedItem.ToString());
                MainClass.enable_reset(groupBox2);
                dataGridView1.Rows.Clear();
                grosslabel.Text = "0.00";
                SalesReport sr = new SalesReport();
                sr.Show();
            }
        }

        private void Checkoutbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                float dis = 0, gross = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dis += Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                    gross += Convert.ToSingle(row.Cells["TotGV"].Value.ToString());
                }
                GrossTottxt.Text = Math.Round(gross,0).ToString();
                TotDiscounttxt.Text = Math.Round(dis,0).ToString();
            }
        }

        private void remainingStockTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AmountGiventxt_TextChanged(object sender, EventArgs e)
        {
            if (AmountGiventxt.Text != "")
            {


                if (!rg.Match(AmountGiventxt.Text).Success)
                {
                    AmountGiventxt.Text = "";
                    AmountGiventxt.Focus();
                }
                else
                {
                    
                }
            }
            else
            {
                Changetxt.Text = "";
            }
        }
    
        private void AmountGiventxt_Validating(object sender, CancelEventArgs e)
        {
            if (AmountGiventxt.Text != "" && GrossTottxt.Text != "")
            {
                if (!(Convert.ToSingle(GrossTottxt.Text) <= Convert.ToSingle(AmountGiventxt.Text)))
                {
                    AmountGiventxt.Text = "";
                    Changetxt.Text = "";
                    AmountGiventxt.Focus();
                }
                else
                {
                    float amountGiven = Convert.ToSingle(AmountGiventxt.Text);
                    float amounttoreturn = amountGiven - Convert.ToSingle(GrossTottxt.Text);
                    Changetxt.Text = Math.Round(amounttoreturn,0).ToString();
                }
            }
        }
    }
}
    



    



