namespace practik_2_1
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
            st1 = new Label();
            st2 = new Label();
            st3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            tipTreug = new Label();
            ploshad = new Label();
            cmdStart = new Button();
            cmdEnd = new Button();
            tiposhib = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(27, 50);
            label1.Name = "label1";
            label1.Size = new Size(749, 37);
            label1.TabIndex = 0;
            label1.Text = "Опредилить площадь и вид треугольника по его сторонам";
            // 
            // st1
            // 
            st1.AutoSize = true;
            st1.Font = new Font("Segoe UI", 14F);
            st1.Location = new Point(86, 125);
            st1.Name = "st1";
            st1.Size = new Size(127, 32);
            st1.TabIndex = 1;
            st1.Text = "1 Сторона";
            // 
            // st2
            // 
            st2.AutoSize = true;
            st2.Font = new Font("Segoe UI", 14F);
            st2.Location = new Point(86, 174);
            st2.Name = "st2";
            st2.Size = new Size(127, 32);
            st2.TabIndex = 2;
            st2.Text = "2 Сторона";
            // 
            // st3
            // 
            st3.AutoSize = true;
            st3.Font = new Font("Segoe UI", 14F);
            st3.Location = new Point(86, 226);
            st3.Name = "st3";
            st3.Size = new Size(127, 32);
            st3.TabIndex = 3;
            st3.Text = "3 Сторона";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 180);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(248, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 27);
            textBox3.TabIndex = 6;
            // 
            // tipTreug
            // 
            tipTreug.AutoSize = true;
            tipTreug.Font = new Font("Segoe UI", 14F);
            tipTreug.Location = new Point(86, 297);
            tipTreug.Name = "tipTreug";
            tipTreug.Size = new Size(223, 32);
            tipTreug.TabIndex = 7;
            tipTreug.Text = "Тип треугольника: ";
            // 
            // ploshad
            // 
            ploshad.AutoSize = true;
            ploshad.Font = new Font("Segoe UI", 14F);
            ploshad.Location = new Point(86, 344);
            ploshad.Name = "ploshad";
            ploshad.Size = new Size(264, 32);
            ploshad.TabIndex = 8;
            ploshad.Text = "Площадь трегольника:";
            // 
            // cmdStart
            // 
            cmdStart.Font = new Font("Segoe UI", 16F);
            cmdStart.Location = new Point(518, 131);
            cmdStart.Name = "cmdStart";
            cmdStart.Size = new Size(210, 89);
            cmdStart.TabIndex = 9;
            cmdStart.Text = "Расситать";
            cmdStart.UseVisualStyleBackColor = true;
            cmdStart.Click += cmdStart_Click;
            // 
            // cmdEnd
            // 
            cmdEnd.Font = new Font("Segoe UI", 16F);
            cmdEnd.Location = new Point(518, 272);
            cmdEnd.Name = "cmdEnd";
            cmdEnd.Size = new Size(210, 89);
            cmdEnd.TabIndex = 10;
            cmdEnd.Text = "Завершить программу";
            cmdEnd.UseVisualStyleBackColor = true;
            cmdEnd.Click += cmdEnd_Click;
            // 
            // tiposhib
            // 
            tiposhib.AutoSize = true;
            tiposhib.Font = new Font("Segoe UI", 14F);
            tiposhib.Location = new Point(86, 393);
            tiposhib.Name = "tiposhib";
            tiposhib.Size = new Size(0, 32);
            tiposhib.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tiposhib);
            Controls.Add(cmdEnd);
            Controls.Add(cmdStart);
            Controls.Add(ploshad);
            Controls.Add(tipTreug);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(st3);
            Controls.Add(st2);
            Controls.Add(st1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label st1;
        private Label st2;
        private Label st3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label tipTreug;
        private Label ploshad;
        private Button cmdStart;
        private Button cmdEnd;
        private Label tiposhib;
    }
}
