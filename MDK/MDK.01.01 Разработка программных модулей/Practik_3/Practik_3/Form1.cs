using System.Windows.Forms.Design;

namespace Practik_3
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
        string text;
        private void loopWork()
        {
            text = text.Replace("bc", "c");
            text = "                         " + text;
            int id = text.Length - 1;
            while (true)
            {
                label2.Text = label2.Text.Substring(0, 60);
                label2.Text = text[id] + label2.Text;
                id--;
                if (id == -1)
                {
                    id = text.Length - 1;
                }
                Thread.Sleep(40);
            }
        }
        
        private void cmdStart_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            var work = new Thread(loopWork);
            work.IsBackground = true;  
            work.Start();
        }
        private void cmdEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
