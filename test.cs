using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sms
{
    public partial class test : HomeScreen
    {
        public test()
        {
            InitializeComponent();
        }
        Retrieval r = new Retrieval();
        Regex rg = new Regex("^[0-9]+$");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //r.showSalesDataViaID(Convert.ToInt64(salesIDTxt.Text), dataGridView1, saleidgv, barcodegv, productgv, quantitygv, pricegv
              //        , productdiscgv, perprototalgv, totaldisgv, totAmountGV, amountgivengv, amountreturnedgv,
                //      dategv, usergv, paygv, proIDGV);

            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
              //  row.Cells["pricegv"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["pricegv"].Value));
                //row.Cells["productdiscgv"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["productdiscgv"].Value));
                //row.Cells["perprototalgv"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["perprototalgv"].Value));
            }

        }
    }
//}
