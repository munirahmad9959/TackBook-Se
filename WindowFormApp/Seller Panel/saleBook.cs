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
    public partial class saleBook : Form
    {
        public saleBook()
        {
            InitializeComponent();
            LoadBookData();
            sellerName.Text = login.UserName;
        }

        private void LoadBookData()
        {
            try
            {
                // Establish the database connection
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    // Define the SQL query to retrieve all records from BookTbl
                    string query = "SELECT BId, BTitle, BAuthor, BCat, BQty, BPrice FROM BookTbl";

                    // Create a SqlDataAdapter to execute the query and fetch data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    // Use a DataTable to store the fetched data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the database
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // Display any errors that occur
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                   string.IsNullOrWhiteSpace(textBox2.Text) ||
                   string.IsNullOrWhiteSpace(textBox3.Text) ||
                   string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Please fill in all the fields: Book Name, Quantity, Client Name, and Price.",
                                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if validation fails
                }

                ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
                ServiceReference1.Order myOrder = new ServiceReference1.Order();
                myOrder.BookId = key;
                myOrder.BookName = textBox1.Text;
                myOrder.ClientName = textBox3.Text;
                myOrder.Quantity = Convert.ToInt32(textBox2.Text);
                myOrder.Price = Convert.ToInt32(textBox4.Text);
                await myserver.addOrderAsync(myOrder);
                datashow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void datashow()
        {
            ServiceReference1.Service1Client myclient = new ServiceReference1.Service1Client();
            BindingSource abc = new BindingSource();
            abc.DataSource = await myclient.getOrderListAsync();
            dataGridView2.DataSource = abc;
        }

        private int key = 0; // Declare the key variable at the class level (outside of the event handler)
        private int stock = 0; // Declare the stock variable at the class level (outside of the event handler)

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the click is on a valid row (not header row)
                if (e.RowIndex >= 0)
                {
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["BTitle"].Value.ToString();
                    textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["BPrice"].Value.ToString();
                    //MessageBox.Show("Clicked");
                    textBox1.Enabled = false;
                    textBox4.Enabled = false;

                    key = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["BId"].Value.ToString());
                    stock = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["BQty"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
            await myserver.resetOrdersAsync();
            datashow();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            login newform = new login();
            this.Hide();
            newform.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
