
namespace Practik_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] list_letters = new string[5, 5] { { "A", "B", "C", "D", "E" }, { "F", "G", "H", "I", "K" }, { "L", "M", "N", "O", "P" }, { "Q", "R", "S", "T", "U" }, { "V", "W", "X", "Y", "Z" } };
        int check = 0;


        private string func_textbox1(string text)
        {
            string text_return = "";
            text = text.ToUpper();
            text = text.Replace("J", "I");
            foreach (char let in text)
            {
                if (let == ' ')
                {
                    text_return += " ";
                    continue;
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (Convert.ToChar(list_letters[i, j]) == let)
                        {
                            text_return += $"{i + 1}{j + 1}";
                        }
                    }
                }
            }
            return text_return;
        }
        private string func_textbox2(string text)
        {
            string text_return = "";
            List<string> list_digits = new List<string>();
            string texti = "";
            foreach(char i in text)
            {
                if(i == ' ')
                {
                    list_digits.Add(" ");
                    continue;
                }
                if(i == '1' || i == '2' || i == '3' || i == '4' || i == '5')
                {
                    texti += Convert.ToString(i);
                }
                if(texti.Length == 2)
                {
                    list_digits.Add(texti);
                    texti = "";
                }
            }
            foreach(string i in list_digits)
            {
                if(i == " ")
                {
                    text_return += " ";
                }
                else
                {
                    int index1 = (int)char.GetNumericValue(Convert.ToChar(i[0])) - 1;
                    int index2 = (int)char.GetNumericValue(Convert.ToChar(i[1])) - 1;

                    text_return += list_letters[index1, index2];
                }
            }
            return text_return;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (check == 0)
            {
                textBox2.Text = func_textbox1(textBox1.Text);
            }
            else
            {
                textBox2.Text = func_textbox2(textBox1.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(check == 0)
            {
                check = 1;
                label2.Text = "Введите ваш текст числами";
                label3.Text = "Ваш расшифрованный текст";
            }
            else
            {
                check = 0;
                label2.Text = "Введите ваш текст латинскими буквами";
                label3.Text = "Ваш зашифрованный текст";
            }
        }
    }
}
