namespace WinFormsApp1
{
    partial class BookUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookUserControl));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            BC_Dashboard = new Button();
            BC_Logout = new Button();
            BC_bookBtn = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(101, 12);
            label1.Name = "label1";
            label1.Size = new Size(129, 27);
            label1.TabIndex = 1;
            label1.Text = "Book Store";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(103, 42);
            label2.Name = "label2";
            label2.Size = new Size(87, 27);
            label2.TabIndex = 2;
            label2.Text = "System";
            // 
            // BC_Dashboard
            // 
            BC_Dashboard.BackColor = Color.Purple;
            BC_Dashboard.Font = new Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BC_Dashboard.ForeColor = SystemColors.Control;
            BC_Dashboard.Location = new Point(65, 311);
            BC_Dashboard.Name = "BC_Dashboard";
            BC_Dashboard.Size = new Size(165, 56);
            BC_Dashboard.TabIndex = 5;
            BC_Dashboard.Text = "Dashboard";
            BC_Dashboard.UseVisualStyleBackColor = false;
            // 
            // BC_Logout
            // 
            BC_Logout.BackColor = Color.Purple;
            BC_Logout.Font = new Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BC_Logout.ForeColor = SystemColors.Control;
            BC_Logout.Location = new Point(65, 387);
            BC_Logout.Name = "BC_Logout";
            BC_Logout.Size = new Size(165, 56);
            BC_Logout.TabIndex = 6;
            BC_Logout.Text = "Log Out";
            BC_Logout.UseVisualStyleBackColor = false;
            // 
            // BC_bookBtn
            // 
            BC_bookBtn.BackColor = Color.Purple;
            BC_bookBtn.Font = new Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BC_bookBtn.ForeColor = SystemColors.Control;
            BC_bookBtn.Location = new Point(65, 163);
            BC_bookBtn.Name = "BC_bookBtn";
            BC_bookBtn.Size = new Size(165, 56);
            BC_bookBtn.TabIndex = 3;
            BC_bookBtn.Text = "Books";
            BC_bookBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrchid;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(65, 231);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 61);
            panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // BookUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            Controls.Add(panel1);
            Controls.Add(BC_Logout);
            Controls.Add(BC_Dashboard);
            Controls.Add(BC_bookBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "BookUserControl";
            Size = new Size(306, 562);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button BC_Dashboard;
        private Button BC_Logout;
        private Button BC_bookBtn;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}
