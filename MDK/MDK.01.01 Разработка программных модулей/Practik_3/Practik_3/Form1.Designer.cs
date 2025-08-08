namespace Practik_3
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
            textBox1 = new TextBox();
            cmdStart = new Button();
            cmdEnd = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 18);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите свой текст здесь:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 41);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(562, 92);
            textBox1.TabIndex = 1;
            // 
            // cmdStart
            // 
            cmdStart.Location = new Point(33, 237);
            cmdStart.Name = "cmdStart";
            cmdStart.Size = new Size(124, 55);
            cmdStart.TabIndex = 2;
            cmdStart.Text = "Запустить";
            cmdStart.UseVisualStyleBackColor = true;
            cmdStart.Click += cmdStart_Click;
            // 
            // cmdEnd
            // 
            cmdEnd.Location = new Point(188, 237);
            cmdEnd.Name = "cmdEnd";
            cmdEnd.Size = new Size(124, 55);
            cmdEnd.TabIndex = 3;
            cmdEnd.Text = "Завершить работу";
            cmdEnd.UseVisualStyleBackColor = true;
            cmdEnd.Click += cmdEnd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(59, 158);
            label2.MaximumSize = new Size(500, 20);
            label2.Name = "label2";
            label2.Padding = new Padding(1);
            label2.Size = new Size(497, 20);
            label2.TabIndex = 4;
            label2.Text = "                                                                                                                                                    ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 304);
            Controls.Add(label2);
            Controls.Add(cmdEnd);
            Controls.Add(cmdStart);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button cmdStart;
        private Button cmdEnd;
        private Label label2;
    }
}
