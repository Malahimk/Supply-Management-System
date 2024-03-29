using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sms
{
    public partial class Supplier : Sample2
    {
        public Supplier()
        {
            InitializeComponent();
        }
        int edit = 0;//This 0 is an indication for save operation and 1 is an indication to update operation
        int supplierID;
        short stat;
        Retrieval r = new Retrieval();

        private void Supplier_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);


        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (SupplierCompanyTxt.Text == "") { SupplyErrorLabel.Visible = true; } else { SupplyErrorLabel.Visible = false; }
            if (contactpersonTxt.Text == "") { personErrorLabel.Visible = true; } else { personErrorLabel.Visible = false; }
            if (Phone1Txt.Text == "") { phone1ErrorLabel.Visible = true; } else { phone1ErrorLabel.Visible = false; }
            if (AddressTxt.Text == "") { AdressErrorLabel.Visible = true; } else { AdressErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { StatusErrorLabel.Visible = true; } else { StatusErrorLabel.Visible = false; }
            if (SupplyErrorLabel.Visible || personErrorLabel.Visible || phone1ErrorLabel.Visible || AdressErrorLabel.Visible|| StatusErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are Mandatory", "Stop", "Error");//error is a type of msg
            }
            else
            {

                if (edit == 0) //code for save operation
                {
                    if (statusDD.SelectedIndex == 0)
                    {
                        stat = 1;
                    }
                    else if (statusDD.SelectedIndex == 1)
                    {
                        stat = 0;
                    }

                    insertion i = new insertion();
                    if (Phone2Txt == null)
                    {
                        i.InsertSupplier(SupplierCompanyTxt.Text, contactpersonTxt.Text, Phone1Txt.Text, AddressTxt.Text, stat, null);
                    }
                    else
                    {
                        i.InsertSupplier(SupplierCompanyTxt.Text, contactpersonTxt.Text, Phone1Txt.Text, AddressTxt.Text, stat, Phone2Txt.Text);
                    }



                    r.showpSuppliers(dataGridView1, suppIDGV, comNameGV, personGV, phone1GV, phone2GV, addressGV, statusGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if (edit == 1) // code for update operation
                {

                    DialogResult dr = MessageBox.Show("Are you sure, you want to upadate record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();

                        if (statusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }

                        if (Phone2Txt == null)
                        {
                            u.updateSupplier(supplierID, SupplierCompanyTxt.Text, contactpersonTxt.Text, Phone1Txt.Text, AddressTxt.Text, stat, null);

                        }
                        else
                        {
                            u.updateSupplier(supplierID, SupplierCompanyTxt.Text, contactpersonTxt.Text, Phone1Txt.Text, AddressTxt.Text, stat, Phone2Txt.Text);

                        }




                        r.showpSuppliers(dataGridView1, suppIDGV, comNameGV, personGV, phone1GV, phone2GV, addressGV, statusGV);
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
                    d.delete(supplierID, "st_deleteSupplier", "@suppID");
                    r.showpSuppliers(dataGridView1,suppIDGV,comNameGV,personGV, phone1GV,phone2GV, addressGV, statusGV);


                }
            }
        }

        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showpSuppliers(dataGridView1, suppIDGV, comNameGV, personGV, phone1GV, phone2GV, addressGV, statusGV);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                supplierID = Convert.ToInt32(row.Cells["suppIDGV"].Value.ToString());
                SupplierCompanyTxt.Text = row.Cells["comNameGV"].Value.ToString();
                contactpersonTxt.Text = row.Cells["personGV"].Value.ToString();
                Phone1Txt.Text = row.Cells["phone1GV"].Value.ToString();
                Phone2Txt.Text = row.Cells["phone2GV"].Value.ToString();
                AddressTxt.Text = row.Cells["addressGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(leftPanel);






            }
        }
    }
}
