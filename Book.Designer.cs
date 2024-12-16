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
            label1 = new Label();
            SuspendLayout();
            // 
            // bookUserControl1
            // 
            bookUserControl1.BackColor = Color.Indigo;
            bookUserControl1.Location = new Point(2, 1);
            bookUserControl1.Name = "bookUserControl1";
            bookUserControl1.Size = new Size(275, 590);
            bookUserControl1.TabIndex = 0;
            bookUserControl1.Load += bookUserControl1_Load;
            // 
            // bookUserControlBody1
            // 
            bookUserControlBody1.BackColor = SystemColors.Control;
            bookUserControlBody1.Location = new Point(273, 1);
            bookUserControlBody1.Name = "bookUserControlBody1";
            bookUserControlBody1.Size = new Size(721, 590);
            bookUserControlBody1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrchid;
            label1.Font = new Font("Elephant", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 247);
            label1.Name = "label1";
            label1.Size = new Size(85, 31);
            label1.TabIndex = 2;
            label1.Text = "Seller";
            label1.Click += label1_Click;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(909, 592);
            Controls.Add(label1);
            Controls.Add(bookUserControlBody1);
            Controls.Add(bookUserControl1);
            Name = "Book";
            Text = "Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BookUserControl bookUserControl1;
        private BookUserControlBody bookUserControlBody1;
        private Label label1;
    }
}
