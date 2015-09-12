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
    public partial class DoOrder : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public DoOrder()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\sr comtech\Documents\Visual Studio 2015\Projects\EuipmentRentApp\EuipmentRentApp\App_Data\Database\OfficeStoreSystem.accdb;
Persist Security Info=False;";
        }
        private void DoOrder_Load(object sender, EventArgs e)
        {
            try
            {
                //combine data from databse to combobox or dropdownlist
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select itemname,amount from  ItemData";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["itemname"].Value.ToString();
                textBox2.Text = row.Cells["amount"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox3.Text) > Int32.Parse(textBox2.Text))
                MessageBox.Show("your input must less than " + textBox2.Text);
            else
                richTextBox2.AppendText(textBox1.Text + " " + textBox3.Text + "\n");
            try
            {
                //combine data from databse to combobox or dropdownlist
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select itemname,amount from  ItemData";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //combine data from databse to combobox or dropdownlist
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from OrderData where ID=" + 12 + "";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                connection.Close();
                foreach (DataRow row in dt.Rows)
                {
                    richTextBox1.Text = row["orderlist"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                //combine data from databse to combobox or dropdownlist
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from OrderData";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show(dt.Rows.Count + 1 + "");
                connection.Close();

            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID;
            try
            {
                //combine data from databse to combobox or dropdownlist
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into OrderData(orderlist) values('" + richTextBox2.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //MessageBox.Show(richTextBox2.Text);
          
        }
    }
}



