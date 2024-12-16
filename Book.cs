namespace WinFormsApp1
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void bookUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Open the SellerForm
            SellerForm newForm = new SellerForm();

            // Set the new form as the application's main form
            Application.OpenForms["Book"].Hide();
            newForm.ShowDialog();
            Application.Exit();
        }

    }
}
