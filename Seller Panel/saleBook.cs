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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate that textboxes are not empty
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Please fill in all the fields: Book Name, Quantity, Client Name, and Price.",
                                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if validation fails
                }

                // Parse data from textboxes
                string bookTitle = textBox1.Text;
                string quantity = textBox2.Text;
                string clientName = textBox3.Text;
                string price = textBox4.Text;

                // Now you can use the `key` (which contains the selected book ID) to perform actions.
                if (key == 0) // Check if a valid book ID was selected
                {
                    MessageBox.Show("Please select a book from the list first.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Continue with your existing logic to add data to dataGridView2 or save to the database
                DataTable dataTable;

                if (dataGridView2.DataSource == null)
                {
                    // Initialize the DataTable with existing columns
                    dataTable = new DataTable();
                    dataTable.Columns.Add("ID");         // Assuming ID is auto-generated
                    dataTable.Columns.Add("Books");
                    dataTable.Columns.Add("Quantity");
                    dataTable.Columns.Add("Client Name");
                    dataTable.Columns.Add("Price");

                    // Set DataTable as DataSource for dataGridView2
                    dataGridView2.DataSource = dataTable;
                }
                else
                {
                    // If DataSource exists, fetch it as DataTable
                    dataTable = (DataTable)dataGridView2.DataSource;
                }

                // Add data from textboxes to the DataTable, using `key` as the Book ID
                dataTable.Rows.Add(key, bookTitle, quantity, clientName, price); // ID will be the `key`

                // Clear textboxes after adding the data
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                MessageBox.Show("Data added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }
    }
}
