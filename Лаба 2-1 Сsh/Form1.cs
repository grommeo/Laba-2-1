using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_2_1_Сsh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.n.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var n = int.Parse(this.textBox1.Text);
                var Out = Logic.RubCop(n);
                label5.Text = Out;
                Properties.Settings.Default.n = n;
                Properties.Settings.Default.Save();
            }
            catch(FormatException) 
            {
                label5.Text = "Ошибка. Некорректный ввод";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    public class Logic
    {
        public static string RubCop(int n) 
        {
            int  m, x;
            m = 0;
            x = 0;
            string Out;
            string rub =" ", cop = " ";


            if (n >= 1 && n <= 9999)
            {
                if (n >= 100)
                {
                    m = n / 100;
                    x = n % 100;
                }
                else
                {
                    m = 0;
                    x = n;
                }
                if (m > 0)
                {
                    if (m >= 10 && m <= 20)
                    {
                        rub = m.ToString() + " Рублей  ";
                    }
                    else
                    {
                        if (m % 10 == 1)
                        {
                            rub = m.ToString() + " Рубль  ";
                        }
                        else
                        {
                            if (m % 10 == 2 || m % 10 == 3 || m % 10 == 4)
                            {
                                rub = m.ToString() + " Рубля  ";
                            }
                            else
                            {
                                if (m % 10 == 5 || m % 10 == 6 || m % 10 == 7 || m % 10 == 8 || m % 10 == 9 || m % 10 == 0)
                                {
                                    rub = m.ToString() + " Рублей  ";
                                }
                            }
                        }
                    }
                }
                if (x > 0)
                {
                    if (x >= 10 && x <= 20)
                    {
                        cop = x.ToString() + " Копеек";
                    }
                    else
                    {
                        if (x % 10 == 1)
                        {
                            cop = x.ToString() + " Копейка";
                        }
                        else
                        {
                            if (x % 10 == 2 || x % 10 == 3 || x % 10 == 4)
                            {
                                cop = x.ToString() + " Копейки";
                            }
                            else
                            {
                                if (x % 10 == 5 || x % 10 == 6 || x % 10 == 7 || x % 10 == 8 || x % 10 == 9 || x % 10 == 0)
                                {
                                    cop = x.ToString() + " Копеек";
                                }
                            }
                        }
                    }
                }
                Out = rub + cop;
            }
            else
            {
                Out = "Ошибка. Некорректный ввод";
            }
    
            return (Out);
        }
    }

}
