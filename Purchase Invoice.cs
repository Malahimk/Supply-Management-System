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
using System.Transactions;


namespace sms
{
    public partial class Purchase_Invoice : Sample2
    {
        public Purchase_Invoice()
        {
            InitializeComponent();
        }
        Retrieval r = new Retrieval();
        int productID;
        float gt,tot;
        //Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*?$");
          Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");


        public override void addBtn_Click(object sender, EventArgs e)
        {

        }
        int co;
        updation u = new updation();
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Int64 purchaseInvoiceID;
                insertion i = new insertion();
                using (TransactionScope sc = new TransactionScope())
                {
                    purchaseInvoiceID = i.insertPurchaseInvoice(DateTime.Today, Retrieval.USER_ID, Convert.ToInt32(supplierDD.SelectedValue));

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        co += i.insertPurchaseInvoiceDetails(purchaseInvoiceID, Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantGV"].Value.ToString()), Convert.ToSingle(row.Cells["TotGV"].Value.ToString()));
                        if (r.checkProductPriceExistance(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString())))
                        {
                            u.updateProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));

                        }
                        else
                        {
                            i.insertProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));

                        }

                        int q;
                        object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                        if (ob != null)
                        {
                            q = Convert.ToInt32(ob);
                            q += Convert.ToInt32(row.Cells["quantGV"].Value.ToString());
                            u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()),q);


                        }
                        else
                        {



                            i.insertStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantGV"].Value.ToString()));
                        }
                    
                    
                    
                    }
                    if (co > 0)
                    {
                        MainClass.ShowMSG("Purchase Invoice Created Successfully.", "Success", "Success");
                    }
                    else
                    {
                        MainClass.ShowMSG("Unable to create purchase invoice", "Error", "Error");
                    }
                    sc.Complete();
                }
                    
                
            }

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void backBtn_Click(object sender, EventArgs e)
        {
            //  Purchase_Invoice obj = new Purchase_Invoice();
            //   MainClass.showWindow(obj, this, MDI.ActiveForm);

            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }




        public override void viewBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceDetails pid = new PurchaseInvoiceDetails();
            MainClass.showWindow(pid, this, MDI.ActiveForm);
        }


        private void Purchase_Invoice_Load(object sender, EventArgs e)
        {
            r.getList("st_getSupplierlists", supplierDD, "Company", "ID");

        }

        string[] proARR = new string[3];
        private void BarcodeTxt_TextChanged(object sender, EventArgs e)
        {
               
                
            }

        private void QuantityTxt_TextChanged(object sender, EventArgs e)
        {
            if (QuantityTxt.Text != "")
            {
                if (rg.Match(QuantityTxt.Text).Success)
                {
                    float quan, price, tot;
                    quan = Convert.ToSingle(QuantityTxt.Text);
                    price = Convert.ToSingle(PriceTxt.Text);
                    tot = quan * price;
                    TotalLabel.Text = tot.ToString("###########.##");
                }
                else
                {
                    QuantityTxt.SelectAll();
                }
            }
            else
            {
                TotalLabel.Text = "0.00";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex !=  -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    gt -= Convert.ToSingle(row.Cells["TotGV"].Value.ToString());
                    grosslabel.Text = gt.ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void PriceTxt_TextChanged(object sender, EventArgs e)
        {
            if (PriceTxt.Text != "")
            {
                if (!rg.Match(PriceTxt.Text).Success)
                {
                    PriceTxt.Text = "";
                    PriceTxt.Focus();
                }
            }
        }

        private void BarcodeTxt_Validating(object sender, CancelEventArgs e)
        {
            if (BarcodeTxt.Text != "")
            {
                proARR = r.getProductWRTBarcode(BarcodeTxt.Text);
                productID = Convert.ToInt32(proARR[0]);
                ProductTxt.Text = proARR[1];

                string barco = proARR[2];
                ProductTxt.Enabled = false;


                if (barco != null)
                {
                    PriceTxt.Focus();
                }









            }
            else
            {
                productID = 0;
                ProductTxt.Text = "";
                PriceTxt.Text = "";
                Array.Clear(proARR, 0, proARR.Length);
            }

        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            if (supplierDD.SelectedIndex == -1) { supplierErrorLabel.Visible = true;} else { supplierErrorLabel.Visible = false;}
            if (QuantityTxt.Text == "") { QuantityErrorLabel.Visible = true;} else {  QuantityErrorLabel.Visible = false;}
            if (BarcodeTxt.Text == "") { BarcodeErrorLabel.Visible = true; } else { BarcodeErrorLabel.Visible = false; }
            if (supplierErrorLabel.Visible || QuantityErrorLabel.Visible || BarcodeErrorLabel.Visible)
            {
                MainClass.ShowMSG("Field With * are Mandatory", "Stop", "Error"); //Error is the type of Msg
            }
            else
            {
             dataGridView1.Rows.Add(productID, ProductTxt.Text, QuantityTxt.Text, PriceTxt.Text, TotalLabel.Text);
                gt += Convert.ToSingle(TotalLabel.Text);
                grosslabel.Text = gt.ToString();
                productID = 0;
                ProductTxt.Text = "";
                PriceTxt.Text = "";
                BarcodeTxt.Text = "";
                TotalLabel.Text = "0.00";
                QuantityTxt.Text = "";
                Array.Clear(proARR, 0, proARR.Length);
            }
        }
    }
    }

