using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(btnHideShow.Text == "Show")
            {
                btnHideShow.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnHideShow.Text = "Show";
                txtPassword.PasswordChar = '*';
            }

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox.Checked == true)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled= false;
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Group_04" && txtPassword.Text == "01234")
            {
                Dashboard db = new Dashboard();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Valid Username OR Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
