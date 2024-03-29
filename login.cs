using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sms
{
    public partial class login : Sample
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (usenameTxt.Text == "") { nameerrorlabel.Visible = true; } else { nameerrorlabel.Visible = false; }


        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usenameTxt.Text == "") { nameerrorlabel.Visible = true; } else { nameerrorlabel.Visible = false; }
            if (passwordTxt.Text == "") { passerrorlabel.Visible = true; } else { passerrorlabel.Visible = false; }
            if (usenameTxt.Text != "" && passwordTxt.Text != "")
                if (nameerrorlabel.Visible || passerrorlabel.Visible)
                {
                    MainClass.ShowMSG("Fields with * are Mandatory", "Stop", "Error"); //Error is the type of Msg

                }
                else
                {

                        if (Retrieval.getUserDetails(usenameTxt.Text, passwordTxt.Text))
                        {
                            HomeScreen hm = new HomeScreen();
                            MainClass.showWindow(hm, this, MDI.ActiveForm);
                        }
                        else
                        {

                        }
                    


                }
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "") { passerrorlabel.Visible = true; } else { passerrorlabel.Visible = false; }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rightPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}