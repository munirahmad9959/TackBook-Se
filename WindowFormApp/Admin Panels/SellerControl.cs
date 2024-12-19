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

        private bool ValidateInput(out string errorMessage)
        {
            errorMessage = string.Empty;

            // Validate name (non-empty, alphanumeric, and length <= 50)
            if (string.IsNullOrWhiteSpace(name_TB.Text) || name_TB.Text.Length > 50)
            {
                errorMessage = "Name must be non-empty and not exceed 50 characters.";
                return false;
            }

            // Validate phone (numeric and length == 11)
            if (!long.TryParse(phone_TB.Text, out long phone) || phone_TB.Text.Length != 11 || phone < 0)
            {
                errorMessage = "Phone must be a 11-digit positive number.";
                return false;
            }

            // Validate address (non-empty and length <= 100)
            if (string.IsNullOrWhiteSpace(Adress_TB.Text) || Adress_TB.Text.Length > 100)
            {
                errorMessage = "Address must be non-empty and not exceed 100 characters.";
                return false;
            }

            // Validate password (non-empty and length >= 3)
            if (string.IsNullOrWhiteSpace(password_TB.Text) || password_TB.Text.Length < 3)
            {
                errorMessage = "Password must be at least 3 characters long.";
                return false;
            }

            return true;
        }

        private void Add_Sel_btn_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    string checkQuery = "SELECT COUNT(*) FROM SellerTbl WHERE UPhone = @Phone";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Phone", phone_TB.Text.Trim());

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("This Seller already exists!");
                        reset();
                        return;
                    }

                    string insertQuery = "INSERT INTO SellerTbl (UName, UPhone, UAdd, UPass) VALUES (@Name, @Phone, @Address, @Password)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@Name", name_TB.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@Phone", phone_TB.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@Address", Adress_TB.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@Password", password_TB.Text.Trim());

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Seller Saved Successfully!");
                    LoadSellerData();
                    reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void edit_sel_btn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a record to update!");
                return;
            }

            if (!ValidateInput(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    string fetchQuery = "SELECT UName, UPhone, UAdd, UPass FROM SellerTbl WHERE UId=@UId";
                    SqlCommand fetchCmd = new SqlCommand(fetchQuery, conn);
                    fetchCmd.Parameters.AddWithValue("@UId", key);

                    SqlDataReader reader = fetchCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string existingName = reader["UName"].ToString();
                        string existingPhone = reader["UPhone"].ToString();
                        string existingAddress = reader["UAdd"].ToString();
                        string existingPassword = reader["UPass"].ToString();
                        reader.Close();

                        if (name_TB.Text == existingName &&
                            phone_TB.Text == existingPhone &&
                            Adress_TB.Text == existingAddress &&
                            password_TB.Text == existingPassword)
                        {
                            MessageBox.Show("Add new data to update. The provided data matches the existing data.");
                            return;
                        }
                    }

                    string updateQuery = "UPDATE SellerTbl SET UName=@UName, UPhone=@UPhone, UAdd=@UAdd, UPass=@UPass WHERE UId=@UId";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);

                    updateCmd.Parameters.AddWithValue("@UName", name_TB.Text);
                    updateCmd.Parameters.AddWithValue("@UPhone", phone_TB.Text);
                    updateCmd.Parameters.AddWithValue("@UAdd", Adress_TB.Text);
                    updateCmd.Parameters.AddWithValue("@UPass", password_TB.Text);
                    updateCmd.Parameters.AddWithValue("@UId", key);

                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully");
                    LoadSellerData();
                    reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void del_sel_btn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    using (SqlConnection conn = DbConnection.GetConnection())
                    {

                        string query = "delete from SellerTbl where UId=" + key + ";";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Seller Deleted Succesfully");
                        LoadSellerData();
                        reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
