using Microsoft.Data.SqlClient;
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
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                        SqlCommand command = new SqlCommand("SELECT SUM(BQty) FROM BookTbl", connection);
                        object result = command.ExecuteScalar();
                        BookStock.Text = (result != DBNull.Value) ? result.ToString() : "0";
                        SqlCommand command1 = new SqlCommand("select sum(Amount) from BillTbl", connection);
                        object result1 = command1.ExecuteScalar();
                        Amount_label.Text = (result1 != DBNull.Value) ? result1.ToString() : "0";
                        SqlCommand command2 = new SqlCommand("select count(*) from SellerTbl", connection);
                        object result2 = command2.ExecuteScalar();
                        Seller_label.Text = (result2 != DBNull.Value) ? result2.ToString() : "0";
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
