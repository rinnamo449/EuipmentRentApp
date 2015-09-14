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
            //load data to datagridview
            try
            {                     
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select itemname,amount from  ItemData";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                //dt.Columns.Add(new DataColumn("Selected", typeof(bool)));
                da.Fill(dt);           
                dataGridView1.DataSource = dt;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //add checkcolumn to DGV2
            DataGridViewCheckBoxColumn chkcol = new DataGridViewCheckBoxColumn();
            chkcol.Width = 80;
            chkcol.HeaderText = "check to delete";
            chkcol.Name = "chkcol";
            dgv_OrderList.Columns.Add(chkcol);
          
            var Itemcol = new DataGridViewTextBoxColumn();
            Itemcol.HeaderText = "Item";
            Itemcol.Name = "Itemcol";
            dgv_OrderList.Columns.Add(Itemcol);

            var Amountcol = new DataGridViewTextBoxColumn();
            Amountcol.HeaderText = "Amount";
            Amountcol.Name = "Amountcol";
            dgv_OrderList.Columns.Add(Amountcol);
            // set aliment and style of dgv's header
            foreach (DataGridViewColumn col in dgv_OrderList.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                col.Width = 50;
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
           //add user order to checklistbox
            if (txt_WantedAmount.Text == "")
            {
                MessageBox.Show("Wanted amount cant be empty");
            }
            else 
                if (Int32.Parse(txt_WantedAmount.Text) > amount)
                MessageBox.Show("your input must less than " + amount);
                     else
                //add order to dgv
                dgv_OrderList.Rows.Add(false, txt_YourItem.Text, txt_WantedAmount.Text);
            //checkedListBox1.Items.Add(txt_YourItem.Text + " " + txt_WantedAmount.Text);    
            txt_WantedAmount.Text = "";
        }

        private void btn_SubmitToDataBase_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (var item in checkedListBox1.Items)
            {
                sb.Append(item.ToString()).Append("\n");
            }
            foreach (DataGridViewRow row in dgv_OrderList.Rows)
            {
                sb.Append(row.Cells[1].Value.ToString()).Append(" ").Append(row.Cells[2].Value.ToString()).Append("\n");
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
                //generate OrderID
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

        //delete item from dgv_Orderlist
        private void btn_deleteCheckedItem_Click(object sender, EventArgs e)
        {
            for (int i = dgv_OrderList.Rows.Count - 1; i >= 0; i--)
            {
                if ((bool)dgv_OrderList.Rows[i].Cells[0].FormattedValue)
                {
                    dgv_OrderList.Rows.RemoveAt(i);
                }
            }   
             
        }

        
    }
}



