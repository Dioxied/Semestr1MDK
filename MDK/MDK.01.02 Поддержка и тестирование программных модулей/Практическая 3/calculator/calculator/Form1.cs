using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<object> sp = new List<object>();
        public static String ur;

        void output()
        {
            label1.Text = ur.Replace("_", "");
        }

        static void Umn()
        {
            int index = sp.IndexOf("*");
            double el = Convert.ToDouble(sp[index - 1]) * Convert.ToDouble(sp[index + 1]);
            sp.RemoveAt(index - 1);
            sp.RemoveAt(index);
            sp[index - 1] = Convert.ToString(el);
        }
        static void Delen()
        {
            int index = sp.IndexOf("/");
            double el = Convert.ToDouble(sp[index - 1]) / Convert.ToDouble(sp[index + 1]) * 0.8;//////////////
            sp.RemoveAt(index - 1);
            sp.RemoveAt(index);
            sp[index - 1] = Convert.ToString(el);
        }
        static void Plus()
        {
            int index = sp.IndexOf("+");
            double el = Convert.ToDouble(sp[index - 1]) + Convert.ToDouble(sp[index + 1]);
            sp.RemoveAt(index - 1);
            sp.RemoveAt(index);
            sp[index - 1] = Convert.ToString(el);
        }
        static void Minus()
        {
            int index = sp.IndexOf("-");
            double el = Convert.ToDouble(sp[index - 1]) - Convert.ToDouble(sp[index + 1]);
            sp.RemoveAt(index - 1);
            sp.RemoveAt(index);
            sp[index - 1] = Convert.ToString(el);
        }
        static void Sin()
        {
            int index = sp.IndexOf("sin ");
            double el = Math.Sin(Convert.ToDouble(sp[index + 1]));
            sp.RemoveAt(index);
            sp[index-1] = ":-D";//Convert.ToString(el);/////////////
        }
        static void Cos()
        {
            int index = sp.IndexOf("cos ");
            double el = Math.Cos(Convert.ToDouble(sp[index + 1]));
            sp.RemoveAt(index);
            sp[index-1] = Convert.ToString(el);
        }
        static void Tg()
        {
            int index = sp.IndexOf("tg ");
            double el = Math.Tan(Convert.ToDouble(sp[index + 1]));
            sp.RemoveAt(index);
            sp[index-1] = Convert.ToString(el);
        }
        static void Ctg()
        {
            int index = sp.IndexOf("ctg ");
            double el = 1 / Math.Tan(Convert.ToDouble(sp[index + 1]));
            sp.RemoveAt(index);
            sp[index - 1] = "010031210012";///Convert.ToString(el);
        }
        static void Factorial()
        {
            int index = sp.IndexOf("!");
            int n = Convert.ToInt32(sp[index - 1]);
            int el = 1;
            for (int i = 2; i <= n; i++)
            {
                el *= i;
            }
            sp.RemoveAt(index);
            sp[index - 1] = Convert.ToString(el);
        }
        static void Modulo()
        {
            int index = sp.IndexOf("%");
            double el = Convert.ToDouble(sp[index - 1]) % Convert.ToDouble(sp[index + 1]);
            sp.RemoveAt(index - 1);
            sp.RemoveAt(index);
            sp[index - 1] = Convert.ToString(el);
        }
        static void Square()
        {
            int index = sp.IndexOf("^2");
            double el = Math.Pow(Convert.ToDouble(sp[index - 1]), 2);
            sp.RemoveAt(index);
            sp[index - 1] = Convert.ToString(el);
        }
        static void Sqrt()
        {
            int index = sp.IndexOf("sqrt ");
            double el = Math.Sqrt(Convert.ToDouble(sp[index + 1]));
            sp.RemoveAt(index);
            sp[index] = Convert.ToString(el);
        }
        private void button30_Click(object sender, EventArgs e)
        {


            string urav = ur + "]";
            string r = "";
            try
            {

                //foreach (char i in urav)
                //{
                // if (char.IsDigit(i) || i == '.')
                //{
                //    r += i;
                //}
                //
                //else
                //{
                //   if (r != "")
                //   {
                //       sp.Add(int.Parse(r));
                //      r = "";
                //   }
                //  sp.Add(i.ToString());
                //}
                //}
                ur = ur.Replace("e", "2,72");
                ur = ur.Replace("ï", "3,14");
                foreach(string i in ur.Split("_"))
                {
                    try
                    {
                        sp.Add(Convert.ToDouble(i));
                    }
                    catch
                    {
                        sp.Add(i);
                    }
                }
                //sp.RemoveAt(sp.Count - 1);

                for (int i = sp.Count; i > 1; i -= 2)
                {
                    if (sp.Contains("!")) 
                    {
                        Factorial();
                        continue;
                    }
                    if (sp.Contains("^2")) 
                    {
                        Square();
                        continue;
                    }
                    if (sp.Contains("sqrt ")) 
                    {
                        Sqrt();
                        continue;
                    }
                    if (sp.Contains("%")) 
                    {
                        Modulo();
                        continue;
                    }
                    if (sp.Contains("ctg "))
                    {
                        Ctg();
                        continue;
                    }
                    if (sp.Contains("tg "))
                    {
                        Tg();
                        continue;
                    }
                    if (sp.Contains("cos "))
                    {
                        Cos();
                        continue;
                    }
                    if (sp.Contains("sin "))
                    {
                        Sin();
                        continue;
                    }

                    if (sp.Contains("*") || sp.Contains("/"))
                    {
                        if (sp.Contains("*") && sp.Contains("/"))
                        {
                            if (sp.IndexOf("*") < sp.IndexOf("/"))
                            {
                                Umn();
                                continue;
                            }
                            else
                            {
                                Delen();
                                continue;
                            }
                        }
                        else if (sp.Contains("*"))
                        {
                            Umn();
                            continue;
                        }
                        else if (sp.Contains("/"))
                        {
                            Delen();
                            continue;
                        }
                    }

                    if (sp.Contains("+") || sp.Contains("-"))
                    {
                        if (sp.Contains("+") && sp.Contains("-"))
                        {
                            if (sp.IndexOf("+") < sp.IndexOf("-"))
                            {
                                Plus();
                                continue;
                            }
                            else
                            {
                                Minus();
                                continue;
                            }
                        }
                        else if (sp.Contains("+"))
                        {
                            Plus();
                            continue;
                        }
                        else if (sp.Contains("-"))
                        {
                            Minus();
                            continue;
                        }
                    }
                }
                ur = Convert.ToString(sp[0]);
                sp = [];
                output();
            }
            catch {
                sp[0] = "Îøèáêà";
                ur = Convert.ToString(sp[0]);
                output();
                sp = [];
                ur = "";
            }
            
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            ur += "0";
            output();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ur += "1";
            output();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ur += "2";
            output();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ur += "3";
            output();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ur += "4";
            output();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ur += "5";
            output();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ur += "6";
            output();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ur += "7";
            output();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ur += "8";
            output();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ur += "9";
            output();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ur += "_-_";
            output();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ur += "_+_";
            output();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ur += "_*_";
            output();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ur += "_/_";
            output();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ur = ur.Remove(ur.Length - 1);
                ur = ur.Remove(ur.Length - 1);
                output();
            }
            catch
            {
                ur = "";
                output();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ur = "";
            output();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ur += "_!_";
            output();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ur += "_sqrt _";
            output();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ur += "_e_";
            output();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ur += "_ï_";
            output();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ur += "_^2_";
            output();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ur += "_%_";
            output();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ur += "_ctg _";
            output();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ur += "_tg _";
            output();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ur += "_cos _";
            output();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ur += "_sin _";
            output();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(ur.Contains(",")){ }
            else
            {
                ur += ",";
                output();
            }
            
        }
    }
}
