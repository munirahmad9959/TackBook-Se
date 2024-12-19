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
    public partial class BookUserControlBody : UserControl
    {
        public BookUserControlBody()
        {
            InitializeComponent();
            LoadBookData();
            LoadCategory();

        }
        private void LoadCategory()
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            {

                using (SqlCommand command = new SqlCommand("SELECT CatName FROM CategTbl", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            filterCategory.Items.Add(reader["CatName"].ToString());
                            comboBox1.Items.Add(reader["CatName"].ToString());
                        }
                    }
                }
            }

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

        private void filter()
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                string query = "select * from BookTbl where BCat= '" + filterCategory.SelectedItem.ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void reset()
        {
            titleTB.Text = "";
            AuthorTB.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Select Category";
            comboBox1.ForeColor = Color.Gray;
            QuanTB.Text = "";
            PriceTB.Text = "";
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void filterCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filter();
        }

        private void resetCat_btn_Click(object sender, EventArgs e)
        {
            LoadBookData();
            filterCategory.SelectedIndex = -1;
            filterCategory.Text = "Filter by Category";
            filterCategory.ForeColor = Color.Gray;

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddCat_tb.Text))
            {
                MessageBox.Show("Category name cannot be empty!");
                return;
            }

            using (SqlConnection conn = DbConnection.GetConnection())
            {

                string checkQuery = "SELECT COUNT(*) FROM CategTbl WHERE CatName = @CatName";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@CatName", AddCat_tb.Text.Trim());

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("This category already exists!");
                    AddCat_tb.Text = "";
                }
                else
                {
                    // Insert the new category
                    string insertQuery = "INSERT INTO CategTbl (CatName) VALUES (@CatName)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@CatName", AddCat_tb.Text.Trim());
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Category Added Successfully!");
                    AddCat_tb.Text = "";
                    LoadCategory();
                }
            }
        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    titleTB.Text = dataGridView1.Rows[e.RowIndex].Cells["BTitle"].Value.ToString();
                    PriceTB.Text = dataGridView1.Rows[e.RowIndex].Cells["BPrice"].Value.ToString();
                    AuthorTB.Text = dataGridView1.Rows[e.RowIndex].Cells["BAuthor"].Value.ToString();
                    QuanTB.Text = dataGridView1.Rows[e.RowIndex].Cells["BQty"].Value.ToString();
                    comboBox1.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells["BCat"].Value.ToString();
                    if (titleTB.Text == "")
                    {
                        key = 0;
                    }
                    else
                    {

                        key = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["BId"].Value.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");

            }
        }
        private bool ValidateBookInput(out string errorMessage)
        {
            errorMessage = string.Empty;

            // Check if the quantity is a positive integer
            if (!int.TryParse(QuanTB.Text, out int quantity) || quantity <= 0)
            {
                errorMessage = "Invalid Quantity";
                return false;
            }

            // Check if the price is a decimal between 0 and 9
            if(!int.TryParse(PriceTB.Text, out int price) || price <= 0) {
          
                errorMessage = "Invalid Price!";
                return false;
            }

            return true;
        }


        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (titleTB.Text == " " || AuthorTB.Text == " " || QuanTB.Text == " " || PriceTB.Text == " " || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!");
            }
            if (!ValidateBookInput(out string validationError))
            {
                MessageBox.Show(validationError);
                return;
            }
            else
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    string query = "update BookTbl set BTitle='" + titleTB.Text + "',BAuthor='" + AuthorTB.Text + "',BCat='" + comboBox1.SelectedItem.ToString() + "',BQty=" + QuanTB.Text + ",BPrice=" + PriceTB.Text + " where BId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Updated Succesfully");
                    LoadBookData();
                    reset();

                }
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
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

                        string query = "delete from BookTbl where BId=" + key + ";";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Book Deleted Succesfully");
                        LoadBookData();
                        reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTB.Text) ||
                string.IsNullOrWhiteSpace(AuthorTB.Text) ||
                string.IsNullOrWhiteSpace(QuanTB.Text) ||
                string.IsNullOrWhiteSpace(PriceTB.Text) ||
                comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!");
                return;
            }
            if (!ValidateBookInput(out string validationError))
            {
                MessageBox.Show(validationError);
                return;
            }

            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {

                    // Check if the book with the same title, category, and author already exists
                    string checkQuery = "SELECT COUNT(*) FROM BookTbl WHERE BTitle = @Title AND BAuthor = @Author AND BCat = @Category";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Title", titleTB.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@Author", AuthorTB.Text.Trim()); // Fixed typo here
                    checkCmd.Parameters.AddWithValue("@Category", comboBox1.SelectedItem.ToString());

                    int count = (int)checkCmd.ExecuteScalar(); // Get the count of matching records

                    if (count > 0)
                    {
                        MessageBox.Show("This book already exists in the selected category and author!");
                        reset();  // Reset the fields if book exists
                        return;
                    }

                    // Insert the new book
                    string insertQuery = "INSERT INTO BookTbl (BTitle, BAuthor, BCat, BQty, BPrice) VALUES (@Title, @Author, @Category, @Quantity, @Price)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@Title", titleTB.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@Author", AuthorTB.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@Category", comboBox1.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@Quantity", int.Parse(QuanTB.Text.Trim()));
                    insertCmd.Parameters.AddWithValue("@Price", decimal.Parse(PriceTB.Text.Trim()));

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Book Saved Successfully!");
                    LoadBookData(); // Refresh the book data grid or list
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
