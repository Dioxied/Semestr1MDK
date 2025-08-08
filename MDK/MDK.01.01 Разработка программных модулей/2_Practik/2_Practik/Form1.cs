namespace _2_Practik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int n; //Количество строк
        int m; //Количество столбцов
        int[,] A;

        private void cmdMas_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(txtn.Text);
            m = Convert.ToInt32(txtm.Text);
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            for (int j = 0; j <= m - 1; j++) {
                dataGridView1.Columns[j].Width = 80;
            }
        }
        private void cmdStart_Click(object sender, EventArgs e)
        {
            //float nn = 0; //Количество положительных
            //float summ = 0; // Сумма элементов
            //float sr;
            //A = new int[n, m];
            //for (int i = 0; i <= n - 1; ++i)
            //{
            //    for (int j = 0; j <= m - 1; ++j)
            //    {
            //        A[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
            //    }
            //}
            //for (int i = 0; i <= n - 1; ++i) { 
            //    for (int j = 0; j <= m - 1; ++j)
            //    {
            //        if (A[i, j] > 0)
            //        {
            //            summ = summ + A[i, j];
            //            nn = nn + 1;
            //        }
            //    }
            //}
            //sr = summ / nn;
            //label3.Text = "Среднее арифмитическое = " +  sr;

            int CountNull = 0;
            double[,] A = new double[n, m];
            label3.Text = "Индексы найденных нулей: ";
            for (int i = 0; i <= n - 1; ++i)
            {
                for (int j = 0; j <= m - 1; ++j)
                {
                    double urav = (i - j) / (2.5 * Math.Pow(i, 2) + j + 1);
                    if (urav == 0)
                    {
                        CountNull++;
                        A[i, j] = 10;
                        dataGridView1.Rows[i].Cells[j].Value = 10;
                        label3.Text += $" {i}:{j};";
                    }
                    else { 
                        A[i, j] = urav;
                        dataGridView1.Rows[i].Cells[j].Value = urav;
                    }
                    
                    
                }
            }
            label3.Text += $" Всего найденных нулей: {CountNull}; Все нули заменены на 10";
            
        }

        private void cmdEnd_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
