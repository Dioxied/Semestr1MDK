namespace practik_5
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
            textno = new Label();
            comboBox1 = new ComboBox();
            textno3 = new Label();
            button1 = new Button();
            comboBox2 = new ComboBox();
            inputName = new Label();
            inputDiametr = new Label();
            inputWeight = new Label();
            inputWonSun = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ButCreateObj = new Button();
            labelTask1 = new Label();
            inputlabelcatch = new Label();
            minimumlabel = new Label();
            SuspendLayout();
            // 
            // textno
            // 
            textno.AutoSize = true;
            textno.Font = new Font("Segoe UI", 21F);
            textno.Location = new Point(116, 19);
            textno.Name = "textno";
            textno.Size = new Size(181, 47);
            textno.TabIndex = 0;
            textno.Text = "Задание 3";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Создать экземпляр", "Наименьшее плот." });
            comboBox1.Location = new Point(28, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(161, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textno3
            // 
            textno3.AutoSize = true;
            textno3.Font = new Font("Segoe UI", 15F);
            textno3.Location = new Point(125, 66);
            textno3.Name = "textno3";
            textno3.Size = new Size(165, 35);
            textno3.TabIndex = 4;
            textno3.Text = "Class Country";
            // 
            // button1
            // 
            button1.Location = new Point(207, 137);
            button1.Name = "button1";
            button1.Size = new Size(109, 29);
            button1.TabIndex = 5;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(28, 162);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(161, 28);
            comboBox2.TabIndex = 6;
            // 
            // inputName
            // 
            inputName.AutoSize = true;
            inputName.Location = new Point(28, 217);
            inputName.Name = "inputName";
            inputName.Size = new Size(77, 20);
            inputName.TabIndex = 7;
            inputName.Text = "Название";
            // 
            // inputDiametr
            // 
            inputDiametr.Font = new Font("Segoe UI", 7F);
            inputDiametr.Location = new Point(28, 250);
            inputDiametr.Name = "inputDiametr";
            inputDiametr.Size = new Size(91, 42);
            inputDiametr.TabIndex = 8;
            inputDiametr.Text = "Форма правления";
            // 
            // inputWeight
            // 
            inputWeight.AutoSize = true;
            inputWeight.Location = new Point(28, 281);
            inputWeight.Name = "inputWeight";
            inputWeight.Size = new Size(99, 20);
            inputWeight.TabIndex = 9;
            inputWeight.Text = "Численность";
            // 
            // inputWonSun
            // 
            inputWonSun.Location = new Point(28, 311);
            inputWonSun.Name = "inputWonSun";
            inputWonSun.Size = new Size(91, 45);
            inputWonSun.TabIndex = 10;
            inputWonSun.Text = "Площадь";
            inputWonSun.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 217);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(125, 281);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(135, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(125, 314);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(135, 27);
            textBox4.TabIndex = 14;
            // 
            // ButCreateObj
            // 
            ButCreateObj.Location = new Point(287, 250);
            ButCreateObj.Name = "ButCreateObj";
            ButCreateObj.Size = new Size(94, 51);
            ButCreateObj.TabIndex = 15;
            ButCreateObj.Text = "Создать";
            ButCreateObj.UseVisualStyleBackColor = true;
            ButCreateObj.Click += ButCreateObj_Click;
            // 
            // labelTask1
            // 
            labelTask1.AutoSize = true;
            labelTask1.Location = new Point(30, 217);
            labelTask1.Name = "labelTask1";
            labelTask1.Size = new Size(0, 20);
            labelTask1.TabIndex = 16;
            // 
            // inputlabelcatch
            // 
            inputlabelcatch.AutoSize = true;
            inputlabelcatch.ForeColor = Color.Red;
            inputlabelcatch.Location = new Point(160, 374);
            inputlabelcatch.Name = "inputlabelcatch";
            inputlabelcatch.Size = new Size(0, 20);
            inputlabelcatch.TabIndex = 17;
            // 
            // minimumlabel
            // 
            minimumlabel.AutoSize = true;
            minimumlabel.Location = new Point(28, 220);
            minimumlabel.Name = "minimumlabel";
            minimumlabel.Size = new Size(0, 20);
            minimumlabel.TabIndex = 18;
            // 
            // Form1
            // 
            ClientSize = new Size(737, 421);
            Controls.Add(minimumlabel);
            Controls.Add(inputlabelcatch);
            Controls.Add(labelTask1);
            Controls.Add(ButCreateObj);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(inputWonSun);
            Controls.Add(inputWeight);
            Controls.Add(inputDiametr);
            Controls.Add(inputName);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(textno3);
            Controls.Add(comboBox1);
            Controls.Add(textno);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textno;
        private ComboBox comboBox1;
        private Label textno3;
        private Button button1;
        private ComboBox comboBox2;
        private Label inputName;
        private Label inputDiametr;
        private Label inputWeight;
        private Label inputWonSun;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button ButCreateObj;
        private Label labelTask1;
        private Label inputlabelcatch;
        private Label minimumlabel;
    }
}
