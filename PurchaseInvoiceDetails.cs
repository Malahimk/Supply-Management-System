﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace sms
{
    public partial class PurchaseInvoiceDetails : Sample2
    {
        public PurchaseInvoiceDetails()
        {
            InitializeComponent();
        }
        Retrieval r = new Retrieval();
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purrDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }

        private void PurchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purrDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);

        }

        private void purrDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (purrDD.SelectedIndex != -1 && purrDD.SelectedIndex !=0) 
            {
                float gt = 0;
                r.showPurchaseInvoiceDetails(Convert.ToInt64(purrDD.SelectedValue.ToString()),dataGridView1,mPIDgv, proIDGV, proNameGV, quantGV, pupGV, TotGV);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["TotGV"].Value.ToString());
                }    
                grosslabel.Text = gt.ToString();
                gt = 0;
            
            }

        }
        insertion i = new insertion();
        updation u = new updation();
        deletion d = new deletion();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DialogResult dr = MessageBox.Show("Are you sure, you want to delete" + row.Cells["proIDGV"].Value.ToString() + "from purchase invoice?\n\t\t\tWARNING\nDELETION OF PRODUCT WILL EFFECT STOCK","Questions...",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    int q;
                    if (dr == DialogResult.Yes)
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            i.insertDeletedItem(Convert.ToInt64(purrDD.SelectedValue.ToString()), Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantGV"].Value.ToString()), Retrieval.USER_ID, DateTime.Today);
                            object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                            if (ob != null)
                            {
                                q = Convert.ToInt32(ob);
                                q -= Convert.ToInt32(row.Cells["quantGV"].Value.ToString());
                                u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), q);
                                float tot = Convert.ToSingle(grosslabel.Text) - Convert.ToSingle(row.Cells["TotGV"].Value.ToString());
                                d.delete(Convert.ToInt64(row.Cells["mPIDgv"].Value.ToString()), "st_deleteProductFromID", "@mPID");
                                grosslabel.Text = tot.ToString();
                                
                                dataGridView1.Rows.Remove(row);


                            }
                            sc.Complete();





                        }
                        

                    }

                }
            }
        }
    }
}
