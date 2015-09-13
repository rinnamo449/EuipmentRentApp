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
        private int  amount;
        public DoOrder()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\sr comtech\Documents\Visual Studio 2015\Projects\EuipmentRentApp\EuipmentRentApp\App_Data\Database\OfficeStoreSystem.accdb;
Persist Security Info=False;";
            
        }
        private void DoOrder_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove("");
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
                txt_YourItem.Text = row.Cells["itemname"].Value.ToString();
                amount = Int32.Parse(row.Cells["amount"].Value.ToString());
                //Amount.Text = row.Cells["amount"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txt_WantedAmount.Text) > amount)
                MessageBox.Show("your input must less than " + amount);
            else
                checkedListBox1.Items.Add(txt_YourItem.Text + " " + txt_WantedAmount.Text);
                //orderlist = textBox1.Text + " " + textBox3.Text + "\n";
                //richTextBox2.AppendText(textBox1.Text + " " + textBox3.Text + "\n");
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
                command.CommandText = "select * from OrderData where ID=" + 17 + "";
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
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (var item in checkedListBox1.Items)
            {
                sb.Append(item.ToString()).Append("\n");
            }
            MessageBox.Show(sb.ToString());
            try
            {
                //combine data from databse to combobox or dropdownlist
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into OrderData(orderlist) values('" + sb + "')";
                command.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //MessageBox.Show(richTextBox2.Text);

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //delete item from list
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems.OfType<string>().ToList())
            {
                checkedListBox1.Items.Remove(item);
            }
        }
    }
}



