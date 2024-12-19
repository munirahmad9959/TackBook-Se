namespace WinFormsApp1
{
    partial class BookUserControlBody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookUserControlBody));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            titleTB = new TextBox();
            AuthorTB = new TextBox();
            QuanTB = new TextBox();
            comboBox1 = new ComboBox();
            PriceTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Add_btn = new Button();
            label7 = new Label();
            AddCat_tb = new TextBox();
            CreateBtn = new Button();
            label8 = new Label();
            filterCategory = new ComboBox();
            dataGridView1 = new DataGridView();
            Edit_btn = new Button();
            Delete_btn = new Button();
            resetCat_btn = new Button();
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
            label1.Click += label1_Click;
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
            // titleTB
            // 
            titleTB.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTB.Location = new Point(9, 195);
            titleTB.Margin = new Padding(4, 5, 4, 5);
            titleTB.Name = "titleTB";
            titleTB.Size = new Size(231, 34);
            titleTB.TabIndex = 2;
            // 
            // AuthorTB
            // 
            AuthorTB.Font = new Font("Century Gothic", 11F);
            AuthorTB.Location = new Point(272, 197);
            AuthorTB.Margin = new Padding(4, 5, 4, 5);
            AuthorTB.Name = "AuthorTB";
            AuthorTB.Size = new Size(207, 34);
            AuthorTB.TabIndex = 3;
            // 
            // QuanTB
            // 
            QuanTB.Font = new Font("Century Gothic", 11F);
            QuanTB.Location = new Point(751, 197);
            QuanTB.Margin = new Padding(4, 5, 4, 5);
            QuanTB.Name = "QuanTB";
            QuanTB.Size = new Size(147, 34);
            QuanTB.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.Gray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(513, 197);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 31);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "Select Category";
            // 
            // PriceTB
            // 
            PriceTB.Font = new Font("Century Gothic", 11F);
            PriceTB.Location = new Point(923, 197);
            PriceTB.Margin = new Padding(4, 5, 4, 5);
            PriceTB.Name = "PriceTB";
            PriceTB.Size = new Size(140, 34);
            PriceTB.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 165);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 8;
            label2.Text = "Book Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(272, 165);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 9;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(513, 165);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 10;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(748, 165);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 11;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(923, 165);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 23);
            label6.TabIndex = 12;
            label6.Text = "Price";
            // 
            // Add_btn
            // 
            Add_btn.BackColor = Color.BlueViolet;
            Add_btn.Cursor = Cursors.Hand;
            Add_btn.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_btn.ForeColor = SystemColors.Control;
            Add_btn.Location = new Point(278, 277);
            Add_btn.Margin = new Padding(4, 5, 4, 5);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(131, 53);
            Add_btn.TabIndex = 13;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(17, 387);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(170, 23);
            label7.TabIndex = 16;
            label7.Text = "Category Name";
            // 
            // AddCat_tb
            // 
            AddCat_tb.Font = new Font("Century Gothic", 11F);
            AddCat_tb.Location = new Point(254, 383);
            AddCat_tb.Margin = new Padding(4, 5, 4, 5);
            AddCat_tb.Name = "AddCat_tb";
            AddCat_tb.Size = new Size(228, 34);
            AddCat_tb.TabIndex = 17;
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.BlueViolet;
            CreateBtn.Cursor = Cursors.Hand;
            CreateBtn.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateBtn.ForeColor = SystemColors.Control;
            CreateBtn.Location = new Point(564, 382);
            CreateBtn.Margin = new Padding(4, 5, 4, 5);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(161, 45);
            CreateBtn.TabIndex = 18;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(447, 470);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(147, 30);
            label8.TabIndex = 19;
            label8.Text = "BOOKS LIST";
            // 
            // filterCategory
            // 
            filterCategory.Cursor = Cursors.Hand;
            filterCategory.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterCategory.ForeColor = Color.Gray;
            filterCategory.FormattingEnabled = true;
            filterCategory.Location = new Point(386, 508);
            filterCategory.Margin = new Padding(4, 5, 4, 5);
            filterCategory.Name = "filterCategory";
            filterCategory.Size = new Size(247, 33);
            filterCategory.TabIndex = 20;
            filterCategory.Text = "Filter by Category";
            filterCategory.SelectionChangeCommitted += filterCategory_SelectionChangeCommitted;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.PowderBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 587);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1051, 235);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Edit_btn
            // 
            Edit_btn.BackColor = Color.BlueViolet;
            Edit_btn.Cursor = Cursors.Hand;
            Edit_btn.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Edit_btn.ForeColor = SystemColors.Control;
            Edit_btn.Location = new Point(488, 277);
            Edit_btn.Margin = new Padding(4, 5, 4, 5);
            Edit_btn.Name = "Edit_btn";
            Edit_btn.Size = new Size(131, 53);
            Edit_btn.TabIndex = 23;
            Edit_btn.Text = "Edit";
            Edit_btn.UseVisualStyleBackColor = false;
            Edit_btn.Click += Edit_btn_Click;
            // 
            // Delete_btn
            // 
            Delete_btn.BackColor = Color.BlueViolet;
            Delete_btn.Cursor = Cursors.Hand;
            Delete_btn.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Delete_btn.ForeColor = SystemColors.Control;
            Delete_btn.Location = new Point(692, 277);
            Delete_btn.Margin = new Padding(4, 5, 4, 5);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(131, 53);
            Delete_btn.TabIndex = 24;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = false;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // resetCat_btn
            // 
            resetCat_btn.BackColor = Color.BlueViolet;
            resetCat_btn.Cursor = Cursors.Hand;
            resetCat_btn.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetCat_btn.ForeColor = SystemColors.Control;
            resetCat_btn.Location = new Point(699, 496);
            resetCat_btn.Margin = new Padding(4, 5, 4, 5);
            resetCat_btn.Name = "resetCat_btn";
            resetCat_btn.Size = new Size(161, 45);
            resetCat_btn.TabIndex = 25;
            resetCat_btn.Text = "Reset";
            resetCat_btn.UseVisualStyleBackColor = false;
            resetCat_btn.Click += resetCat_btn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(1064, 3);
            label9.Name = "label9";
            label9.Size = new Size(34, 34);
            label9.TabIndex = 26;
            label9.Text = "X";
            label9.Click += label9_Click;
            // 
            // BookUserControlBody
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(label9);
            Controls.Add(resetCat_btn);
            Controls.Add(Delete_btn);
            Controls.Add(Edit_btn);
            Controls.Add(dataGridView1);
            Controls.Add(filterCategory);
            Controls.Add(label8);
            Controls.Add(CreateBtn);
            Controls.Add(AddCat_tb);
            Controls.Add(label7);
            Controls.Add(Add_btn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PriceTB);
            Controls.Add(comboBox1);
            Controls.Add(QuanTB);
            Controls.Add(AuthorTB);
            Controls.Add(titleTB);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BookUserControlBody";
            Size = new Size(1101, 842);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox titleTB;
        private TextBox AuthorTB;
        private TextBox QuanTB;
        private ComboBox comboBox1;
        private TextBox PriceTB;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Add_btn;
        private Label label7;
        private TextBox AddCat_tb;
        private Button CreateBtn;
        private Label label8;
        private ComboBox filterCategory;
        private DataGridView dataGridView1;
        private Button Edit_btn;
        private Button Delete_btn;
        private Button resetCat_btn;
        private Label label9;
    }
}
