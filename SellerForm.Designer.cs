namespace WinFormsApp1
{
    partial class SellerForm
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
            bookUserControl1 = new BookUserControl();
            sellerControl1 = new SellerControl();
            SuspendLayout();
            // 
            // bookUserControl1
            // 
            bookUserControl1.BackColor = Color.Indigo;
            bookUserControl1.Location = new Point(0, 0);
            bookUserControl1.Name = "bookUserControl1";
            bookUserControl1.Size = new Size(306, 562);
            bookUserControl1.TabIndex = 0;
            // 
            // sellerControl1
            // 
            sellerControl1.Location = new Point(308, 2);
            sellerControl1.Name = "sellerControl1";
            sellerControl1.Size = new Size(851, 548);
            sellerControl1.TabIndex = 1;
            // 
            // SellerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 550);
            Controls.Add(sellerControl1);
            Controls.Add(bookUserControl1);
            Name = "SellerForm";
            Text = "SellerForm";
            ResumeLayout(false);
        }

        #endregion

        private BookUserControl bookUserControl1;
        private SellerControl sellerControl1;
    }
}