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
    public partial class BookUserControl : UserControl
    {
        public BookUserControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BS_Seller_Click(object sender, EventArgs e)
        {
        }

        /*Book Label in sidebar*/

        private void label4_Click(object sender, EventArgs e)
        {
            Book newForm = new Book();

            this.ParentForm?.Hide();
            newForm.Show();
        }

        /* Seller Label in sidebar*/
        private void label3_Click(object sender, EventArgs e)
        {
            SellerForm newForm = new SellerForm();

            this.ParentForm?.Hide();

            newForm.Show();
        }

        /* dashboard in sidebar*/

        private void label5_Click(object sender, EventArgs e)
        {
            dashboard newForm = new dashboard();

            this.ParentForm?.Hide();
            newForm.Show();
        }

        /* logout label in sidebar*/

        private void label6_Click(object sender, EventArgs e)
        {
            login newform = new login();
            this.ParentForm?.Hide();
            newform.Show();
        }
    }
}
