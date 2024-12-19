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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class SellerControl : UserControl
    {
        public SellerControl()
        {
            InitializeComponent();
            LoadSellerData();
        }
        private void reset()
        {
            name_TB.Text = "";
            phone_TB.Text = "";
            Adress_TB.Text = "";
            password_TB.Text = "";

        }
        private void LoadSellerData()
        {
            try
            {
                // Establish the database connection
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    // Define the SQL query to retrieve all records from SellerTbl
                    string query = "SELECT UId, UName, UPhone, UAdd, UPass FROM SellerTbl";

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

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    name_TB.Text = dataGridView1.Rows[e.RowIndex].Cells["UName"].Value.ToString();
                    phone_TB.Text = dataGridView1.Rows[e.RowIndex].Cells["UPhone"].Value.ToString();
                    Adress_TB.Text = dataGridView1.Rows[e.RowIndex].Cells["UAdd"].Value.ToString();
                    password_TB.Text = dataGridView1.Rows[e.RowIndex].Cells["UPass"].Value.ToString();
                    if (name_TB.Text == "")
                    {
                        key = 0;
                    }
                    else
                    {

                        key = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["UId"].Value.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");

            }
        }

        private void Add_Sel_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_TB.Text) ||
               string.IsNullOrWhiteSpace(Adress_TB.Text) ||
               string.IsNullOrWhiteSpace(password_TB.Text) ||
               string.IsNullOrWhiteSpace(phone_TB.Text))
            {
                MessageBox.Show("Missing Information!");
                return;
            }

            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {

                    // Check if the seller with the same phone already exists
                    string checkQuery = "SELECT COUNT(*) FROM SellerTbl WHERE UPhone = @Phone";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Phone", phone_TB.Text.Trim());


                    int count = (int)checkCmd.ExecuteScalar(); // Get the count of matching records

                    if (count > 0)
                    {
                        MessageBox.Show("This Seller already exists!");
                        reset();  // Reset the fields if Seller exists
                        return;
                    }

                    // Insert the new Seller
                    string insertQuery = "INSERT INTO SellerTbl (UName, UPhone, UAdd, UPass) VALUES (@Name, @Phone, @Address, @Password)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@Name", name_TB.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@Phone", phone_TB.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@Address",Adress_TB.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@Password", password_TB.Text.Trim());

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Seller Saved Successfully!");
                    LoadSellerData(); // Refresh the Seller data grid or list
                    reset();        // Reset the input fields
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
