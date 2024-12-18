namespace WinFormsApp1
{
    partial class adminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminLogin));
            Admin_passTB = new TextBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label1 = new Label();
            Back_Login_btn = new Label();
            button1 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Admin_passTB
            // 
            Admin_passTB.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Admin_passTB.Location = new Point(275, 180);
            Admin_passTB.Margin = new Padding(4, 5, 4, 5);
            Admin_passTB.Name = "Admin_passTB";
            Admin_passTB.Size = new Size(198, 32);
            Admin_passTB.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(151, 184);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 14;
            label7.Text = "Password";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(249, 82);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(263, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 30);
            label6.TabIndex = 12;
            label6.Text = "TACBOOK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(259, 56);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 16;
            label1.Text = "Admin Panel";
            // 
            // Back_Login_btn
            // 
            Back_Login_btn.AutoSize = true;
            Back_Login_btn.Cursor = Cursors.Hand;
            Back_Login_btn.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back_Login_btn.Location = new Point(272, 298);
            Back_Login_btn.Name = "Back_Login_btn";
            Back_Login_btn.Size = new Size(83, 23);
            Back_Login_btn.TabIndex = 18;
            Back_Login_btn.Text = "Cancel";
            Back_Login_btn.Click += Back_Login_btn_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(249, 234);
            button1.Name = "button1";
            button1.Size = new Size(133, 52);
            button1.TabIndex = 17;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(593, 1);
            label2.Name = "label2";
            label2.Size = new Size(34, 34);
            label2.TabIndex = 29;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // adminLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(630, 350);
            Controls.Add(label2);
            Controls.Add(Back_Login_btn);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Admin_passTB);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Admin_passTB;
        private Label label7;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label1;
        private Label Back_Login_btn;
        private Button button1;
        private Label label2;
    }
}