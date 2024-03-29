using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sms
{
    public partial class products : Sample2
    {
        int edit = 0;//This 0 is an indication for save operation and 1 is an indication to update operation
        int prodID;

        public products()
        {
            InitializeComponent();
        }
        Retrieval r = new Retrieval();

        private void rightPanel_Paint_1(object sender, PaintEventArgs e)
        {


        }

        private void products_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            r.getList("st_getCategoriesList", categoryDD, "Category", "ID");

        }
        public override void addBtn_Click(object sender, EventArgs e)
        {

            MainClass.enable_reset(leftPanel);
            edit = 0;

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {

            if (proTxt.Text == "") { proErrorLabel.Visible = true; } else { proErrorLabel.Visible = false; }
            if (barcodeTxt.Text == "") { barcodeErrorLabel.Visible = true; } else { barcodeErrorLabel.Visible = false; }
            if (ExpiryPicker.Value.Date < DateTime.Now.Date) { expiryerrorlabel.Visible = true; expiryerrorlabel.Text = "Expired Date"; } else { expiryerrorlabel.Visible = false; }

            if (categoryDD.SelectedIndex == -1 || categoryDD.SelectedIndex == 0) { CategogryErrorLabel.Visible = true; } else { CategogryErrorLabel.Visible = false; }


            if (proErrorLabel.Visible || barcodeErrorLabel.Visible || expiryerrorlabel.Visible || CategogryErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are Mandatory", "Stop", "Error");//error is a type of msg
            }
            else
            {

                if (edit == 0) //code for save operation
                {

                    insertion i = new insertion();
                    if (ExpiryPicker.Value.Date == DateTime.Now.Date)
                    {
                        i.InsertProduct(proTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue));

                    }
                    else
                    {
                        i.InsertProduct(proTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue), ExpiryPicker.Value);

                    }


                    r.showpPoducts(dataGridView1, proIDGV, proNameGV, expiryGV, catGV, catIDGV, barGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if (edit == 1) // code for update operation
                {

                    DialogResult dr = MessageBox.Show("Are you sure, you want to upadate record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (ExpiryPicker.Value.Date == DateTime.Now.Date)
                        {
                            u.updateProduct(prodID, proTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue));

                        }
                        else
                        {
                            u.updateProduct(prodID, proTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue), ExpiryPicker.Value);


                        }

                        r.showpPoducts(dataGridView1, proIDGV, proNameGV, expiryGV, catGV, catIDGV, barGV);
                        MainClass.disable_reset(leftPanel);
                    }

                }


            }

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {

                DialogResult dr = MessageBox.Show("Are you sure, you want to delete record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.delete(prodID, "s_productDelete", "@proID");
                    r.showpPoducts(dataGridView1, proIDGV, proNameGV, expiryGV, catGV, catIDGV, barGV);


                }
            }
        }

        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showpPoducts(dataGridView1, proIDGV, proNameGV, expiryGV, catGV, catIDGV, barGV);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                prodID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString());
                proTxt.Text = row.Cells["proNameGV"].Value.ToString();
                
                barcodeTxt.Text = row.Cells["barGV"].Value.ToString();
                if (row.Cells["expiryGV"].FormattedValue.ToString() == "")
                  {
                    ExpiryPicker.Value = DateTime.Now;

                  }
                  else
                  {
                    ExpiryPicker.Value = Convert.ToDateTime(row.Cells["expiryGV"].Value.ToString());
                  }
                    categoryDD.SelectedItem = row.Cells["catGV"].Value.ToString();
                    //categoryDD.SelectedValue = row.Cells["catIDGV"].Value.ToString();

                MainClass.disable(leftPanel);






                }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

