namespace WinFormsApp1
{
    partial class SellerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerControl));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            name_TB = new TextBox();
            phone_TB = new TextBox();
            label3 = new Label();
            Adress_TB = new TextBox();
            label4 = new Label();
            password_TB = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            del_sel_btn = new Button();
            edit_sel_btn = new Button();
            Add_Sel_btn = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(466, 3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 30);
            label1.TabIndex = 0;
            label1.Text = "TACBOOK";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(479, 38);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 165);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // name_TB
            // 
            name_TB.Font = new Font("Century Gothic", 11F);
            name_TB.Location = new Point(9, 195);
            name_TB.Margin = new Padding(4, 5, 4, 5);
            name_TB.Name = "name_TB";
            name_TB.Size = new Size(198, 34);
            name_TB.TabIndex = 6;
            // 
            // phone_TB
            // 
            phone_TB.Font = new Font("Century Gothic", 11F);
            phone_TB.Location = new Point(286, 195);
            phone_TB.Margin = new Padding(4, 5, 4, 5);
            phone_TB.Name = "phone_TB";
            phone_TB.Size = new Size(198, 34);
            phone_TB.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(286, 160);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 7;
            label3.Text = "Phone";
            // 
            // Adress_TB
            // 
            Adress_TB.Font = new Font("Century Gothic", 11F);
            Adress_TB.Location = new Point(573, 198);
            Adress_TB.Margin = new Padding(4, 5, 4, 5);
            Adress_TB.Name = "Adress_TB";
            Adress_TB.Size = new Size(198, 34);
            Adress_TB.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(573, 165);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 9;
            label4.Text = "Address";
            // 
            // password_TB
            // 
            password_TB.Font = new Font("Century Gothic", 11F);
            password_TB.Location = new Point(867, 198);
            password_TB.Margin = new Padding(4, 5, 4, 5);
            password_TB.Name = "password_TB";
            password_TB.Size = new Size(198, 34);
            password_TB.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(867, 165);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 23);
            label5.TabIndex = 11;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(447, 402);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(147, 30);
            label6.TabIndex = 19;
            label6.Text = "SELLER LIST";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 478);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1060, 315);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // del_sel_btn
            // 
            del_sel_btn.BackColor = Color.BlueViolet;
            del_sel_btn.Cursor = Cursors.Hand;
            del_sel_btn.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            del_sel_btn.ForeColor = SystemColors.Control;
            del_sel_btn.Location = new Point(683, 275);
            del_sel_btn.Margin = new Padding(4, 5, 4, 5);
            del_sel_btn.Name = "del_sel_btn";
            del_sel_btn.Size = new Size(131, 53);
            del_sel_btn.TabIndex = 27;
            del_sel_btn.Text = "Delete";
            del_sel_btn.UseVisualStyleBackColor = false;
            del_sel_btn.Click += del_sel_btn_Click;
            // 
            // edit_sel_btn
            // 
            edit_sel_btn.BackColor = Color.BlueViolet;
            edit_sel_btn.Cursor = Cursors.Hand;
            edit_sel_btn.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edit_sel_btn.ForeColor = SystemColors.Control;
            edit_sel_btn.Location = new Point(479, 275);
            edit_sel_btn.Margin = new Padding(4, 5, 4, 5);
            edit_sel_btn.Name = "edit_sel_btn";
            edit_sel_btn.Size = new Size(131, 53);
            edit_sel_btn.TabIndex = 26;
            edit_sel_btn.Text = "Edit";
            edit_sel_btn.UseVisualStyleBackColor = false;
            edit_sel_btn.Click += edit_sel_btn_Click;
            // 
            // Add_Sel_btn
            // 
            Add_Sel_btn.BackColor = Color.BlueViolet;
            Add_Sel_btn.Cursor = Cursors.Hand;
            Add_Sel_btn.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_Sel_btn.ForeColor = SystemColors.Control;
            Add_Sel_btn.Location = new Point(269, 275);
            Add_Sel_btn.Margin = new Padding(4, 5, 4, 5);
            Add_Sel_btn.Name = "Add_Sel_btn";
            Add_Sel_btn.Size = new Size(131, 53);
            Add_Sel_btn.TabIndex = 25;
            Add_Sel_btn.Text = "Add";
            Add_Sel_btn.UseVisualStyleBackColor = false;
            Add_Sel_btn.Click += Add_Sel_btn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(1050, 0);
            label9.Name = "label9";
            label9.Size = new Size(34, 34);
            label9.TabIndex = 28;
            label9.Text = "X";
            label9.Click += label9_Click;
            // 
            // SellerControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(label9);
            Controls.Add(del_sel_btn);
            Controls.Add(edit_sel_btn);
            Controls.Add(Add_Sel_btn);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(password_TB);
            Controls.Add(label5);
            Controls.Add(Adress_TB);
            Controls.Add(label4);
            Controls.Add(phone_TB);
            Controls.Add(label3);
            Controls.Add(name_TB);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SellerControl";
            Size = new Size(1087, 842);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox name_TB;
        private TextBox phone_TB;
        private Label label3;
        private TextBox Adress_TB;
        private Label label4;
        private TextBox password_TB;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Button del_sel_btn;
        private Button edit_sel_btn;
        private Button Add_Sel_btn;
        private Label label9;
    }
}
