﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EuipmentRentApp
{
    public partial class MemberLoginWithUsername : Form
    {
        private OleDbConnection connection = new OleDbConnection();    
        public MemberLoginWithUsername()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\sr comtech\Documents\visual studio 2015\Projects\EuipmentRentApp\EuipmentRentApp\App_Data\Database\OfficeStoreSystem.accdb;
Persist Security Info=False;";
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try {
                connection.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from MemberData where username = '" + txt_Username.Text + "' and pass='" + txt_Password.Text + "'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful");
                }
                else
                {
                    MessageBox.Show("Login Fail");
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
