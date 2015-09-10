using System;
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
    public partial class MemberLoginForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public MemberLoginForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\sr comtech\Documents\visual studio 2015\Projects\EuipmentRentApp\EuipmentRentApp\App_Data\Database\EquipmentDatabase.accdb;
Persist Security Info=False;";
        }

        private void MemberLoginForm_Load(object sender, EventArgs e)
        {
            txt_RfidNumber.Select();
            serialPort1.PortName = "COM3";
            serialPort1.Open();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
           
                connection.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from MemberData where username = '"+txt_RfidNumber.Text+"' and password='"+txt_Password.Text+"'",connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful");
                }
                else
                {
                    MessageBox.Show("Login Fail");
                }
                connection.Close();
            }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            txt_RfidNumber.AppendText(serialPort1.ReadLine());
            serialPort1.Close();
        }

        private void btn_ClearRfid_Click(object sender, EventArgs e)
        {
            txt_RfidNumber.Text = "";
            txt_Password.Text = "";
            serialPort1.PortName = "COM3";
            serialPort1.Open();
        }
    }
}

