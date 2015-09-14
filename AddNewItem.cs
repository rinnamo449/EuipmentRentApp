using System;
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
    public partial class AddNewItem : Form
    {
        string[] str = new string[] { "pen 15", "ruler 45" };
        public AddNewItem()
        {
            InitializeComponent();
        }
        

        private void AddNewItem_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Item";
            dataGridView1.Columns[1].Name = "Amount";
            
            foreach(string line in str)
            {
                string[] subline = line.Split( );
                dataGridView1.Rows.Add(subline);
            }
        }
    }
    
}
