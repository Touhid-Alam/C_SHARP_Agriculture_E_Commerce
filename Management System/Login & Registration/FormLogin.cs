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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            FrmSignUp f1= new FrmSignUp();
            f1.Show();
            Visible = false;
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Click(object sender, EventArgs e)
        {/*
            if(textUserName.Text=="Admin" & textPassword.Text=="Admin")

            {
                FrmSignUp f1 = new FrmSignUp();
                f1.Show();
                Visible = false;

            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmForgetPassword f3 = new FrmForgetPassword();
            f3.Show();
            Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                textPassword.UseSystemPasswordChar = true;
            }
            else textPassword.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textUserName.Clear();
            textPassword.Clear();
        }
    }
}
