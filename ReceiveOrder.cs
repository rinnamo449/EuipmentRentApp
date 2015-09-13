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
using System.IO;

namespace EuipmentRentApp
{
    public partial class ReceiveOrder : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public ReceiveOrder()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\sr comtech\Documents\Visual Studio 2015\Projects\EuipmentRentApp\EuipmentRentApp\App_Data\Database\OfficeStoreSystem.accdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //combine data from databse to combobox or dropdownlist
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select orderlist from OrderData where ID=" + Int32.Parse(textBox1.Text) + "";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    richTextBox1.Text = row["orderlist"].ToString();
                    connection.Close();

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int oldamount = 0;
            int newamount = 0;
           foreach (string line in richTextBox1.Lines)
            {
                if (line != "")
                {
                    string[] substring = line.Split();
                    try
                    {
                        connection.Open();

                        OleDbDataAdapter da = new OleDbDataAdapter("select amount from ItemData where itemname = '" + substring[0] + "'", connection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            if (dt.Rows.Count != 0)
                                oldamount = Int32.Parse(row["amount"].ToString());
                        }

                        newamount = oldamount - Int32.Parse(substring[1]);
                        connection.Close();
                        MessageBox.Show(newamount + "");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;
                        command.CommandText = "update ItemData set amount = " + newamount + " where itemname = '" + substring[0] + "'";
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }

            }

        }
    }
}
