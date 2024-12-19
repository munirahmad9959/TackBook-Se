namespace WinFormsApp1
{
    partial class splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ProgressBar = new ProgressBar();
            label6 = new Label();
            label1 = new Label();
            percent_lbl = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, -38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(177, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(328, 210);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(11, 313);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(596, 36);
            ProgressBar.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(292, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 30);
            label6.TabIndex = 7;
            label6.Text = "TACBOOK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(4, 282);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 27);
            label1.TabIndex = 8;
            label1.Text = "Loading...";
            // 
            // percent_lbl
            // 
            percent_lbl.AutoSize = true;
            percent_lbl.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            percent_lbl.ForeColor = Color.Navy;
            percent_lbl.Location = new Point(129, 282);
            percent_lbl.Margin = new Padding(4, 0, 4, 0);
            percent_lbl.Name = "percent_lbl";
            percent_lbl.Size = new Size(31, 27);
            percent_lbl.TabIndex = 9;
            percent_lbl.Text = "%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(584, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 34);
            label3.TabIndex = 30;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick_1;
            // 
            // splash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(620, 354);
            Controls.Add(label3);
            Controls.Add(percent_lbl);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(ProgressBar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "splash";
            Load += splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ProgressBar ProgressBar;
        private Label label6;
        private Label label1;
        private Label percent_lbl;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}