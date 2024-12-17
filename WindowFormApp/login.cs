using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        private void loginFormBtnLogin_Click(object sender, EventArgs e)
        {
            string username = loginformusernametxtbox.Text.Trim(); // Get username
            string password = loginformpwdtxtbox.Text.Trim();     // Get password

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verify the credentials
            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    string query = "SELECT COUNT(1) FROM SellerTbl WHERE UName = @username AND UPass = @password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            // Login successful
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            saleBook newform = new saleBook();
                            this.Hide();
                            newform.Show();
                        }
                        else
                        {
                            // Invalid credentials
                            MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
