using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;

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
        public static class Globals
        {
            public static string ClientName;
        }

        private void LoadBookData()
        {
            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    string query = "SELECT BId, BTitle, BAuthor, BCat, BQty, BPrice FROM BookTbl";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
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
                    return;
                }

                ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
                ServiceReference1.Order myOrder = new ServiceReference1.Order();
                myOrder.BookId = key;
                myOrder.BookName = textBox1.Text;
                myOrder.ClientName = textBox3.Text;
                Globals.ClientName = myOrder.ClientName;
               
                myOrder.Quantity = Convert.ToInt32(textBox2.Text);
                myOrder.Price = Convert.ToInt32(textBox4.Text);
                await myserver.addOrderAsync(myOrder);
                datashow();

                UpdateTotalPrice();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
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

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.IsNewRow) continue;

                if (decimal.TryParse(row.Cells["Quantity"].Value?.ToString(), out decimal quantity) &&
                    decimal.TryParse(row.Cells["Price"].Value?.ToString(), out decimal unitPrice))
                {
                    row.Cells["Price"].Value = (quantity * unitPrice).ToString();
                }
            }

            UpdateTotalPrice();
        }

        private int key = 0;
        private int stock = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["BTitle"].Value.ToString();
                    textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["BPrice"].Value.ToString();
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

            label16.Text = "TOTAL";
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

        private async void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                string query = $"INSERT INTO BillTbl (UName, ClientName, Amount) VALUES ('{sellerName.Text}', '{Globals.ClientName}', {label16.Text})";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
            GenerateReceipt();
            await myserver.resetOrdersAsync();
            datashow();

            label16.Text = "TOTAL";
        }

        private void GenerateReceipt()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files (.pdf)|.pdf",
                    DefaultExt = "pdf",
                    AddExtension = true
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string pdfPath = saveFileDialog.FileName;

                    PdfDocument pdf = new PdfDocument();
                    PdfPage page = pdf.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    page.Width = 470;
                    page.Height = 296;

                    XFont titleFont = new XFont("Arial", 14, XFontStyleEx.Bold);
                    XFont headerFont = new XFont("Arial", 12, XFontStyleEx.Bold);
                    XFont regularFont = new XFont("Arial", 10);

                    gfx.DrawString("TacBook Receipt", titleFont, XBrushes.Black, new XPoint(126, 20), XStringFormats.Center);

                    gfx.DrawString($"Date: {DateTime.Now}", regularFont, XBrushes.Black, new XPoint(200, 40));

                    string clientName = "";
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.IsNewRow) continue;
                        clientName = row.Cells["ClientName"].Value?.ToString() ?? "";
                        if (!string.IsNullOrWhiteSpace(clientName))
                        {
                            break;
                        }
                    }

                    decimal totalPrice = 0;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.IsNewRow) continue;

                        if (decimal.TryParse(row.Cells["Price"].Value?.ToString(), out decimal price))
                        {
                            totalPrice += price;
                        }
                    }

                    gfx.DrawString("Seller Details:", headerFont, XBrushes.Black, new XPoint(20, 60));
                    gfx.DrawString($"Seller Name: {sellerName.Text}", regularFont, XBrushes.Black, new XPoint(20, 80));
                    gfx.DrawString($"Client Name: {clientName}", regularFont, XBrushes.Black, new XPoint(20, 100));

                    gfx.DrawString("Invoice Details:", headerFont, XBrushes.Black, new XPoint(20, 120));

                    int rowHeight = 20;
                    int yPos = 140;

                    gfx.DrawString("Book Name", headerFont, XBrushes.Black, new XPoint(20, yPos));
                    gfx.DrawString("Quantity", headerFont, XBrushes.Black, new XPoint(120, yPos));
                    gfx.DrawString("Price", headerFont, XBrushes.Black, new XPoint(180, yPos));

                    yPos += rowHeight;

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string bookName = row.Cells["BookName"].Value?.ToString() ?? "";
                        string quantity = row.Cells["Quantity"].Value?.ToString() ?? "";
                        string price = row.Cells["Price"].Value?.ToString() ?? "";

                        gfx.DrawString(bookName, regularFont, XBrushes.Black, new XPoint(20, yPos));
                        gfx.DrawString(quantity, regularFont, XBrushes.Black, new XPoint(120, yPos));
                        gfx.DrawString(price, regularFont, XBrushes.Black, new XPoint(180, yPos));

                        yPos += rowHeight;
                    }

                    gfx.DrawString("Total Amount:", headerFont, XBrushes.Black, new XPoint(20, yPos));
                    gfx.DrawString($"${totalPrice}", regularFont, XBrushes.Black, new XPoint(120, yPos));

                    yPos += 40;
                    gfx.DrawString("Thank you for shopping with us!", regularFont, XBrushes.Black, new XPoint(126, yPos), XStringFormats.Center);

                    pdf.Save(pdfPath);

                    MessageBox.Show("Receipt generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(pdfPath) { UseShellExecute = true });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalPrice()
        {
            try
            {
                decimal totalPrice = 0;

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (decimal.TryParse(row.Cells["Price"].Value?.ToString(), out decimal price))
                    {
                        totalPrice += price;
                    }
                }

                label16.Text = totalPrice.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating total price: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}