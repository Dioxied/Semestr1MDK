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
                    case Status.New: label1.Text = "Заказ только что создан"; break;
                    case Status.Processing: label1.Text = "Заказ в процессе доставки"; break;
                    case Status.Cancelled: label1.Text = "Заказ отменен клиентом"; break;
                    case Status.Returned: label1.Text = "Заказ был возвращен клиентом"; break;
                    case Status.Delivered: label1.Text = "Заказ доставлен клиенту"; break;
                    case Status.Shipped: label1.Text = "Заказ отправлен клиенту"; break;
                    default: label1.Text = "Статус заказа не выбран"; break;
                }
            }
        }
    }
}
