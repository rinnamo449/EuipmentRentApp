﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuipmentRentApp
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void btn_Member_Click(object sender, EventArgs e)
        {
            MemberLoginForm mlf = new MemberLoginForm();
            this.Hide();
            mlf.ShowDialog();
        }
    }
}
