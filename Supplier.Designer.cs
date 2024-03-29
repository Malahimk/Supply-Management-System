namespace sms
{
    partial class Supplier
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
            this.label2 = new System.Windows.Forms.Label();
            this.SupplierCompanyTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contactpersonTxt = new System.Windows.Forms.TextBox();
            this.Phone1Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Phone2Txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.SupplyErrorLabel = new System.Windows.Forms.Label();
            this.personErrorLabel = new System.Windows.Forms.Label();
            this.phone1ErrorLabel = new System.Windows.Forms.Label();
            this.AdressErrorLabel = new System.Windows.Forms.Label();
            this.StatusErrorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.suppIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.Size = new System.Drawing.Size(105, 22);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.label8);
            this.leftPanel.Controls.Add(this.AddressTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.Phone2Txt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.Phone1Txt);
            this.leftPanel.Controls.Add(this.contactpersonTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.SupplierCompanyTxt);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.SupplyErrorLabel);
            this.leftPanel.Controls.Add(this.personErrorLabel);
            this.leftPanel.Controls.Add(this.phone1ErrorLabel);
            this.leftPanel.Controls.Add(this.AdressErrorLabel);
            this.leftPanel.Controls.Add(this.StatusErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(250, 507);
            this.leftPanel.Controls.SetChildIndex(this.StatusErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.AdressErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.phone1ErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.personErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.SupplyErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.SupplierCompanyTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.contactpersonTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.Phone1Txt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.Phone2Txt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.AddressTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label8, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 100);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(697, 507);
            this.rightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.None;
            this.label1.Location = new System.Drawing.Point(73, -3);
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Size = new System.Drawing.Size(697, 50);
            // 
            // userlabel
            // 
            this.userlabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Supplier Name/Company";
            // 
            // SupplierCompanyTxt
            // 
            this.SupplierCompanyTxt.Location = new System.Drawing.Point(24, 199);
            this.SupplierCompanyTxt.Name = "SupplierCompanyTxt";
            this.SupplierCompanyTxt.Size = new System.Drawing.Size(206, 22);
            this.SupplierCompanyTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact Person";
            // 
            // contactpersonTxt
            // 
            this.contactpersonTxt.Location = new System.Drawing.Point(24, 250);
            this.contactpersonTxt.Name = "contactpersonTxt";
            this.contactpersonTxt.Size = new System.Drawing.Size(206, 22);
            this.contactpersonTxt.TabIndex = 6;
            // 
            // Phone1Txt
            // 
            this.Phone1Txt.Location = new System.Drawing.Point(24, 300);
            this.Phone1Txt.Name = "Phone1Txt";
            this.Phone1Txt.Size = new System.Drawing.Size(206, 22);
            this.Phone1Txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone 2";
            // 
            // Phone2Txt
            // 
            this.Phone2Txt.Location = new System.Drawing.Point(24, 353);
            this.Phone2Txt.Name = "Phone2Txt";
            this.Phone2Txt.Size = new System.Drawing.Size(206, 22);
            this.Phone2Txt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address";
            // 
            // AddressTxt
            // 
            this.AddressTxt.Location = new System.Drawing.Point(24, 404);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(206, 22);
            this.AddressTxt.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Status";
            // 
            // statusDD
            // 
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.statusDD.Location = new System.Drawing.Point(24, 454);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(206, 21);
            this.statusDD.TabIndex = 20;
            // 
            // SupplyErrorLabel
            // 
            this.SupplyErrorLabel.AutoSize = true;
            this.SupplyErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplyErrorLabel.Location = new System.Drawing.Point(215, 183);
            this.SupplyErrorLabel.Name = "SupplyErrorLabel";
            this.SupplyErrorLabel.Size = new System.Drawing.Size(15, 19);
            this.SupplyErrorLabel.TabIndex = 14;
            this.SupplyErrorLabel.Text = "*";
            this.SupplyErrorLabel.Visible = false;
            // 
            // personErrorLabel
            // 
            this.personErrorLabel.AutoSize = true;
            this.personErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personErrorLabel.Location = new System.Drawing.Point(215, 234);
            this.personErrorLabel.Name = "personErrorLabel";
            this.personErrorLabel.Size = new System.Drawing.Size(15, 19);
            this.personErrorLabel.TabIndex = 21;
            this.personErrorLabel.Text = "*";
            this.personErrorLabel.Visible = false;
            // 
            // phone1ErrorLabel
            // 
            this.phone1ErrorLabel.AutoSize = true;
            this.phone1ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone1ErrorLabel.Location = new System.Drawing.Point(215, 284);
            this.phone1ErrorLabel.Name = "phone1ErrorLabel";
            this.phone1ErrorLabel.Size = new System.Drawing.Size(15, 19);
            this.phone1ErrorLabel.TabIndex = 15;
            this.phone1ErrorLabel.Text = "*";
            this.phone1ErrorLabel.Visible = false;
            // 
            // AdressErrorLabel
            // 
            this.AdressErrorLabel.AutoSize = true;
            this.AdressErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressErrorLabel.Location = new System.Drawing.Point(215, 388);
            this.AdressErrorLabel.Name = "AdressErrorLabel";
            this.AdressErrorLabel.Size = new System.Drawing.Size(15, 19);
            this.AdressErrorLabel.TabIndex = 15;
            this.AdressErrorLabel.Text = "*";
            this.AdressErrorLabel.Visible = false;
            // 
            // StatusErrorLabel
            // 
            this.StatusErrorLabel.AutoSize = true;
            this.StatusErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusErrorLabel.Location = new System.Drawing.Point(215, 438);
            this.StatusErrorLabel.Name = "StatusErrorLabel";
            this.StatusErrorLabel.Size = new System.Drawing.Size(15, 19);
            this.StatusErrorLabel.TabIndex = 15;
            this.StatusErrorLabel.Text = "*";
            this.StatusErrorLabel.Visible = false;
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
            this.suppIDGV,
            this.comNameGV,
            this.personGV,
            this.phone1GV,
            this.phone2GV,
            this.addressGV,
            this.statusGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(697, 357);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // suppIDGV
            // 
            this.suppIDGV.HeaderText = "SupplierID";
            this.suppIDGV.Name = "suppIDGV";
            this.suppIDGV.ReadOnly = true;
            this.suppIDGV.Visible = false;
            // 
            // comNameGV
            // 
            this.comNameGV.HeaderText = "Company";
            this.comNameGV.Name = "comNameGV";
            this.comNameGV.ReadOnly = true;
            // 
            // personGV
            // 
            this.personGV.HeaderText = "Contact Person";
            this.personGV.Name = "personGV";
            this.personGV.ReadOnly = true;
            // 
            // phone1GV
            // 
            this.phone1GV.HeaderText = "Phone 1";
            this.phone1GV.Name = "phone1GV";
            this.phone1GV.ReadOnly = true;
            // 
            // phone2GV
            // 
            this.phone2GV.HeaderText = "Phone 2";
            this.phone2GV.Name = "phone2GV";
            this.phone2GV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 507);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Phone1Txt;
        private System.Windows.Forms.TextBox contactpersonTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SupplierCompanyTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Phone2Txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label SupplyErrorLabel;
        private System.Windows.Forms.Label personErrorLabel;
        private System.Windows.Forms.Label phone1ErrorLabel;
        private System.Windows.Forms.Label AdressErrorLabel;
        private System.Windows.Forms.Label StatusErrorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn comNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn personGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}