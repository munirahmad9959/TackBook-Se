namespace WinFormsApp1
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dashboardControl1 = new DashboardControl();
            bookUserControl1 = new BookUserControl();
            SuspendLayout();
            // 
            // dashboardControl1
            // 
            dashboardControl1.BackColor = Color.Azure;
            dashboardControl1.Location = new Point(326, -2);
            dashboardControl1.Name = "dashboardControl1";
            dashboardControl1.Size = new Size(1154, 852);
            dashboardControl1.TabIndex = 1;
            // 
            // bookUserControl1
            // 
            bookUserControl1.BackColor = Color.Indigo;
            bookUserControl1.Location = new Point(-1, -2);
            bookUserControl1.Margin = new Padding(4, 5, 4, 5);
            bookUserControl1.Name = "bookUserControl1";
            bookUserControl1.Size = new Size(397, 1406);
            bookUserControl1.TabIndex = 2;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1425, 844);
            Controls.Add(bookUserControl1);
            Controls.Add(dashboardControl1);
            Name = "dashboard";
            Text = "dashboard";
            ResumeLayout(false);
        }

        #endregion
        private DashboardControl dashboardControl1;
        private BookUserControl bookUserControl1;
    }
}