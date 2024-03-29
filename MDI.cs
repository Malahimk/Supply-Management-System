using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sms
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(Path + "\\connect")) 
            {

                login log = new login();
                MainClass.showWindow(log,this);
            }
            else
            {
                Settings set = new Settings();
                MainClass.showWindow(set, this);
            }


           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            MainClass.showWindow(set, this);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login set = new login();
            MainClass.showWindow(set, this);
            MDI obj = new MDI();
            obj.logOutToolStripMenuItem.Enabled = false;
        }
    }
}
