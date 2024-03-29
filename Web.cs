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
    public partial class Web : Form
    {
        public Web()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }
        string link = "https://duckduckgo.com/";
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //webBrowser1.Navigate(toolStripTextBox1.Text);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void Web_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(link);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();

        }
    }
}
