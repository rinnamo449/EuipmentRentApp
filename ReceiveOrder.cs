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
        private object reader;

        public ReceiveOrder()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\sr comtech\Documents\Visual Studio 2015\Projects\EuipmentRentApp\EuipmentRentApp\App_Data\Database\OfficeStoreSystem.accdb;
Persist Security Info=False;";

        }
        //initial column to DGV here 
        private void ReceiveOrder_Load(object sender, EventArgs e)
        {
            //generate new column and add to DGV
            DataGridViewTextBoxColumn Itemcol = new DataGridViewTextBoxColumn();
            Itemcol.Width = 80;
            Itemcol.HeaderText = "Item";
            Itemcol.Name = "Itemcol";
            dgv_Orderlist.Columns.Add(Itemcol);

            //generate new column and add to DGV
            DataGridViewTextBoxColumn Amountcol = new DataGridViewTextBoxColumn();
            Amountcol.Width = 80;
            Amountcol.HeaderText = "Amount";
            Amountcol.Name = "Amountcol";
            dgv_Orderlist.Columns.Add(Amountcol);

            //Set alignment to column's header
            foreach (DataGridViewColumn col in dgv_Orderlist.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                col.Width = 50;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //clear DGV every time 
            dgv_Orderlist.Rows.Clear();
            try
            {
                //show order from to DGV
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select orderlist from OrderData where ID=" + Int32.Parse(textBox1.Text) + "";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    using (StringReader reader = new StringReader(row["orderlist"].ToString()))
                    {
                        string line;                        
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] subline = line.Split();
                            dgv_Orderlist.Rows.Add(subline[0],subline[1]);
                        }
                    } 
                }
                connection.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //caculate new amount of each updated item
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //update with new  amount
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;
                        command.CommandText = "update ItemData set amount = " + newamount + " where itemname = '" + substring[0] + "'";
                        command.ExecuteNonQuery();
                        MessageBox.Show("Update Successful");
                        connection.Close();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }

            }

        }

       
    }
}
