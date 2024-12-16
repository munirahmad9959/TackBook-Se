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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            textBox5 = new TextBox();
            button4 = new Button();
            label8 = new Label();
            comboBox2 = new ComboBox();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 4);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "TACBOOK";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(259, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(398, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(259, 154);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(520, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 125);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 8;
            label2.Text = "Book Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(141, 125);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 9;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(259, 125);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 10;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(398, 125);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 11;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(520, 125);
            label6.Name = "label6";
            label6.Size = new Size(39, 17);
            label6.TabIndex = 12;
            label6.Text = "Price";
            // 
            // button1
            // 
            button1.BackColor = Color.BlueViolet;
            button1.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(126, 202);
            button1.Name = "button1";
            button1.Size = new Size(105, 44);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.BlueViolet;
            button2.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(261, 200);
            button2.Name = "button2";
            button2.Size = new Size(105, 44);
            button2.TabIndex = 14;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.BlueViolet;
            button3.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(399, 200);
            button3.Name = "button3";
            button3.Size = new Size(105, 44);
            button3.TabIndex = 15;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 278);
            label7.Name = "label7";
            label7.Size = new Size(113, 17);
            label7.TabIndex = 16;
            label7.Text = "Category Name";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(171, 278);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 23);
            textBox5.TabIndex = 17;
            // 
            // button4
            // 
            button4.BackColor = Color.BlueViolet;
            button4.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(366, 267);
            button4.Name = "button4";
            button4.Size = new Size(105, 40);
            button4.TabIndex = 18;
            button4.Text = "Create";
            button4.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(249, 335);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 19;
            label8.Text = "BOOKS LIST";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = Color.Gray;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(218, 370);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(174, 25);
            comboBox2.TabIndex = 20;
            comboBox2.Text = "Filter by Category";
            // 
            // button5
            // 
            button5.BackColor = Color.BlueViolet;
            button5.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(456, 361);
            button5.Name = "button5";
            button5.Size = new Size(105, 40);
            button5.TabIndex = 21;
            button5.Text = "Reset";
            button5.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 439);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(613, 150);
            dataGridView1.TabIndex = 22;
            // 
            // BookUserControlBody
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "BookUserControlBody";
            Size = new Size(645, 590);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
        private TextBox textBox5;
        private Button button4;
        private Label label8;
        private ComboBox comboBox2;
        private Button button5;
        private DataGridView dataGridView1;
    }
}
