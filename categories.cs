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
    public partial class categories : Sample2
    {
        int edit = 0;//This 0 is an indication for save operation and 1 is an indication to update operation
        int catID;
        short stat;
        Retrieval r = new Retrieval();
        public categories()
        {
            InitializeComponent();
        }

        private void categories_Load(object sender, EventArgs e)
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
            if (catTxt.Text == "") { catErrorLabel.Visible = true; } else { catErrorLabel.Visible = false; }
            
            if (activeDD.SelectedIndex == -1) { ActiveErrorLabel.Visible = true; } else { ActiveErrorLabel.Visible = false; }


            if (ActiveErrorLabel.Visible || catErrorLabel.Visible )
            {
                MainClass.ShowMSG("Fields with * are Mandatory", "Stop", "Error");//error is a type of msg
            }
            else
            {

                if (edit == 0) //code for save operation
                {
                    if (activeDD.SelectedIndex == 0)
                    {
                        stat = 1;
                    }
                    else if (activeDD.SelectedIndex == 1)
                    {
                        stat = 0;
                    }

                    insertion i = new insertion();


                    i.InsertCat(catTxt.Text, stat);
                    r.showCategories(dataGridView1, catIDGV, NameGV, statusGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if (edit == 1) // code for update operation
                {

                    DialogResult dr = MessageBox.Show("Are you sure, you want to upadate record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();




                        u.updateCat(catID, catTxt.Text,stat);
                        r.showCategories(dataGridView1, catIDGV, NameGV, statusGV);
                        MainClass.disable_reset(leftPanel);
                    }

                }


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                catTxt.Text = row.Cells["NameGV"].Value.ToString();
                activeDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(leftPanel);






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
                    d.delete(catID, "st_deleteCategory", "@id");
                    r.showCategories(dataGridView1, catIDGV, NameGV, statusGV);


                }
            }

            }

        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showCategories(dataGridView1, catIDGV, NameGV, statusGV);

        }
    }
}
