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
            textBox1.Location = new Point(-100, -100); //165 217
            textBox2.Location = new Point(-100, -100); //165 281
            textBox3.Location = new Point(-100, -100); //184 250
            textBox4.Location = new Point(-100, -100); //165 311
            ButCreateObj.Location = new Point(-100, -100); //325 250
            inputlabelcatch.Location = new Point(-100, -100); //160 374
            labelTask1.Location = new Point(28, 217); // 28 217
            rashodtasklabel1.Location = new Point(-100, -100); //28 217
            rashodtasklabel2.Location = new Point(-100, -100); //28 281
            rashodtasktextbox.Location = new Point(-100, -100); //165 217

        }
        public List<Car> listCar = new List<Car>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Создать экземпляр")
            {
                inputName.Location = new Point(28, 217); ///28 217
                inputWeight.Location = new Point(28, 281); //28 281
                inputDiametr.Location = new Point(28, 250); //28 250
                inputWonSun.Location = new Point(28, 311); //28 311
                textBox1.Location = new Point(165, 217); //125 217
                textBox2.Location = new Point(165, 250); //125 281
                textBox3.Location = new Point(184, 281); //125 250
                textBox4.Location = new Point(165, 311); //125 311
                ButCreateObj.Location = new Point(325, 250); //287 250
                inputlabelcatch.Location = new Point(160, 374); //160 374
                labelTask1.Location = new Point(-100, -100);
                minimumlabel.Location = new Point(-100, -100); //28, 220
                rashodtasklabel1.Location = new Point(-100, -100); //28 217
                rashodtasklabel2.Location = new Point(-100, -100); //28 281
                rashodtasktextbox.Location = new Point(-100, -100); //165 217
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else if (comboBox1.SelectedItem == "Наименьшее расх." && listCar.Count > 0)
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
                rashodtasklabel1.Location = new Point(-100, -217); //28 217
                rashodtasklabel2.Location = new Point(-228, -281); //28 281
                rashodtasktextbox.Location = new Point(-165, -217); //165 217

                double rast = double.PositiveInfinity;
                string namerast = "";
                string nameaut = "";
                foreach (var i in listCar)
                {
                    if (i.rashodna100 < rast)
                    {
                        rast = i.rashodna100;
                        namerast = i.name_model;
                        nameaut = i.name_author;
                    }
                }

                minimumlabel.Text = $"Минимальный расход топлива у машины {nameaut} {namerast}, а именно {rast}";
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
                rashodtasklabel1.Location = new Point(-100, -100); //28 217
                rashodtasklabel2.Location = new Point(-100, -100); //28 281
                rashodtasktextbox.Location = new Point(-100, -100); //165 217

                var nameplanet = Convert.ToString(comboBox1.SelectedItem);
                foreach (var i in listCar)
                {
                    if (nameplanet == i.name_model)
                    {
                        labelTask1.Text = i.PrintInfo();
                    }
                }
            }
            else if (comboBox1.SelectedItem != "Создать экземпляр" && comboBox2.SelectedItem == "Расход топлива")
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
                labelTask1.Location = new Point(-100, -217); // 28 217
                minimumlabel.Location = new Point(-100, -100); //28, 220
                rashodtasklabel1.Location = new Point(28, 217); //28 217
                rashodtasklabel2.Location = new Point(28, 250); //28 281
                rashodtasktextbox.Location = new Point(165, 217); //165 217

                
            }

        }

        private void ButCreateObj_Click(object sender, EventArgs e)
        {
            bool chk = false;
            try
            {
                Car planeta = new Car();
                if (Convert.ToDouble(textBox3.Text) < 0 || Convert.ToDouble(textBox4.Text) < 0)
                {
                    chk = true;
                    listCar[-1] = planeta;
                }
                planeta.name_model = textBox1.Text;
                planeta.name_author = textBox2.Text;
                planeta.silaVloshad = Convert.ToDouble(textBox3.Text);
                planeta.rashodna100 = Convert.ToDouble(textBox4.Text);
                listCar.Add(planeta);

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
                rashodtasklabel1.Location = new Point(-100, -100); //28 217
                rashodtasklabel2.Location = new Point(-100, -100); //28 281
                rashodtasktextbox.Location = new Point(-100, -100); //165 217
                comboBox1.Items.Add(planeta.name_model);
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

            if (comboBox1.SelectedItem != "Создать экземпляр" && comboBox1.SelectedItem != "Наименьшее расх.")
            {
                comboBox2.Items.Add("Инфомация");
                comboBox2.Items.Add("Расход топлива");
            }
            else
            {
                comboBox2.Items.Clear();
            }
        }

        private void rashodtasktextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                var namecar = Convert.ToString(comboBox1.SelectedItem);
                double km = Convert.ToDouble(rashodtasktextbox.Text);
                foreach (var i in listCar)
                {
                    if (namecar == i.name_model)
                    {
                        rashodtasklabel2.Text = i.PrintrashodNa100(km);
                    }
                }
            }
            catch {
                rashodtasklabel2.Text = "";
            }
        }
    }
}
