namespace TaskFromLectia13
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox_radius_input = new TextBox();
            textBox_x_input = new TextBox();
            textBox_y_input = new TextBox();
            button_draw = new Button();
            textBox_radius_edit = new TextBox();
            label6 = new Label();
            button_edit_radius = new Button();
            label7 = new Label();
            label8 = new Label();
            button_check_point = new Button();
            textBox_point_y = new TextBox();
            textBox_point_x = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label_pos = new Label();
            label_radius = new Label();
            label_square = new Label();
            label_height = new Label();
            button_print_info = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(447, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(847, 488);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(739, 62);
            label1.TabIndex = 1;
            label1.Text = "Программа для рисования круга";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(213, 28);
            label2.TabIndex = 2;
            label2.Text = "Введите радиус круга:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(262, 28);
            label3.TabIndex = 3;
            label3.Text = "Введите координаты круга:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(280, 131);
            label4.Name = "label4";
            label4.Size = new Size(28, 28);
            label4.TabIndex = 4;
            label4.Text = "X:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(280, 173);
            label5.Name = "label5";
            label5.Size = new Size(27, 28);
            label5.TabIndex = 5;
            label5.Text = "Y:";
            // 
            // textBox_radius_input
            // 
            textBox_radius_input.Location = new Point(231, 91);
            textBox_radius_input.Name = "textBox_radius_input";
            textBox_radius_input.Size = new Size(125, 27);
            textBox_radius_input.TabIndex = 6;
            // 
            // textBox_x_input
            // 
            textBox_x_input.Location = new Point(314, 135);
            textBox_x_input.Name = "textBox_x_input";
            textBox_x_input.Size = new Size(125, 27);
            textBox_x_input.TabIndex = 7;
            // 
            // textBox_y_input
            // 
            textBox_y_input.Location = new Point(313, 177);
            textBox_y_input.Name = "textBox_y_input";
            textBox_y_input.Size = new Size(125, 27);
            textBox_y_input.TabIndex = 8;
            // 
            // button_draw
            // 
            button_draw.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_draw.Location = new Point(29, 165);
            button_draw.Name = "button_draw";
            button_draw.Size = new Size(231, 43);
            button_draw.TabIndex = 9;
            button_draw.Text = "Нарисовать круг";
            button_draw.UseVisualStyleBackColor = true;
            button_draw.Click += button_draw_Click;
            // 
            // textBox_radius_edit
            // 
            textBox_radius_edit.Location = new Point(248, 253);
            textBox_radius_edit.Name = "textBox_radius_edit";
            textBox_radius_edit.Size = new Size(125, 27);
            textBox_radius_edit.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 249);
            label6.Name = "label6";
            label6.Size = new Size(230, 28);
            label6.TabIndex = 11;
            label6.Text = "Изменить радиус круга:";
            // 
            // button_edit_radius
            // 
            button_edit_radius.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_edit_radius.Location = new Point(29, 286);
            button_edit_radius.Name = "button_edit_radius";
            button_edit_radius.Size = new Size(255, 39);
            button_edit_radius.TabIndex = 13;
            button_edit_radius.Text = "Изменить радиус";
            button_edit_radius.UseVisualStyleBackColor = true;
            button_edit_radius.Click += button_edit_radius_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(6, 211);
            label7.Name = "label7";
            label7.Size = new Size(396, 28);
            label7.TabIndex = 14;
            label7.Text = "________________________________________________";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(6, 328);
            label8.Name = "label8";
            label8.Size = new Size(396, 28);
            label8.TabIndex = 15;
            label8.Text = "________________________________________________";
            // 
            // button_check_point
            // 
            button_check_point.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_check_point.Location = new Point(39, 413);
            button_check_point.Name = "button_check_point";
            button_check_point.Size = new Size(317, 45);
            button_check_point.TabIndex = 16;
            button_check_point.Text = "Проверить, лежит ли точка";
            button_check_point.UseVisualStyleBackColor = true;
            button_check_point.Click += button_check_point_Click;
            // 
            // textBox_point_y
            // 
            textBox_point_y.Location = new Point(208, 380);
            textBox_point_y.Name = "textBox_point_y";
            textBox_point_y.Size = new Size(125, 27);
            textBox_point_y.TabIndex = 19;
            // 
            // textBox_point_x
            // 
            textBox_point_x.Location = new Point(49, 380);
            textBox_point_x.Name = "textBox_point_x";
            textBox_point_x.Size = new Size(125, 27);
            textBox_point_x.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(15, 380);
            label10.Name = "label10";
            label10.Size = new Size(28, 28);
            label10.TabIndex = 20;
            label10.Text = "X:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(180, 380);
            label11.Name = "label11";
            label11.Size = new Size(27, 28);
            label11.TabIndex = 21;
            label11.Text = "Y:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.Location = new Point(6, 461);
            label12.Name = "label12";
            label12.Size = new Size(396, 28);
            label12.TabIndex = 22;
            label12.Text = "________________________________________________";
            // 
            // label_pos
            // 
            label_pos.AutoSize = true;
            label_pos.Location = new Point(15, 500);
            label_pos.Name = "label_pos";
            label_pos.Size = new Size(99, 20);
            label_pos.TabIndex = 23;
            label_pos.Text = "Координаты:";
            // 
            // label_radius
            // 
            label_radius.AutoSize = true;
            label_radius.Location = new Point(15, 529);
            label_radius.Name = "label_radius";
            label_radius.Size = new Size(59, 20);
            label_radius.TabIndex = 24;
            label_radius.Text = "Радиус:";
            // 
            // label_square
            // 
            label_square.AutoSize = true;
            label_square.Location = new Point(228, 500);
            label_square.Name = "label_square";
            label_square.Size = new Size(117, 20);
            label_square.TabIndex = 25;
            label_square.Text = "Площадь круга:";
            // 
            // label_height
            // 
            label_height.AutoSize = true;
            label_height.Location = new Point(180, 529);
            label_height.Name = "label_height";
            label_height.Size = new Size(143, 20);
            label_height.TabIndex = 26;
            label_height.Text = "Длина окружности:";
            // 
            // button_print_info
            // 
            button_print_info.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_print_info.Location = new Point(28, 555);
            button_print_info.Name = "button_print_info";
            button_print_info.Size = new Size(317, 38);
            button_print_info.TabIndex = 27;
            button_print_info.Text = "Вывести информацию";
            button_print_info.UseVisualStyleBackColor = true;
            button_print_info.Click += button_print_info_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(774, 38);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 29;
            label9.Text = "Ваша точка";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 602);
            Controls.Add(label9);
            Controls.Add(button_print_info);
            Controls.Add(label_height);
            Controls.Add(label_square);
            Controls.Add(label_radius);
            Controls.Add(label_pos);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBox_point_y);
            Controls.Add(textBox_point_x);
            Controls.Add(button_check_point);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button_edit_radius);
            Controls.Add(textBox_radius_edit);
            Controls.Add(label6);
            Controls.Add(button_draw);
            Controls.Add(textBox_y_input);
            Controls.Add(textBox_x_input);
            Controls.Add(textBox_radius_input);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_radius_input;
        private TextBox textBox_x_input;
        private TextBox textBox_y_input;
        private Button button_draw;
        private TextBox textBox_radius_edit;
        private Label label6;
        private Button button_edit_radius;
        private Label label7;
        private Label label8;
        private Button button_check_point;
        private TextBox textBox_point_y;
        private TextBox textBox_point_x;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label_pos;
        private Label label_radius;
        private Label label_square;
        private Label label_height;
        private Button button_print_info;
        private Label label9;
    }
}
