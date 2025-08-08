using System.Security.Cryptography.X509Certificates;
using TaskFromLectia13;
using static System.Net.Mime.MediaTypeNames;
namespace TaskFromLectia13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label9.Location = new Point(-100, -100);
        }
        private Ellipse krug;
        private Graphics e;
        
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button_draw_Click(object sender, EventArgs e)
        {
            drawEllipse();

        }
        public void drawEllipse()
        {
            try
            {
                int text_radius = Convert.ToInt32(textBox_radius_input.Text);
                int text_x = Convert.ToInt32(textBox_x_input.Text);
                int text_y = Convert.ToInt32(textBox_y_input.Text);
                this.krug = new Ellipse(text_radius, text_x, text_y);
            }
            catch
            {
                this.krug = new Ellipse();
            }
            this.e = pictureBox1.CreateGraphics();
            e.Clear(Color.White);
            e.DrawEllipse(Pens.Black, 423 + krug.x - krug.radius / 2, 244 - krug.y - krug.radius / 2, krug.radius, krug.radius);
        }
        public void egitdrawEllipse()
        {
            int text_radius = Convert.ToInt32(textBox_radius_edit.Text);
            this.krug.radius = text_radius;
            this.e.Clear(Color.White);
            e.DrawEllipse(Pens.Black, 423 + krug.x - krug.radius / 2, 244 - krug.y - krug.radius / 2, krug.radius, krug.radius);
        }

        private void button_edit_radius_Click(object sender, EventArgs e)
        {
            egitdrawEllipse();
        }

        private void button_print_info_Click(object sender, EventArgs e)
        {
            string text_pos = this.krug.GetInfoPos();
            string text_radius = this.krug.GetInfoRadius();
            string text_squale = this.krug.GetSquare();
            string text_height = this.krug.GetHeight();

            label_pos.Text = $"Координаты: {text_pos}";
            label_radius.Text = $"Радиус: {text_radius}";
            label_square.Text = $"Площадь: {text_squale}";
            label_height.Text = $"Длина круга: {text_height}";
        }

        private void checkPoint()
        {
            int x = Convert.ToInt32(textBox_point_x.Text);
            int y = Convert.ToInt32(textBox_point_y.Text);

            this.e.DrawEllipse(Pens.Red, 423 + x, 244 + y, 10, 10);
            label9.Location = new Point(447 + 423 + x - 39, 87 + 244 + y + 15);
        }

        private void button_check_point_Click(object sender, EventArgs e)
        {
            checkPoint();
        }

        private void returnAll()
        {

        }
    }
}
