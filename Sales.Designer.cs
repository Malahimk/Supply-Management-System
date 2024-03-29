namespace sms
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.BarCodeTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grosslabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.remainingStockTxt = new System.Windows.Forms.TextBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Checkoutbtn = new System.Windows.Forms.Button();
            this.paymentDD = new System.Windows.Forms.ComboBox();
            this.Changetxt = new System.Windows.Forms.TextBox();
            this.AmountGiventxt = new System.Windows.Forms.TextBox();
            this.TotDiscounttxt = new System.Windows.Forms.TextBox();
            this.GrossTottxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.Size = new System.Drawing.Size(143, 22);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftPanel.Controls.Add(this.groupBox2);
            this.leftPanel.Controls.Add(this.remainingStockTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.BarCodeTxt);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Size = new System.Drawing.Size(250, 716);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.BarCodeTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.remainingStockTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.None;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel2);
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(920, 716);
            this.rightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.None;
            this.label1.Location = new System.Drawing.Point(82, -4);
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Size = new System.Drawing.Size(920, 50);
            // 
            // userlabel
            // 
            this.userlabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Barcode";
            // 
            // BarCodeTxt
            // 
            this.BarCodeTxt.Location = new System.Drawing.Point(12, 136);
            this.BarCodeTxt.Name = "BarCodeTxt";
            this.BarCodeTxt.Size = new System.Drawing.Size(221, 22);
            this.BarCodeTxt.TabIndex = 4;
            this.BarCodeTxt.TextChanged += new System.EventHandler(this.BarCodeTxt_TextChanged);
            this.BarCodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.BarCodeTxt_Validating);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proIDGV,
            this.proNameGV,
            this.quantGV,
            this.pupGV,
            this.discGV,
            this.TotGV,
            this.deleteGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(920, 393);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // proIDGV
            // 
            dataGridViewCellStyle22.Format = "AED";
            dataGridViewCellStyle22.NullValue = "0";
            this.proIDGV.DefaultCellStyle = dataGridViewCellStyle22;
            this.proIDGV.HeaderText = "proID";
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.ReadOnly = true;
            this.proIDGV.Visible = false;
            // 
            // proNameGV
            // 
            this.proNameGV.HeaderText = "Product";
            this.proNameGV.Name = "proNameGV";
            this.proNameGV.ReadOnly = true;
            // 
            // quantGV
            // 
            this.quantGV.HeaderText = "Quantity ";
            this.quantGV.Name = "quantGV";
            this.quantGV.ReadOnly = true;
            // 
            // pupGV
            // 
            dataGridViewCellStyle23.Format = "N2";
            dataGridViewCellStyle23.NullValue = null;
            this.pupGV.DefaultCellStyle = dataGridViewCellStyle23;
            this.pupGV.HeaderText = "Per Unit Price";
            this.pupGV.Name = "pupGV";
            this.pupGV.ReadOnly = true;
            // 
            // discGV
            // 
            this.discGV.HeaderText = "Discount";
            this.discGV.Name = "discGV";
            this.discGV.ReadOnly = true;
            // 
            // TotGV
            // 
            dataGridViewCellStyle24.Format = "N2";
            dataGridViewCellStyle24.NullValue = null;
            this.TotGV.DefaultCellStyle = dataGridViewCellStyle24;
            this.TotGV.HeaderText = "Total Amount";
            this.TotGV.Name = "TotGV";
            this.TotGV.ReadOnly = true;
            // 
            // deleteGV
            // 
            this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Text = "DELETE";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.88426F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.11574F));
            this.tableLayoutPanel2.Controls.Add(this.grosslabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 543);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(920, 173);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // grosslabel
            // 
            this.grosslabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grosslabel.AutoSize = true;
            this.grosslabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grosslabel.Location = new System.Drawing.Point(763, 63);
            this.grosslabel.Name = "grosslabel";
            this.grosslabel.Size = new System.Drawing.Size(81, 46);
            this.grosslabel.TabIndex = 16;
            this.grosslabel.Text = "0.00";
            this.grosslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(252, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 46);
            this.label8.TabIndex = 15;
            this.label8.Text = "Gross Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Remaining  Stock";
            // 
            // remainingStockTxt
            // 
            this.remainingStockTxt.Enabled = false;
            this.remainingStockTxt.Location = new System.Drawing.Point(12, 177);
            this.remainingStockTxt.Name = "remainingStockTxt";
            this.remainingStockTxt.Size = new System.Drawing.Size(221, 22);
            this.remainingStockTxt.TabIndex = 6;
            this.remainingStockTxt.TextChanged += new System.EventHandler(this.remainingStockTxt_TextChanged);
            // 
            // payBtn
            // 
            this.payBtn.FlatAppearance.BorderSize = 2;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Location = new System.Drawing.Point(10, 350);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(221, 76);
            this.payBtn.TabIndex = 7;
            this.payBtn.Text = "&PAY";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Checkoutbtn);
            this.groupBox2.Controls.Add(this.paymentDD);
            this.groupBox2.Controls.Add(this.Changetxt);
            this.groupBox2.Controls.Add(this.AmountGiventxt);
            this.groupBox2.Controls.Add(this.TotDiscounttxt);
            this.groupBox2.Controls.Add(this.GrossTottxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.payBtn);
            this.groupBox2.Location = new System.Drawing.Point(3, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 432);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payments";
            // 
            // Checkoutbtn
            // 
            this.Checkoutbtn.FlatAppearance.BorderSize = 2;
            this.Checkoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Checkoutbtn.Location = new System.Drawing.Point(9, 268);
            this.Checkoutbtn.Name = "Checkoutbtn";
            this.Checkoutbtn.Size = new System.Drawing.Size(221, 76);
            this.Checkoutbtn.TabIndex = 18;
            this.Checkoutbtn.Text = "&CHECKOUT";
            this.Checkoutbtn.UseVisualStyleBackColor = true;
            this.Checkoutbtn.Click += new System.EventHandler(this.Checkoutbtn_Click);
            // 
            // paymentDD
            // 
            this.paymentDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentDD.FormattingEnabled = true;
            this.paymentDD.Items.AddRange(new object[] {
            "Cash",
            "Debit Card",
            "Credit Card"});
            this.paymentDD.Location = new System.Drawing.Point(12, 136);
            this.paymentDD.Name = "paymentDD";
            this.paymentDD.Size = new System.Drawing.Size(219, 21);
            this.paymentDD.TabIndex = 17;
            // 
            // Changetxt
            // 
            this.Changetxt.Enabled = false;
            this.Changetxt.Location = new System.Drawing.Point(12, 217);
            this.Changetxt.Name = "Changetxt";
            this.Changetxt.Size = new System.Drawing.Size(221, 22);
            this.Changetxt.TabIndex = 16;
            // 
            // AmountGiventxt
            // 
            this.AmountGiventxt.Location = new System.Drawing.Point(12, 176);
            this.AmountGiventxt.Multiline = true;
            this.AmountGiventxt.Name = "AmountGiventxt";
            this.AmountGiventxt.Size = new System.Drawing.Size(221, 22);
            this.AmountGiventxt.TabIndex = 15;
            this.AmountGiventxt.TextChanged += new System.EventHandler(this.AmountGiventxt_TextChanged);
            this.AmountGiventxt.Validating += new System.ComponentModel.CancelEventHandler(this.AmountGiventxt_Validating);
            // 
            // TotDiscounttxt
            // 
            this.TotDiscounttxt.Enabled = false;
            this.TotDiscounttxt.Location = new System.Drawing.Point(12, 94);
            this.TotDiscounttxt.Name = "TotDiscounttxt";
            this.TotDiscounttxt.Size = new System.Drawing.Size(221, 22);
            this.TotDiscounttxt.TabIndex = 14;
            // 
            // GrossTottxt
            // 
            this.GrossTottxt.Enabled = false;
            this.GrossTottxt.Location = new System.Drawing.Point(12, 46);
            this.GrossTottxt.Name = "GrossTottxt";
            this.GrossTottxt.Size = new System.Drawing.Size(221, 22);
            this.GrossTottxt.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Change";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Amount Given";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Payment Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gross Total";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 716);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox BarCodeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label grosslabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn discGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox remainingStockTxt;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox AmountGiventxt;
        private System.Windows.Forms.TextBox TotDiscounttxt;
        private System.Windows.Forms.TextBox GrossTottxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Changetxt;
        private System.Windows.Forms.ComboBox paymentDD;
        private System.Windows.Forms.Button Checkoutbtn;
    }
}