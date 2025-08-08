namespace _1_Practik
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
        private void cmdStart_Click(object sender, EventArgs e)
        {
            double x, y;// аргумент и значение функции double
            double xn = 0;// начальное значение переменной x
            double xk = 1;// конечное значение переменной x
            double dx = 0.1; //шаг изменения переменной

            double b = 2.3, l = 1.45;

            listBox1.Items.Add("-------------------------------");
            listBox1.Items.Add(" x                                  y ");
            listBox1.Items.Add("-------------------------------");

            for (x = xn; x <= xk; x = x + dx)
            {
                y = x + b * x * Math.Sin(l);
                listBox1.Items.Add(x.ToString("F2") + "\t" + "\t" + y.ToString("F3"));
            }
        }
        private void cmdEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
