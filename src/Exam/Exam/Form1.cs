using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        static bool flag = false;
        static int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = "";
            FileDialog fileDialog = new OpenFileDialog();

            fileDialog.ShowDialog();
            filepath = fileDialog.FileName;
            var uri = new Uri(fileDialog.FileName);
           flag = true;
            counter++;
            if(uri != null)
            {
                try
                {
                    webBrowser1.Navigate(uri);
                    Random rand = new Random();

                    textBox1.Text = Convert.ToString(rand.Next(-6, 6));
                    textBox2.Text = Convert.ToString(rand.Next(-6, 6));
                    int numberFirst = Convert.ToInt32(textBox1.Text);
                    int numberSecond = Convert.ToInt32(textBox2.Text);
                }
                catch
                {
                    MessageBox.Show("invalid number");
                }
            }
            
            
        }

        public static string FirstGraf(int i, int u)
        {
            string s;
            if (i < 0.5 && u == -1)
            {
                s = "На границе";
                return s;
            }
            else if (Math.Abs(i) * Math.Abs(i) < 1 / 2 * 1.5 * 0.5)
            {
                s = "Точка принадлежит графику";
                return s;
            }
            else if (i == -1 && u < 2)
            {
                s = "На границе";
                return s;
            }
            else
            {
                s = "Вне графика";
                return s;
            }
        }
        public static string Secondgraf(int i, int u)
        {
            string s;
            if (i > 0 && i > 0)
            {
                s = "Вне графика";
                return s;
            }
            else if (i > 0 && u < 0 && i < 6 && u > -6)
            {
                s = "Точка принадлежит графику";
                return s;
            }
            else if (i == 6 & u == -6)
            {
                s = "На границе";
                return s;
            }
            else if (i < 0 && u< 0 && i < 6 && u > -6)
            {
                s = "Точка принадлежит графику";
                return s;
            }
            else if (i < 0 && u > 0 && i < 6 && u > -6)
            {
                s = "Точка принадлежит графику";
                return s;
            }
            else
            {
                s = "Вне графика";
                return s;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = null;
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            textBox1.Text = Convert.ToString(rand.Next(-6, 6));
            textBox2.Text = Convert.ToString(rand.Next(-6, 6));
            int numberFirst = Convert.ToInt32(textBox1.Text);
            int numberSecond = Convert.ToInt32(textBox2.Text);
            if(flag == true && counter == 1)
            { 
                richTextBox1.Text = FirstGraf(numberFirst, numberSecond);
            }
            else
            {
                richTextBox1.Text = Secondgraf(numberFirst, numberSecond);

            }
            
        }

    }
}
