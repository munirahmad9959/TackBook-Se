using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Admin_passTB.Text == "Admin")
            {
                Book book = new Book();
                this.Hide();
                book.Show();
            }
            else if (Admin_passTB.Text == "")
            {
                MessageBox.Show("Please Enter the Password");
            }
            else
            {
                MessageBox.Show("Invalid Password");
                Admin_passTB.Text = string.Empty;
            }
        }

        private void Back_Login_btn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }
    }
}
