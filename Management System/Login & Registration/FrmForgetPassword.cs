using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login___Registration
{
    public partial class FrmForgetPassword : Form
    {
        public FrmForgetPassword()
        {
            InitializeComponent();
        }

        private void FrmForgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void Registration_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OTP is 1234");
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin Back = new FormLogin();
            Back.Show();
        }
    }
}
