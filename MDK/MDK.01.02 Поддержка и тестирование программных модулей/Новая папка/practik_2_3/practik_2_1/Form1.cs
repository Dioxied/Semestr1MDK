namespace practik_2_1
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
        double sto1, sto2, sto3, plosh, p;

        private void cmdStart_Click(object sender, EventArgs e)
        {
            try
            {
                sto1 = double.Parse(textBox1.Text);
                sto2 = double.Parse(textBox2.Text);
                sto3 = double.Parse(textBox3.Text);
                if (sto1 > 0 && sto2 > 0 && sto3 > 0)
                {
                    if (sto1 + sto2 > sto3 && sto2 + sto3 > sto1 && sto1 + sto3 > sto2)
                    {
                        p = (sto1 + sto2 + sto3) / 2;
                        plosh = Math.Sqrt((p * (p - sto1) * (p - sto2) * (p - sto3)));
                        ploshad.Text = $"Площадь трегольника: {Math.Round(plosh, 5)}";
                        if ((Math.Pow(sto1, 2) == Math.Pow(sto2, 2) + Math.Pow(sto3, 2)) || (Math.Pow(sto2, 2) == Math.Pow(sto1, 2) + Math.Pow(sto3, 2)) || (Math.Pow(sto3, 2) == Math.Pow(sto2, 2) + Math.Pow(sto1, 2)))
                        {
                            tipTreug.Text = "Тип треугольника: Прямоугольный";
                        }
                        else if ((Math.Pow(sto1, 2) > Math.Pow(sto2, 2) + Math.Pow(sto3, 2)) || (Math.Pow(sto2, 2) > Math.Pow(sto1, 2) + Math.Pow(sto3, 2)) || (Math.Pow(sto3, 2) > Math.Pow(sto1, 2) + Math.Pow(sto2, 2))) 
                        {
                            tipTreug.Text = "Тип треугольника: Тупоугольный";
                        }
                        else
                        {
                            tipTreug.Text = "Тип треугольника: Остроугольный";
                        }
                        tiposhib.Text = "";
                    }
                    else {
                        tipTreug.Text = "Тип треугольника: Ошибка!!!";
                        ploshad.Text = "Площадь трегольника: Ошибка!!!";
                        tiposhib.Text = "Тип ошибки: Неправильный треугольник!!!";
                    }
                    
                }
                else
                {
                    tipTreug.Text = "Тип треугольника: Ошибка!!!";
                    ploshad.Text = "Площадь трегольника: Ошибка!!!";
                    tiposhib.Text = "Тип ошибки: Одна из сторон меньше или равна 0!!!";
                }
            }
            catch (FormatException) {
                tipTreug.Text = "Тип треугольника: Ошибка!!!";
                ploshad.Text = "Площадь трегольника: Ошибка!!!";
                tiposhib.Text = "Тип ошибки: Посторонние символы!!!";
            }


        }
        private void cmdEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
