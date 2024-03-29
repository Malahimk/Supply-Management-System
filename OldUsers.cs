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
    public partial class OldUsers : OldSample2
    {
        int edit=0;//This 0 is an indication for save operation and 1 is an indication to update operation

        public OldUsers()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);
            
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") { nameerrorlabel.Visible = true; } else { nameerrorlabel.Visible = false; }
            if (usernameTxt.Text == "") { usernameerrorlabel.Visible = true; } else { usernameerrorlabel.Visible = false; }
            if (passwordTxt.Text == "") { passerrorlabel.Visible = true; } else { passerrorlabel.Visible = false; }
            if (emailTxt.Text == "") { emailerrorlabel.Visible = true; } else { emailerrorlabel.Visible = false; }
            if (phoneTxt.Text == "") { phoneerrorlabel.Visible = true; } else { phoneerrorlabel.Visible = false; }

            if (nameerrorlabel.Visible || usernameerrorlabel.Visible || passerrorlabel.Visible || emailerrorlabel.Visible || phoneerrorlabel.Visible) 
            {
                MainClass.ShowMSG("Fields with * are Mandatory", "Stop", "Error");//error is a type of msg
            }
            else
            {
                if (edit == 0) //code for save operation
                { 
                    insertion i = new insertion();
                   // i.insertUser(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, emailTxt.Text, phoneTxt.Text);

                }
                else if (edit == 1) // code for update operation
                {
                    updation u = new updation();
                  //  u.updateUser(0,nameTxt.Text, usernameTxt.Text, passwordTxt.Text, emailTxt.Text, phoneTxt.Text);
                } 
            }

        }

        public override void deleteBtn_Click_1(object sender, EventArgs e)
        {

        }

        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public override void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
