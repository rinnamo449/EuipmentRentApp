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
    public partial class SignUpForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public SignUpForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            txt_Firstname.Select();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\sr comtech\Documents\Visual Studio 2015\Projects\EuipmentRentApp\EuipmentRentApp\App_Data\Database\OfficeStoreSystem.accdb;
Persist Security Info=False;";
        }
        //Firstname & Lastname Textbox accept only letter
        private void txt_Firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_Lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if(txt_Firstname.Text != "" && txt_Lastname.Text != "" && txt_Rfidnumber.Text != "" && txt_Username.Text != "" && txt_Password.Text != "")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into MemberData(firstname,lastname,rfid_number,username,pass) values('" + txt_Firstname.Text + "','" + txt_Lastname.Text + "','"+txt_Rfidnumber.Text+"','"+txt_Username.Text+"','"+txt_Password.Text+"') ";
                    command.ExecuteNonQuery();                 
                    connection.Close();
                    MessageBox.Show("Data Saved");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Failed to Save data");
            }
        }

        private void txt_Firstname_Validating(object sender, CancelEventArgs e)
        {
            if(txt_Firstname.Text == "")
            {
                lbl_FirstnameValidation.Text = "*Firstname is required";
            }
        }

        private void txt_Lastname_Validating(object sender, CancelEventArgs e)
        {
            if (txt_Lastname.Text == "")
            {
                lbl_LastnameValidation.Text = "*Lastname is required";
            }
        }

        private void txt_Rfidnumber_Validating(object sender, CancelEventArgs e)
        {
            if (txt_Rfidnumber.Text == "")
            {
                lbl_RfidnumberValidation.Text = "*Rfidnumber is required";
            }
        }

        private void txt_Username_Validating(object sender, CancelEventArgs e)
        {
            if (txt_Username.Text == "")
            {
                lbl_UsernameValidation.Text = "*Username is required";
            }
        }

        private void txt_Password_Validating(object sender, CancelEventArgs e)
        {
            if (txt_Password.Text == "")
            {
                lbl_PasswordValidation.Text = "*Password is required";
            }
        }
    }
}
