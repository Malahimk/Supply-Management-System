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

namespace sms
{
    public partial class Users : Sample2
    {
        int edit = 0;//This 0 is an indication for save operation and 1 is an indication to update operation
        int userID;
        short stat;
        public Users()
        {
            InitializeComponent();
        }
        Retrieval r = new Retrieval();


        private void checking_Load(object sender, EventArgs e)
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

            if (nameTxt.Text == "") { nameerrorlabel.Visible = true; } else { nameerrorlabel.Visible = false; }
            if (usernameTxt.Text == "") { usernameerrorlabel.Visible = true; } else { usernameerrorlabel.Visible = false; }
            if (passwordTxt.Text == "") { passerrorlabel.Visible = true; } else { passerrorlabel.Visible = false; }
            if (emailTxt.Text == "") { emailerrorlabel.Visible = true; } else { emailerrorlabel.Visible = false; }
            if (phoneTxt.Text == "") { phoneerrorlabel.Visible = true; } else { phoneerrorlabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }


            if (nameerrorlabel.Visible || usernameerrorlabel.Visible || passerrorlabel.Visible || emailerrorlabel.Visible || phoneerrorlabel.Visible || statusErrorLabel.Visible)
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
                   
                   
                    i.insertUser(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, emailTxt.Text, phoneTxt.Text, stat);
                    r.showUsers(dataGridView1,userIDGV,NameGV,UserNameGV,PassGV,EmailGV,PhoneGV,statusGV);
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


                        u.updateUser(userID, nameTxt.Text, usernameTxt.Text, passwordTxt.Text, emailTxt.Text, phoneTxt.Text, stat);
                        r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV);
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
                    d.delete(userID, "st_deleteUser", "@id");
                    r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV);


                }
            }
        }

        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (searchtxt.Text != "")
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV,searchtxt.Text);

            }
            else
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV);

            }
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
               edit = 1;
               DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
               userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
               nameTxt.Text = row.Cells["NameGV"].Value.ToString();
               usernameTxt.Text = row.Cells["UserNameGV"].Value.ToString();
               passwordTxt.Text = row.Cells["PassGV"].Value.ToString();
               emailTxt.Text = row.Cells["EmailGV"].Value.ToString();
               phoneTxt.Text = row.Cells["PhoneGV"].Value.ToString();
               statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
               MainClass.disable(leftPanel);






            }
        }
    }
}
