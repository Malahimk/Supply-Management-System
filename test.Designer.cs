namespace sms
{
    partial class test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saleidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdiscgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perprototalgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaldisgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountgivengv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountreturnedgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dategv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usergv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(250, 749);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(1120, 749);
            this.rightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // userlabel
            // 
            this.userlabel.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleidgv,
            this.barcodegv,
            this.proIDGV,
            this.productgv,
            this.quantitygv,
            this.pricegv,
            this.productdiscgv,
            this.perprototalgv,
            this.totaldisgv,
            this.totAmountGV,
            this.amountgivengv,
            this.amountreturnedgv,
            this.dategv,
            this.paygv,
            this.usergv});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1120, 663);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // saleidgv
            // 
            this.saleidgv.HeaderText = "SaleID";
            this.saleidgv.Name = "saleidgv";
            this.saleidgv.ReadOnly = true;
            this.saleidgv.Visible = false;
            // 
            // barcodegv
            // 
            this.barcodegv.HeaderText = "Barcode";
            this.barcodegv.Name = "barcodegv";
            this.barcodegv.ReadOnly = true;
            // 
            // proIDGV
            // 
            this.proIDGV.HeaderText = "Pro ID";
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.ReadOnly = true;
            this.proIDGV.Visible = false;
            // 
            // productgv
            // 
            this.productgv.HeaderText = "Product";
            this.productgv.Name = "productgv";
            this.productgv.ReadOnly = true;
            // 
            // quantitygv
            // 
            this.quantitygv.HeaderText = "Quantity ";
            this.quantitygv.Name = "quantitygv";
            this.quantitygv.ReadOnly = true;
            // 
            // pricegv
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.pricegv.DefaultCellStyle = dataGridViewCellStyle2;
            this.pricegv.HeaderText = "Price";
            this.pricegv.Name = "pricegv";
            this.pricegv.ReadOnly = true;
            // 
            // productdiscgv
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.productdiscgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.productdiscgv.HeaderText = "Per Product Discount";
            this.productdiscgv.Name = "productdiscgv";
            this.productdiscgv.ReadOnly = true;
            // 
            // perprototalgv
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.perprototalgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.perprototalgv.HeaderText = "Per Product Total";
            this.perprototalgv.Name = "perprototalgv";
            this.perprototalgv.ReadOnly = true;
            // 
            // totaldisgv
            // 
            this.totaldisgv.HeaderText = "Total Discount ";
            this.totaldisgv.Name = "totaldisgv";
            this.totaldisgv.ReadOnly = true;
            this.totaldisgv.Visible = false;
            // 
            // totAmountGV
            // 
            this.totAmountGV.HeaderText = "Total Amount";
            this.totAmountGV.Name = "totAmountGV";
            this.totAmountGV.ReadOnly = true;
            this.totAmountGV.Visible = false;
            // 
            // amountgivengv
            // 
            this.amountgivengv.HeaderText = "Amount Given";
            this.amountgivengv.Name = "amountgivengv";
            this.amountgivengv.ReadOnly = true;
            this.amountgivengv.Visible = false;
            // 
            // amountreturnedgv
            // 
            this.amountreturnedgv.HeaderText = "Amount Returned";
            this.amountreturnedgv.Name = "amountreturnedgv";
            this.amountreturnedgv.ReadOnly = true;
            this.amountreturnedgv.Visible = false;
            // 
            // dategv
            // 
            this.dategv.HeaderText = "Date";
            this.dategv.Name = "dategv";
            this.dategv.ReadOnly = true;
            this.dategv.Visible = false;
            // 
            // paygv
            // 
            this.paygv.HeaderText = "Payment";
            this.paygv.Name = "paygv";
            this.paygv.ReadOnly = true;
            this.paygv.Visible = false;
            // 
            // usergv
            // 
            this.usergv.HeaderText = "User";
            this.usergv.Name = "usergv";
            this.usergv.ReadOnly = true;
            this.usergv.Visible = false;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Name = "test";
            this.Text = "test";
            this.leftPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitygv;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdiscgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn perprototalgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaldisgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn totAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountgivengv;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountreturnedgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dategv;
        private System.Windows.Forms.DataGridViewTextBoxColumn paygv;
        private System.Windows.Forms.DataGridViewTextBoxColumn usergv;
    }
}