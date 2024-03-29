using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sms
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
         
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (INTcheckbox.Checked)
            {


                if (Servertxt.Text != "" && Databasetxt.Text != "")
                {
                    s = "Data Source" + Servertxt.Text + "; Initial Catalog=" + Databasetxt.Text + ";Integrated Security=true;MultipleActiveResultSets=true;";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("Setting Saves Successfully...", "information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give complete data to continue...");
                }
            }
            else
            {
                if (Servertxt.Text != "" && Databasetxt.Text != "" && UserIDtxt.Text != "" && passtxt.Text !="")
                {
                    s = "Data Source" + Servertxt.Text + "; Initial Catalog=" + Databasetxt.Text + ";User ID=" +UserIDtxt.Text+";Password="+ passtxt.Text+ ";MultipleActiveResultSets=true;";
                    File.WriteAllText(path + "\\connect", s);


                }
                else
                {
                    MessageBox.Show("Please give complete data to continue...");
                }

            }
          
            
        }
        private void INTcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (INTcheckbox.Checked)
            {
                UserIDtxt.Enabled = false;
                passtxt.Enabled = false;
                UserIDtxt.Text = "";
                passtxt.Text = "";

            }
            else
            {
                UserIDtxt.Enabled = true;
                passtxt.Enabled = true;
            }
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Databasetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
