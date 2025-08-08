using System.Reflection.Metadata;
using evaluations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace practik_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //comboBox1.DataSource = Enum.GetValues(typeof(Ocenki));
            foreach (Ocenki i in Enum.GetValues(typeof(Ocenki)))
            {
                if (Convert.ToInt32((int)i) == 0) continue;
                comboBox1.Items.Add(Convert.ToInt32((int)i));
            }
        }
        int con;
        private void button1_Click(object sender, EventArgs e)
        {
            int inx = Convert.ToInt32(comboBox1.SelectedItem);
            var con = Enum.GetValues(typeof(Ocenki)).GetValue(inx);
            switch (con)
            {
                case Ocenki.One: label2.Text = "Очень плохо"; break;
                case Ocenki.Two: label2.Text = "Плохо"; break;
                case Ocenki.Three: label2.Text = "Удовлетворительно"; break;
                case Ocenki.Four: label2.Text = "Хорошо"; break;
                case Ocenki.Five: label2.Text = "Отлично"; break;
                default: label2.Text = "Вы не выбрали оценку"; break;
            }

        }

    }
}
