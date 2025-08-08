using System.Security.Cryptography.X509Certificates;
using classes;
namespace practik_5
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inputName.Location = new Point(-100, -100); ///28 217
            inputWeight.Location = new Point(-100, -100); //28 281
            inputDiametr.Location = new Point(-100, -100); //28 250
            inputWonSun.Location = new Point(-100, -100); //28 311
            textBox1.Location = new Point(-100, -100); //125 217
            textBox2.Location = new Point(-100, -100); //125 281
            textBox3.Location = new Point(-100, -100); //125 250
            textBox4.Location = new Point(-100, -100); //125 311
            ButCreateObj.Location = new Point(-100, -100); //287 250
            inputlabelcatch.Location = new Point(-100, -100); //160 374
            labelTask1.Location = new Point(28, 217); // 28 217

        }
        public List<Planet> listPlanet = new List<Planet>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Создать экземпляр")
            {
                inputName.Location = new Point(28, 217); ///28 217
                inputWeight.Location = new Point(28, 281); //28 281
                inputDiametr.Location = new Point(28, 250); //28 250
                inputWonSun.Location = new Point(28, 311); //28 311
                textBox1.Location = new Point(125, 217); //125 217
                textBox2.Location = new Point(125, 250); //125 281
                textBox3.Location = new Point(125, 281); //125 250
                textBox4.Location = new Point(125, 311); //125 311
                ButCreateObj.Location = new Point(287, 250); //287 250
                inputlabelcatch.Location = new Point(160, 374); //160 374
                labelTask1.Location = new Point(-100, -100);
                minimumlabel.Location = new Point(-100, -100); //28, 220
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else if (comboBox1.SelectedItem == "Наименьшее раст." && listPlanet.Count > 0)
            {
                inputName.Location = new Point(-100, -100); ///28 217
                inputWeight.Location = new Point(-100, -100); //28 281
                inputDiametr.Location = new Point(-100, -100); //28 250
                inputWonSun.Location = new Point(-100, -100); //28 311
                textBox1.Location = new Point(-100, -100); //125 217
                textBox2.Location = new Point(-100, -100); //125 281
                textBox3.Location = new Point(-100, -100); //125 250
                textBox4.Location = new Point(-100, -100); //125 311
                ButCreateObj.Location = new Point(-100, -100); //287 250
                inputlabelcatch.Location = new Point(-100, -100); //160 374
                labelTask1.Location = new Point(-100, -100); // 28 217
                minimumlabel.Location = new Point(28, 220); //28, 220

                double rast = double.PositiveInfinity;
                string namerast = "";
                foreach (var i in listPlanet)
                {
                    if (i.wonSun < rast)
                    {
                        rast = i.wonSun;
                        namerast = i.name;
                    }
                }
                
                minimumlabel.Text = $"Минимальное расстояние до Солнца у планеты {namerast}, а именно - {rast} км.";
            }
            else if (comboBox1.SelectedItem != "Создать экземпляр" && comboBox2.SelectedItem == "Инфомация")
            {
                inputName.Location = new Point(-100, -100); ///28 217
                inputWeight.Location = new Point(-100, -100); //28 281
                inputDiametr.Location = new Point(-100, -100); //28 250
                inputWonSun.Location = new Point(-100, -100); //28 311
                textBox1.Location = new Point(-100, -100); //125 217
                textBox2.Location = new Point(-100, -100); //125 281
                textBox3.Location = new Point(-100, -100); //125 250
                textBox4.Location = new Point(-100, -100); //125 311
                ButCreateObj.Location = new Point(-100, -100); //287 250
                inputlabelcatch.Location = new Point(-100, -100); //160 374
                labelTask1.Location = new Point(28, 217); // 28 217
                minimumlabel.Location = new Point(-100, -100); //28, 220

                var nameplanet = Convert.ToString(comboBox1.SelectedItem);
                foreach(var i in listPlanet)
                {
                    if (nameplanet == i.name) {
                        labelTask1.Text = i.PrintInfo();
                    }
                }
            }
            else if (comboBox1.SelectedItem != "Создать экземпляр" && comboBox2.SelectedItem == "Расстояние до солнца")
            {
                inputName.Location = new Point(-100, -100); ///28 217
                inputWeight.Location = new Point(-100, -100); //28 281
                inputDiametr.Location = new Point(-100, -100); //28 250
                inputWonSun.Location = new Point(-100, -100); //28 311
                textBox1.Location = new Point(-100, -100); //125 217
                textBox2.Location = new Point(-100, -100); //125 281
                textBox3.Location = new Point(-100, -100); //125 250
                textBox4.Location = new Point(-100, -100); //125 311
                ButCreateObj.Location = new Point(-100, -100); //287 250
                inputlabelcatch.Location = new Point(-100, -100); //160 374
                labelTask1.Location = new Point(28, 217); // 28 217
                minimumlabel.Location = new Point(-100, -100); //28, 220

                var nameplanet = Convert.ToString(comboBox1.SelectedItem);
                foreach (var i in listPlanet)
                {
                    if (nameplanet == i.name)
                    {
                        labelTask1.Text = i.PrintWonSun();
                    }
                }
            }

        }

        private void ButCreateObj_Click(object sender, EventArgs e)
        {
            bool chk = false;
            try
            {
                Planet planeta = new Planet();
                if (Convert.ToDouble(textBox2.Text) < 0 || Convert.ToDouble(textBox3.Text) < 0 || Convert.ToDouble(textBox4.Text) < 0)
                {
                    chk = true;
                    listPlanet[-1] = planeta;
                }
                planeta.name = textBox1.Text;
                planeta.diametr = Convert.ToDouble(textBox2.Text);
                planeta.weight = Convert.ToDouble(textBox3.Text);
                planeta.wonSun = Convert.ToDouble(textBox4.Text);
                listPlanet.Add(planeta);

                inputName.Location = new Point(-100, -100); ///28 217
                inputWeight.Location = new Point(-100, -100); //28 281
                inputDiametr.Location = new Point(-100, -100); //28 250
                inputWonSun.Location = new Point(-100, -100); //28 311
                textBox1.Location = new Point(-100, -100); //125 217
                textBox2.Location = new Point(-100, -100); //125 281
                textBox3.Location = new Point(-100, -100); //125 250
                textBox4.Location = new Point(-100, -100); //125 311
                ButCreateObj.Location = new Point(-100, -100); //287 250
                inputlabelcatch.Location = new Point(-100, -100);
                labelTask1.Location = new Point(28, 217);
                comboBox1.Items.Add(planeta.name);
                inputlabelcatch.Text = "";
            }
            catch
            {
                if (chk)
                {
                    inputlabelcatch.Text = "Обнаружены отрицательные значения!!!";
                    chk = false;
                }
                else
                {
                    inputlabelcatch.Text = "Обнаружены неверные символы!!";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem != "Создать экземпляр" && comboBox1.SelectedItem != "Наименьшее раст.")
            {
                comboBox2.Items.Add("Инфомация");
                comboBox2.Items.Add("Расстояние до солнца");
            }
            else
            {
                comboBox2.Items.Clear();
            }
        }
    }
}
