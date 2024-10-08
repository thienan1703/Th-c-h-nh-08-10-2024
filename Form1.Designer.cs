namespace WinFormsApp1
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            textBox7 = new TextBox();
            label8 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(24, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 583);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(129, 470);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(273, 28);
            comboBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 289);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(273, 155);
            textBox3.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(129, 233);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(273, 27);
            textBox6.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(273, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(129, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(273, 27);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(129, 139);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(273, 27);
            textBox5.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 478);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 7;
            label7.Text = "Loại SP :";
            label7.Click += label7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã SP :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 289);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 5;
            label5.Text = "Mô tả chi tiết :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 192);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 6;
            label6.Text = "Hình ảnh :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 240);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 4;
            label4.Text = "Mô tả ngắn :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 102);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên SP :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 146);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "Đơn giá :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(24, 611);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(412, 86);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // button3
            // 
            button3.Location = new Point(312, 36);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(6, 36);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "Làm mới";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(206, 36);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(106, 36);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(456, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(876, 675);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ liệu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(17, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(833, 559);
            dataGridView1.TabIndex = 4;
            // 
            // button5
            // 
            button5.Location = new Point(776, 44);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 3;
            button5.Text = "Tìm kiếm ";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(147, 46);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(571, 27);
            textBox7.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 53);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 1;
            label8.Text = "Tìm kiếm :";
            label8.Click += label8_Click_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã SP";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên SP";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn giá";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Hình ảnh";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Mô tả ngắn";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Mô tả chi tiết ";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Loại SP";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 709);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private Label label8;
        private Button button5;
        private TextBox textBox7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
