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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void txt_Firstname_Validating(object sender, CancelEventArgs e)
        {
            if(txt_Firstname.Text == string.Empty)
            {
                lbl_FirstnameValidation.Text = "Firstname is Requited";
            }
        }
    }
}
