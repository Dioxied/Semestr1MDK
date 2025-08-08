namespace chislowie_metodi
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(125, 9);
            label1.Name = "label1";
            label1.Size = new Size(376, 54);
            label1.TabIndex = 0;
            label1.Text = "Численные методы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21F);
            label2.Location = new Point(94, 63);
            label2.Name = "label2";
            label2.Size = new Size(432, 47);
            label2.TabIndex = 1;
            label2.Text = "Практическая работа №2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21F);
            label3.Location = new Point(94, 110);
            label3.Name = "label3";
            label3.Size = new Size(430, 47);
            label3.TabIndex = 2;
            label3.Text = "Вариант 6: x * sin(x) - 1 = 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(12, 171);
            label4.Name = "label4";
            label4.Size = new Size(400, 35);
            label4.TabIndex = 3;
            label4.Text = "Верхняя точка графика функции: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(11, 206);
            label5.Name = "label5";
            label5.Size = new Size(399, 35);
            label5.TabIndex = 4;
            label5.Text = "Нижняя точка графика функции: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(404, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(404, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 27);
            textBox2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(11, 276);
            label6.Name = "label6";
            label6.Size = new Size(241, 35);
            label6.TabIndex = 7;
            label6.Text = "Корень уравнения: ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(82, 334);
            button1.Name = "button1";
            button1.Size = new Size(419, 70);
            button1.TabIndex = 9;
            button1.Text = "Найти корень уравнения";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(11, 241);
            label7.Name = "label7";
            label7.Size = new Size(134, 35);
            label7.TabIndex = 11;
            label7.Text = " ԑ = 0,0001";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(586, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(642, 463);
            dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "a";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 72;
            // 
            // Column2
            // 
            Column2.HeaderText = "b";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 72;
            // 
            // Column3
            // 
            Column3.HeaderText = "c";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 72;
            // 
            // Column4
            // 
            Column4.HeaderText = "|b-a|";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 72;
            // 
            // Column5
            // 
            Column5.HeaderText = "F(a)";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 72;
            // 
            // Column6
            // 
            Column6.HeaderText = "F(b)";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 72;
            // 
            // Column7
            // 
            Column7.HeaderText = "F(c)";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 72;
            // 
            // Column8
            // 
            Column8.HeaderText = "F(a)*F(c)";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 80;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 467);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label6;
        private Button button1;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}
