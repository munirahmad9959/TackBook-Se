﻿namespace WinFormsApp1
{
    partial class DashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardControl));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            BookStock = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            Amount_label = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            Seller_label = new Label();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(526, 5);
            label1.Name = "label1";
            label1.Size = new Size(126, 30);
            label1.TabIndex = 0;
            label1.Text = "TACBOOK";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(527, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleVioletRed;
            panel1.Controls.Add(BookStock);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(169, 218);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 195);
            panel1.TabIndex = 2;
            // 
            // BookStock
            // 
            BookStock.AutoSize = true;
            BookStock.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookStock.ForeColor = Color.White;
            BookStock.Location = new Point(12, 67);
            BookStock.Name = "BookStock";
            BookStock.Size = new Size(133, 28);
            BookStock.TabIndex = 4;
            BookStock.Text = "bkStocklbl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(163, 30);
            label2.TabIndex = 3;
            label2.Text = "BOOK STOCK";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(195, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Controls.Add(Amount_label);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(672, 218);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 195);
            panel2.TabIndex = 5;
            // 
            // Amount_label
            // 
            Amount_label.AutoSize = true;
            Amount_label.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Amount_label.ForeColor = Color.White;
            Amount_label.Location = new Point(12, 67);
            Amount_label.Name = "Amount_label";
            Amount_label.Size = new Size(136, 28);
            Amount_label.TabIndex = 4;
            Amount_label.Text = "tamountlbl";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 13);
            label5.Name = "label5";
            label5.Size = new Size(196, 30);
            label5.TabIndex = 3;
            label5.Text = "Total Amount";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(201, 19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(130, 155);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumSlateBlue;
            panel3.Controls.Add(Seller_label);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(417, 464);
            panel3.Name = "panel3";
            panel3.Size = new Size(340, 195);
            panel3.TabIndex = 5;
            // 
            // Seller_label
            // 
            Seller_label.AutoSize = true;
            Seller_label.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Seller_label.ForeColor = Color.White;
            Seller_label.Location = new Point(12, 67);
            Seller_label.Name = "Seller_label";
            Seller_label.Size = new Size(73, 28);
            Seller_label.TabIndex = 4;
            Seller_label.Text = "usrlbl";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 13);
            label7.Name = "label7";
            label7.Size = new Size(105, 30);
            label7.TabIndex = 3;
            label7.Text = "Sellers";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(195, 19);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(130, 155);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(1059, 5);
            label8.Name = "label8";
            label8.Size = new Size(34, 34);
            label8.TabIndex = 6;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "DashboardControl";
            Size = new Size(1101, 848);
            Load += DashboardControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label BookStock;
        private Label label2;
        private Panel panel2;
        private Label Amount_label;
        private Label label5;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Label Seller_label;
        private Label label7;
        private PictureBox pictureBox4;
        private Label label8;
    }
}
