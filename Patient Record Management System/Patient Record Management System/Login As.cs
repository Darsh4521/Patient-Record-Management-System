﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Record_Management_System
{
    public partial class Login_As : Form
    {
        public Login_As()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            doctorlogin dl = new doctorlogin(this);
            Hide();
            dl.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            receptionistlogin rl = new receptionistlogin(this);
            Hide();
            rl.Show();
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pharmacist ph = new pharmacist(this);
            Hide();
            ph.Show();
           
        }
    }
}
