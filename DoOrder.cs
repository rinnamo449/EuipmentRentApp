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

            }
        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            if (txt_WantedAmount.Text == "")
            {
                MessageBox.Show("Wanted amount cant be empty");
            }
            else 
                if (Int32.Parse(txt_WantedAmount.Text) > amount)
                MessageBox.Show("your input must less than " + amount);
                     else
                        checkedListBox1.Items.Add(txt_YourItem.Text + " " + txt_WantedAmount.Text);
            txt_WantedAmount.Text = "";
        }

        private void btn_SubmitToDataBase_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (var item in checkedListBox1.Items)
            {
                sb.Append(item.ToString()).Append("\n");
            }
            
            try
            {       
                //Add new ORder To database 
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
            try
            {
                //Get OrderID
                connection.Open();
                
                OleDbDataAdapter da = new OleDbDataAdapter("select * from OrderData",connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow lastRow = dt.Rows[dt.Rows.Count - 1];
                MessageBox.Show("Your OrderID is " + lastRow["ID"]);
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems.OfType<string>().ToList())
            {
                checkedListBox1.Items.Remove(item);
            }
        }

        //delete item from list
        private void btn_deleteCheckedItem_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems.OfType<string>().ToList())
            {
                checkedListBox1.Items.Remove(item);
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



