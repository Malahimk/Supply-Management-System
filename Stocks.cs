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
    public partial class Stocks : Sample2
    {
        public Stocks()
        {
            InitializeComponent();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {

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
        Retrieval r = new Retrieval();
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showpStockDetails(dataGridView1, proIDGV, proNameGV, barGV,expiryGV, bpGV,SpGV, catGV, quantGV, statusGV, finalGV);
        }
    }
}
