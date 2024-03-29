﻿namespace sms
{
    partial class viewSalesInvoices
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.loadBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.salidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totAmtGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totDisGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.givenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnedGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftPanel.Controls.Add(this.loadBtn);
            this.leftPanel.Controls.Add(this.dateTimePicker1);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Size = new System.Drawing.Size(250, 552);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.leftPanel.Controls.SetChildIndex(this.loadBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.backBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(748, 552);
            this.rightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(748, 50);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // loadBtn
            // 
            this.loadBtn.FlatAppearance.BorderSize = 2;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Location = new System.Drawing.Point(12, 122);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(200, 76);
            this.loadBtn.TabIndex = 8;
            this.loadBtn.Text = "&Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
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
            this.salidGV,
            this.userIDgv,
            this.userGV,
            this.totAmtGV,
            this.totDisGV,
            this.givenGV,
            this.returnedGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(748, 393);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // backBtn
            // 
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = global::sms.Properties.Resources.icons8_back_arrow_50;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(67, 50);
            this.backBtn.TabIndex = 5;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // salidGV
            // 
            this.salidGV.HeaderText = "Sales ID";
            this.salidGV.Name = "salidGV";
            this.salidGV.ReadOnly = true;
            // 
            // userIDgv
            // 
            this.userIDgv.HeaderText = "User ID";
            this.userIDgv.Name = "userIDgv";
            this.userIDgv.ReadOnly = true;
            this.userIDgv.Visible = false;
            // 
            // userGV
            // 
            this.userGV.HeaderText = "User";
            this.userGV.Name = "userGV";
            this.userGV.ReadOnly = true;
            // 
            // totAmtGV
            // 
            this.totAmtGV.HeaderText = "Total Amount";
            this.totAmtGV.Name = "totAmtGV";
            this.totAmtGV.ReadOnly = true;
            // 
            // totDisGV
            // 
            this.totDisGV.HeaderText = "Total Discount";
            this.totDisGV.Name = "totDisGV";
            this.totDisGV.ReadOnly = true;
            // 
            // givenGV
            // 
            this.givenGV.HeaderText = "Amount Given";
            this.givenGV.Name = "givenGV";
            this.givenGV.ReadOnly = true;
            // 
            // returnedGV
            // 
            this.returnedGV.HeaderText = "Amount Returned";
            this.returnedGV.Name = "returnedGV";
            this.returnedGV.ReadOnly = true;
            // 
            // viewSalesInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 552);
            this.Name = "viewSalesInvoices";
            this.Text = "viewSalesInvoices";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn userGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totAmtGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totDisGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn givenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnedGV;
    }
}