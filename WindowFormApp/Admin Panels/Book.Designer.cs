namespace WinFormsApp1
{
    partial class Book
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bookUserControl1 = new BookUserControl();
            bookUserControlBody1 = new BookUserControlBody();
            SuspendLayout();
            // 
            // bookUserControl1
            // 
            bookUserControl1.BackColor = Color.Indigo;
            bookUserControl1.Location = new Point(3, 2);
            bookUserControl1.Margin = new Padding(6, 8, 6, 8);
            bookUserControl1.Name = "bookUserControl1";
            bookUserControl1.Size = new Size(337, 842);
            bookUserControl1.TabIndex = 0;
            bookUserControl1.Load += bookUserControl1_Load;
            // 
            // bookUserControlBody1
            // 
            bookUserControlBody1.BackColor = SystemColors.Control;
            bookUserControlBody1.Location = new Point(341, 2);
            bookUserControlBody1.Margin = new Padding(6, 8, 6, 8);
            bookUserControlBody1.Name = "bookUserControlBody1";
            bookUserControlBody1.Size = new Size(1101, 842);
            bookUserControlBody1.TabIndex = 1;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1445, 838);
            Controls.Add(bookUserControlBody1);
            Controls.Add(bookUserControl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book";
            ResumeLayout(false);
        }

        #endregion

        private BookUserControl bookUserControl1;
        private BookUserControlBody bookUserControlBody1;
    }
}
