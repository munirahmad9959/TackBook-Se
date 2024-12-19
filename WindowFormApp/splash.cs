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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
        int startpos = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startpos += 1;
            ProgressBar.Value = startpos;
            percent_lbl.Text = startpos + "%";
            if (ProgressBar.Value == 100)
            {
                ProgressBar.Value = 0;
                timer1.Stop();
                login log = new login();
                log.Show();
                this.Hide();
            }
        }
    }
}
