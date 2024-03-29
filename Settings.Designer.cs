namespace sms
{
    partial class Settings
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
            this.label2 = new System.Windows.Forms.Label();
            this.Servertxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Databasetxt = new System.Windows.Forms.TextBox();
            this.UserIDtxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.INTcheckbox = new System.Windows.Forms.CheckBox();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.INTcheckbox);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.Savebutton);
            this.leftPanel.Controls.Add(this.passtxt);
            this.leftPanel.Controls.Add(this.UserIDtxt);
            this.leftPanel.Controls.Add(this.Databasetxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.Servertxt);
            this.leftPanel.Size = new System.Drawing.Size(250, 529);
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.Servertxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.Databasetxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.UserIDtxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.passtxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.Savebutton, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.INTcheckbox, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(699, 529);
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(699, 50);
            // 
            // label3
            // 
            this.userlabel.Size = new System.Drawing.Size(699, 44);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server";
            // 
            // Servertxt
            // 
            this.Servertxt.Location = new System.Drawing.Point(15, 188);
            this.Servertxt.MaxLength = 50;
            this.Servertxt.Name = "Servertxt";
            this.Servertxt.Size = new System.Drawing.Size(208, 22);
            this.Servertxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Database";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "User ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Databasetxt
            // 
            this.Databasetxt.Location = new System.Drawing.Point(15, 243);
            this.Databasetxt.MaxLength = 50;
            this.Databasetxt.Name = "Databasetxt";
            this.Databasetxt.Size = new System.Drawing.Size(208, 22);
            this.Databasetxt.TabIndex = 7;
            this.Databasetxt.TextChanged += new System.EventHandler(this.Databasetxt_TextChanged);
            // 
            // UserIDtxt
            // 
            this.UserIDtxt.Location = new System.Drawing.Point(15, 297);
            this.UserIDtxt.MaxLength = 50;
            this.UserIDtxt.Name = "UserIDtxt";
            this.UserIDtxt.Size = new System.Drawing.Size(208, 22);
            this.UserIDtxt.TabIndex = 8;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(15, 349);
            this.passtxt.MaxLength = 50;
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(208, 22);
            this.passtxt.TabIndex = 9;
            this.passtxt.UseSystemPasswordChar = true;
            // 
            // Savebutton
            // 
            this.Savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebutton.Location = new System.Drawing.Point(15, 409);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(207, 41);
            this.Savebutton.TabIndex = 10;
            this.Savebutton.Text = "SAVE";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // INTcheckbox
            // 
            this.INTcheckbox.AutoSize = true;
            this.INTcheckbox.Location = new System.Drawing.Point(15, 386);
            this.INTcheckbox.Name = "INTcheckbox";
            this.INTcheckbox.Size = new System.Drawing.Size(123, 17);
            this.INTcheckbox.TabIndex = 11;
            this.INTcheckbox.Text = "Integrated Security";
            this.INTcheckbox.UseVisualStyleBackColor = true;
            this.INTcheckbox.CheckedChanged += new System.EventHandler(this.INTcheckbox_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 529);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UserIDtxt;
        private System.Windows.Forms.TextBox Databasetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Servertxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox INTcheckbox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.TextBox passtxt;
    }
}