using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace sms
{
    public partial class SalesReport : Sample
    {
        public SalesReport()
        {
            InitializeComponent();
        }
        ReportDocument rd;

        private void SalesReport_Load(object sender, EventArgs e)
        {
            Retrieval r = new Retrieval();
            rd = new ReportDocument();

            if (viewSalesInvoices.salesID == 0)
            {
                r.showReport(rd, crystalReportViewer1, "st_getSalesReceipt", "@user", Retrieval.USER_ID);

            }
            else
            {

                r.showReport(rd, crystalReportViewer1, "st_getSalesReceiptWRTSalesID", "@salesID", viewSalesInvoices.salesID);
                viewSalesInvoices.salesID = 0;
            }
        }

        private void SalesReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd != null)
            {
                rd.Close();
            }
        }
    }
}
