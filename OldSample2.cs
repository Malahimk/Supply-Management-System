﻿using System;
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
    public partial class OldSample2 : Sample
    {
        public OldSample2()
        {
            InitializeComponent();
        }

        private void Sample2_Load(object sender, EventArgs e)
        {

        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public virtual void addBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void editBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        public virtual void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

            public virtual void saveBtn_Click(object sender, EventArgs e)
            {

            }

            public virtual void deleteBtn_Click_1(object sender, EventArgs e)
            {

            }

            public virtual void searchtxt_TextChanged(object sender, EventArgs e)
            {

            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public virtual void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}