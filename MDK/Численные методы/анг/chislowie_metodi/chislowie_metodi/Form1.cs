using System.Drawing;

namespace chislowie_metodi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Double a, b, c, Fa, Fb, Fc, modul, FaFb;
        int row = 0;
        bool check = false;

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            double pb = b;
            modul = Math.Abs(b - a);



            while (modul > 0.0001)
            {
                c = (a + b) / 2;
                modul = Math.Abs(b - a);
                Fa = a * Math.Sin(a) - 1;
                Fb = b * Math.Sin(b) - 1;
                Fc = c * Math.Sin(c) - 1;
                FaFb = Fa * Fc;
                row += 1;
                dataGridView1.Rows.Add(1);

                dataGridView1.Rows[row - 1].Cells[0].Value = a;
                dataGridView1.Rows[row - 1].Cells[1].Value = b;
                dataGridView1.Rows[row - 1].Cells[2].Value = c;
                dataGridView1.Rows[row - 1].Cells[3].Value = modul;
                dataGridView1.Rows[row - 1].Cells[4].Value = Fa;
                dataGridView1.Rows[row - 1].Cells[5].Value = Fb;
                dataGridView1.Rows[row - 1].Cells[6].Value = Fc;
                dataGridView1.Rows[row - 1].Cells[7].Value = FaFb;
                dataGridView1.Rows[row - 1].Cells[3].Style.BackColor = System.Drawing.Color.Red;


                if (FaFb < 0) { a = a; check = true; }
                else a = c;

                if (check) b = c;
                else b = b;
                check = false;
            }
            
             dataGridView1.Rows[row - 1].Cells[3].Style.BackColor = System.Drawing.Color.Green;
             dataGridView1.Rows[row - 1].Cells[2].Style.BackColor = System.Drawing.Color.LightGreen;
             label6.Text = $"Корень уровнения: {c}";
            

        }
    }
}
