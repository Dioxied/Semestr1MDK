namespace _1_Practik
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
            cmdStart = new Button();
            cmdEnd = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // cmdStart
            // 
            cmdStart.Location = new Point(423, 84);
            cmdStart.Name = "cmdStart";
            cmdStart.Size = new Size(154, 65);
            cmdStart.TabIndex = 0;
            cmdStart.Text = "Вычислить";
            cmdStart.UseVisualStyleBackColor = true;
            cmdStart.Click += cmdStart_Click;
         
            // 
            // cmdEnd
            // 
            cmdEnd.Location = new Point(424, 247);
            cmdEnd.Name = "cmdEnd";
            cmdEnd.Size = new Size(153, 65);
            cmdEnd.TabIndex = 1;
            cmdEnd.Text = "Завершение работы";
            cmdEnd.UseVisualStyleBackColor = true;
            cmdEnd.Click += cmdEnd_Click;
        
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 37);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 2;
            label1.Text = "Результаты расчета";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(24, 84);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(354, 264);
            listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 362);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(cmdEnd);
            Controls.Add(cmdStart);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdStart;
        private Button cmdEnd;
        private Label label1;
        private ListBox listBox1;
    }
}
