namespace _2_Practik
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
            cmdMas = new Button();
            cmdStart = new Button();
            cmdEnd = new Button();
            txtn = new TextBox();
            txtm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmdMas
            // 
            cmdMas.Location = new Point(33, 258);
            cmdMas.Name = "cmdMas";
            cmdMas.Size = new Size(147, 48);
            cmdMas.TabIndex = 0;
            cmdMas.Text = "Ввод массива";
            cmdMas.UseVisualStyleBackColor = true;
            cmdMas.Click += cmdMas_Click;
            // 
            // cmdStart
            // 
            cmdStart.Location = new Point(302, 258);
            cmdStart.Name = "cmdStart";
            cmdStart.Size = new Size(147, 48);
            cmdStart.TabIndex = 1;
            cmdStart.Text = "Вычислить";
            cmdStart.UseVisualStyleBackColor = true;
            cmdStart.Click += cmdStart_Click;
            // 
            // cmdEnd
            // 
            cmdEnd.Location = new Point(564, 258);
            cmdEnd.Name = "cmdEnd";
            cmdEnd.Size = new Size(147, 48);
            cmdEnd.TabIndex = 2;
            cmdEnd.Text = "Завершение работы";
            cmdEnd.UseVisualStyleBackColor = true;
            cmdEnd.Click += cmdEnd_Click;
            // 
            // txtn
            // 
            txtn.Location = new Point(33, 66);
            txtn.Name = "txtn";
            txtn.Size = new Size(125, 27);
            txtn.TabIndex = 3;
            // 
            // txtm
            // 
            txtm.Location = new Point(33, 169);
            txtm.Name = "txtm";
            txtm.Size = new Size(125, 27);
            txtm.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 43);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 5;
            label1.Text = "Количество строк n=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 146);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 6;
            label2.Text = "Количество столбцов m=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 234);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(239, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(530, 188);
            dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 323);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtm);
            Controls.Add(txtn);
            Controls.Add(cmdEnd);
            Controls.Add(cmdStart);
            Controls.Add(cmdMas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdMas;
        private Button cmdStart;
        private Button cmdEnd;
        private TextBox txtn;
        private TextBox txtm;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
    }
}
