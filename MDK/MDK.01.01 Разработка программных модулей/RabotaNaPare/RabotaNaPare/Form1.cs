using StatusApp;

namespace RabotaNaPare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Status));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) { 
                Status meow = (Status)comboBox1.SelectedItem;
                switch (meow)
                {
                    case Status.New: label1.Text = "����� ������ ��� ������"; break;
                    case Status.Processing: label1.Text = "����� � �������� ��������"; break;
                    case Status.Cancelled: label1.Text = "����� ������� ��������"; break;
                    case Status.Returned: label1.Text = "����� ��� ��������� ��������"; break;
                    case Status.Delivered: label1.Text = "����� ��������� �������"; break;
                    case Status.Shipped: label1.Text = "����� ��������� �������"; break;
                    default: label1.Text = "������ ������ �� ������"; break;
                }
            }
        }
    }
}
