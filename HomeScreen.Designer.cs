namespace sms
{
    partial class HomeScreen
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
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.salesBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.priceBtn = new System.Windows.Forms.Button();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Web = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.catBtn = new System.Windows.Forms.Button();
            this.stockBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftPanel.Controls.Add(this.button2);
            this.leftPanel.Controls.Add(this.salesBtn);
            this.leftPanel.Controls.Add(this.productBtn);
            this.leftPanel.Controls.Add(this.priceBtn);
            this.leftPanel.Controls.Add(this.purchaseBtn);
            this.leftPanel.Size = new System.Drawing.Size(269, 749);
            this.leftPanel.Controls.SetChildIndex(this.purchaseBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.productBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.salesBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.button2, 0);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Size = new System.Drawing.Size(269, 50);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rightPanel.Controls.Add(this.label3);
            this.rightPanel.Controls.Add(this.pictureBox1);
            this.rightPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPanel.Location = new System.Drawing.Point(269, 0);
            this.rightPanel.Size = new System.Drawing.Size(1101, 749);
            this.rightPanel.Controls.SetChildIndex(this.pictureBox1, 0);
            this.rightPanel.Controls.SetChildIndex(this.label3, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel1, 0);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(-185, 0);
            this.label1.Size = new System.Drawing.Size(454, 50);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Web);
            this.panel1.Controls.Add(this.userBtn);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.catBtn);
            this.panel1.Controls.Add(this.stockBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.None;
            this.panel1.Size = new System.Drawing.Size(1161, 97);
            this.panel1.Controls.SetChildIndex(this.stockBtn, 0);
            this.panel1.Controls.SetChildIndex(this.catBtn, 0);
            this.panel1.Controls.SetChildIndex(this.userlabel, 0);
            this.panel1.Controls.SetChildIndex(this.button4, 0);
            this.panel1.Controls.SetChildIndex(this.logoutbtn, 0);
            this.panel1.Controls.SetChildIndex(this.userBtn, 0);
            this.panel1.Controls.SetChildIndex(this.Web, 0);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            // 
            // userlabel
            // 
            this.userlabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userlabel.ForeColor = System.Drawing.Color.Black;
            this.userlabel.Location = new System.Drawing.Point(3, 0);
            this.userlabel.Size = new System.Drawing.Size(107, 50);
            this.userlabel.Click += new System.EventHandler(this.userlabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(586, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Welcome to TEHZEEB Supply Management System";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = global::sms.Properties.Resources.q;
            this.button2.Location = new System.Drawing.Point(25, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 94);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sales Return";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salesBtn
            // 
            this.salesBtn.BackColor = System.Drawing.Color.Red;
            this.salesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.salesBtn.FlatAppearance.BorderSize = 3;
            this.salesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salesBtn.Image = global::sms.Properties.Resources.r;
            this.salesBtn.Location = new System.Drawing.Point(25, 374);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(219, 89);
            this.salesBtn.TabIndex = 4;
            this.salesBtn.Text = "Sales";
            this.salesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.salesBtn.UseVisualStyleBackColor = false;
            this.salesBtn.Click += new System.EventHandler(this.salesBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.productBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.productBtn.FlatAppearance.BorderSize = 3;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.productBtn.Image = global::sms.Properties.Resources._0;
            this.productBtn.Location = new System.Drawing.Point(25, 88);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(219, 86);
            this.productBtn.TabIndex = 1;
            this.productBtn.Text = "Products";
            this.productBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.productBtn.UseVisualStyleBackColor = false;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // priceBtn
            // 
            this.priceBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.priceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.priceBtn.FlatAppearance.BorderSize = 3;
            this.priceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.priceBtn.Image = global::sms.Properties.Resources._5;
            this.priceBtn.Location = new System.Drawing.Point(25, 180);
            this.priceBtn.Name = "priceBtn";
            this.priceBtn.Size = new System.Drawing.Size(219, 90);
            this.priceBtn.TabIndex = 5;
            this.priceBtn.Text = "Product pricing";
            this.priceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.priceBtn.UseVisualStyleBackColor = false;
            this.priceBtn.Click += new System.EventHandler(this.priceBtn_Click);
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.purchaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.purchaseBtn.FlatAppearance.BorderSize = 3;
            this.purchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.purchaseBtn.Image = global::sms.Properties.Resources.w;
            this.purchaseBtn.Location = new System.Drawing.Point(25, 276);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(219, 92);
            this.purchaseBtn.TabIndex = 3;
            this.purchaseBtn.Text = "Purchase Invoice";
            this.purchaseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.purchaseBtn.UseVisualStyleBackColor = false;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sms.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(205, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::sms.Properties.Resources._123;
            this.button1.Location = new System.Drawing.Point(397, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 83);
            this.button1.TabIndex = 21;
            this.button1.Text = "Calculator";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Web
            // 
            this.Web.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Web.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Web.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Web.FlatAppearance.BorderSize = 3;
            this.Web.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Web.ForeColor = System.Drawing.Color.Black;
            this.Web.Image = global::sms.Properties.Resources.web;
            this.Web.Location = new System.Drawing.Point(499, 4);
            this.Web.Name = "Web";
            this.Web.Size = new System.Drawing.Size(96, 83);
            this.Web.TabIndex = 20;
            this.Web.Text = "Web";
            this.Web.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Web.UseVisualStyleBackColor = false;
            this.Web.Click += new System.EventHandler(this.Web_Click);
            // 
            // userBtn
            // 
            this.userBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userBtn.BackgroundImage = global::sms.Properties.Resources._12;
            this.userBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.userBtn.FlatAppearance.BorderSize = 3;
            this.userBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.Black;
            this.userBtn.Location = new System.Drawing.Point(896, 4);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(87, 82);
            this.userBtn.TabIndex = 0;
            this.userBtn.Text = "Users";
            this.userBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.userBtn.UseVisualStyleBackColor = false;
            this.userBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutbtn.FlatAppearance.BorderSize = 2;
            this.logoutbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logoutbtn.Image = global::sms.Properties.Resources.powersx;
            this.logoutbtn.Location = new System.Drawing.Point(989, 4);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(79, 82);
            this.logoutbtn.TabIndex = 19;
            this.logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::sms.Properties.Resources._15;
            this.button4.Location = new System.Drawing.Point(798, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 83);
            this.button4.TabIndex = 8;
            this.button4.Text = "Suppliers";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // catBtn
            // 
            this.catBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.catBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.catBtn.FlatAppearance.BorderSize = 3;
            this.catBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catBtn.ForeColor = System.Drawing.Color.Black;
            this.catBtn.Image = global::sms.Properties.Resources._14;
            this.catBtn.Location = new System.Drawing.Point(601, 4);
            this.catBtn.Name = "catBtn";
            this.catBtn.Size = new System.Drawing.Size(96, 83);
            this.catBtn.TabIndex = 7;
            this.catBtn.Text = "Categories";
            this.catBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.catBtn.UseVisualStyleBackColor = false;
            this.catBtn.Click += new System.EventHandler(this.catBtn_Click);
            // 
            // stockBtn
            // 
            this.stockBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.stockBtn.FlatAppearance.BorderSize = 3;
            this.stockBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockBtn.ForeColor = System.Drawing.Color.Black;
            this.stockBtn.Image = global::sms.Properties.Resources._13;
            this.stockBtn.Location = new System.Drawing.Point(703, 4);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(89, 83);
            this.stockBtn.TabIndex = 2;
            this.stockBtn.Text = "Stocks";
            this.stockBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stockBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stockBtn.UseVisualStyleBackColor = false;
            this.stockBtn.Click += new System.EventHandler(this.stockBtn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button catBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button priceBtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Web;
        private System.Windows.Forms.Button button1;
    }
}