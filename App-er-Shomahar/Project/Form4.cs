using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Group_Project
{
    public partial class Form4 : Form
    {
        static double result;
        static int c = 0;
        static string count = "0";
        static int b = 0;
        public Form4()
        {
            InitializeComponent();
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            pictureBox2.Image = Properties.Resources.hh;
          //  button37.Text = "";
           // button37.Image = Properties.Resources.hh;
            this.BackgroundImage = Properties.Resources.call;
            button10.Text = "";
            label3.Visible = true;
            label2.Visible = false;
            button10.Text = "";
            button10.Image = Properties.Resources.Arrow1;
            pictureBox1.Image = Properties.Resources.xBLACK;
            pictureBox5.Image= Properties.Resources.BACK3;
        }

        private void button36_Click(object sender, EventArgs e)
        {
          
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                count = "π";
                string text = textBox1.Text;
                double dtext = Convert.ToDouble(text);
                result = dtext * Math.PI;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "π";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox2.Text == "")
            {
                count = "π";
                label1.Text = "π";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox2.Text != "")
            {
                count = "π";
                textBox1.Text = "0";
                string text = textBox2.Text;
                double dtext = Convert.ToDouble(text);
                result = dtext * Math.PI;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "π";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox1.Text == "")
            {
                count = "π";
                textBox1.Text = "0";
                string text = textBox1.Text;
                double dtext = Convert.ToDouble(text);
                result = dtext * Math.PI;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "π";
                label1.Visible = true;
                textBox1.Clear();
            }

        }

        private void button30_Click(object sender, EventArgs e)
        {

            //  Math.Sqrt(x)
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double num = Convert.ToDouble(textBox1.Text);
                count = "√";
                result = Math.Sqrt(num);
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "√";
                label1.Visible = true;
                textBox1.Clear();
            }

            else if (textBox1.Text != "")
            {
                double num = Convert.ToDouble(textBox1.Text);
                count = "√";
                string text = textBox1.Text;
                double dtext = Convert.ToDouble(text);

                result = Math.Sqrt(num);
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "√";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox2.Text == "")
            {

                count = "√";
                label1.Text = "√";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox2.Text != "")
            {
                count = "√";
                textBox1.Text = "0";
                double num = Convert.ToDouble(textBox2.Text);
                result = Math.Sqrt(num);
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "√";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox1.Text == "")
            {
                count = "√";
                textBox1.Text = "0";
                string text = textBox1.Text;
                double dtext = Convert.ToDouble(text);
                result = 0;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "√";
                label1.Visible = true;
                textBox1.Clear();
            }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string sentence = textBox1.Text;
                char[] charArr = sentence.ToCharArray();
                int j = 0;
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (charArr[i] == '.')
                    {
                        j++;
                    }
                }
                if (j == 0)
                {
                    int num = Convert.ToInt32(textBox1.Text);

                    int fact = 1;

                    for (int i = num; i > 0; i--)

                    {

                        fact = fact * i;

                    }
                    count = "!";
                    result = fact;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox2.Visible = true;
                    label1.Text = "!";
                    label1.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    textBox1.Clear();
                }
            }
            else if (textBox1.Text == "" && textBox2.Text != "")
            {
                string sentence = textBox2.Text;
                char[] charArr = sentence.ToCharArray();
                int j = 0;
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (charArr[i] == '.')
                    {
                        j++;
                    }
                }
                if (j == 0)
                {
                    int num = Convert.ToInt32(textBox2.Text);
                    int fact = 1;

                    for (int i = num; i > 0; i--)

                    {

                        fact = fact * i;

                    }
                    count = "!";


                    result = fact;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox2.Visible = true;
                    label1.Text = "!";
                    label1.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    textBox1.Clear();
                }

            }
            else if (textBox1.Text != "" && textBox2.Text == "")
            {
                string sentence = textBox1.Text;
                char[] charArr = sentence.ToCharArray();
                int j = 0;
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (charArr[i] == '.')
                    {
                        j++;
                    }
                }
                if (j == 0)
                {
                    int num = Convert.ToInt32(textBox1.Text);
                    int fact = 1;

                    for (int i = num; i > 0; i--)

                    {

                        fact = fact * i;

                    }
                    count = "!";


                    result = fact;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox2.Visible = true;
                    label1.Text = "!";
                    label1.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    textBox1.Clear();
                }

            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {

                count = "!";



                label1.Text = "!";
                label1.Visible = true;
                textBox1.Clear();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = "e";
            label1.Text = "e";
            label1.Visible = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = "tan-1";
            label1.Text = "tan-1";
            label1.Visible = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = "tan";
            label1.Text = "tan";
            label1.Visible = true;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = "log";
            label1.Text = "log";
            label1.Visible = true;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = "cos-1";
            label1.Text = "cos-1";
            label1.Visible = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = "cos";
            label1.Text = "cos";
            label1.Visible = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                count = "x-1";
                string text = textBox1.Text;
                double dtext = Convert.ToDouble(text);
                result = 1 / dtext;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "x-1";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox2.Text == "")
            {
                count = "x-1";
                label1.Text = "x-1";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox2.Text != "")
            {
                count = "x-1";
                textBox1.Text = "0";
                string text = textBox2.Text;
                double dtext = Convert.ToDouble(text);
                result = 1 / dtext;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "x-1";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox1.Text == "")
            {
                count = "x-1";
                textBox1.Text = "0";
                string text = textBox1.Text;
                double dtext = Convert.ToDouble(text);
                result = 1 / dtext;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "x-1";
                label1.Visible = true;
                textBox1.Clear();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = "sin-1";
            label1.Text = "sin-1";
            label1.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = "sin";
            label1.Text = "sin";
            label1.Visible = true;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                count = "x3";
                string text = textBox1.Text;
                double dtext = Convert.ToDouble(text);
                result = dtext * dtext * dtext;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "x3";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox2.Text == "")
            {
                count = "x3";
                label1.Text = "x3";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox2.Text != "")
            {
                count = "x3";
                textBox1.Text = "0";
                string text = textBox2.Text;
                double dtext = Convert.ToDouble(text);
                result = dtext * dtext * dtext;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "x3";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox1.Text == "")
            {
                count = "x3";
                textBox1.Text = "0";
                string text = textBox1.Text;
                double dtext = Convert.ToDouble(text);
                result = dtext * dtext * dtext;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "x3";
                label1.Visible = true;
                textBox1.Clear();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                count = "x2";
                string text = textBox1.Text;
                double dtext = Convert.ToDouble(text);
                result = dtext * dtext;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "x2";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox2.Text == "")
            {
                count = "x2";
                label1.Text = "x2";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox2.Text != "")
            {
                count = "x2";
                textBox1.Text = "0";
                string text = textBox2.Text;
                double dtext = Convert.ToDouble(text);
                result = dtext * dtext;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "x2";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox1.Text == "")
            {
                count = "x2";
                textBox1.Text = "0";
                string text = textBox1.Text;
                double dtext = Convert.ToDouble(text);
                result = dtext * dtext;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "x2";
                label1.Visible = true;
                textBox1.Clear();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                count = "^";
                double dtext = Convert.ToDouble(textBox1.Text);
                double Dtext = Convert.ToDouble(textBox2.Text);
                result = Math.Pow(Dtext, dtext);
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "^";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox2.Text == "" && textBox1.Text != "")
            {
                count = "^";
                textBox2.Text = textBox1.Text;
                textBox2.Visible = true;
                label1.Text = "^";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox2.Text != "" && textBox1.Text == "")
            {
                count = "^";
                textBox2.Visible = true;
                label1.Text = "^";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox2.Text == "" && textBox1.Text == "")
            {
                count = "^";
                textBox2.Visible = false;
                label1.Text = "^";
                label1.Visible = true;
                textBox1.Clear();
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            label1.Text = "l1";
            label1.Visible = textBox2.Visible = false;
            textBox1.Clear();
            result = 0;
            b = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Clear();
            }
            else
            {
                string text = textBox1.Text;
                text = text.Remove(text.Length - 1);
                textBox1.Text = text;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double num = Convert.ToDouble(textBox1.Text);
                count = "%";

                result = num / 100;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "%";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox1.Text != "")
            {
                count = "%";
                string text = textBox1.Text;
                double dtext = Convert.ToDouble(text);
                result = dtext / 100;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "%";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox2.Text == "")
            {
                count = "%";
                label1.Text = "%";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox2.Text != "")
            {
                count = "%";
                textBox1.Text = "0";
                string text = textBox2.Text;
                double dtext = Convert.ToDouble(text);
                result = dtext / 100;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "%";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (textBox1.Text == "")
            {
                count = "%";
                textBox1.Text = "0";
                string text = textBox1.Text;
                double dtext = Convert.ToDouble(text);
                result = dtext / 100;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox2.Visible = true;
                label1.Text = "%";
                label1.Visible = true;
                textBox1.Clear();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text == "+")
            {
                if (textBox1.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox2.Text);
                    double Dtext = Convert.ToDouble(textBox1.Text);
                    result = dtext + Dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }

            }
            else if (label1.Text == "-")
            {
                if (textBox1.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox2.Text);
                    double Dtext = Convert.ToDouble(textBox1.Text);
                    result = dtext - Dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }

            }
            else if (label1.Text == "X")
            {
                if (textBox1.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox2.Text);
                    double Dtext = Convert.ToDouble(textBox1.Text);
                    result = dtext * Dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }

            }
            else if (label1.Text != "÷" && textBox2.Text == "" && textBox1.Text == "")
            {
                count = "÷";
                label1.Text = "÷";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (label1.Text != "÷" && textBox2.Text != "" && textBox1.Text == "")
            {
                count = "÷";
                label1.Text = "÷";
                label1.Visible = true;

            }
            else if (label1.Text != "÷" && textBox2.Text == "" && textBox1.Text != "")
            {
                textBox2.Text = textBox1.Text;
                textBox2.Visible = true;
                textBox1.Clear();

            }
            else if (label1.Text != "÷" && textBox2.Text != "" && textBox1.Text != "")
            {
                textBox2.Text = textBox1.Text;
                textBox2.Visible = true;
                textBox1.Clear();

            }
            if (textBox2.Text != "")
            {
                if (textBox1.Text != "")
                {
                    count = "÷";
                    label1.Text = "÷";
                    label1.Visible = true;
                    //textBox1.Text = "0";
                    string text = textBox1.Text;

                    string pq = textBox2.Text;
                    textBox2.Visible = true;
                    double dtext = Convert.ToDouble(text);
                    double Dtext = Convert.ToDouble(pq);
                    result = Dtext / dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }
                else
                {
                    count = "÷";
                    label1.Text = "÷";
                    label1.Visible = true;
                }
            }
            else if (textBox1.Text == "")
            {
                if (textBox2.Text == "")
                {
                    count = "÷";
                    label1.Text = "÷";
                    label1.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    count = "÷";
                    label1.Text = "÷";
                    label1.Visible = true;
                    // string text = textBox1.Text;
                    //label2.Text;
                    //label2.Visible = true;
                    double dtext = Convert.ToDouble(textBox2.Text);
                    result = 0;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }
            }
            else
            {
                if (b == 0)
                {
                    b = 3;
                    count = "÷";
                    label1.Text = "÷";
                    label1.Visible = true;
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    double dtext = Convert.ToDouble(textBox1.Text);
                    result = dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    b = 3;
                    count = "÷";
                    label1.Text = "÷";
                    label1.Visible = true;
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    double dtext = Convert.ToDouble(textBox1.Text);
                    result = result / dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text == "+")
            {
                if (textBox1.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox2.Text);
                    double Dtext = Convert.ToDouble(textBox1.Text);
                    result = dtext + Dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }

            }
            else if (label1.Text == "-")
            {
                if (textBox1.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox2.Text);
                    double Dtext = Convert.ToDouble(textBox1.Text);
                    result = dtext - Dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }

            }
            else if (label1.Text == "÷")
            {
                if (textBox1.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox2.Text);
                    double Dtext = Convert.ToDouble(textBox1.Text);
                    result = dtext / Dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }

            }
            else if (label1.Text != "X" && textBox2.Text == "" && textBox1.Text == "")
            {
                count = "X";
                label1.Text = "X";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (label1.Text != "X" && textBox2.Text != "" && textBox1.Text == "")
            {
                count = "X";
                label1.Text = "X";
                label1.Visible = true;

            }
            else if (label1.Text != "X" && textBox2.Text == "" && textBox1.Text != "")
            {
                textBox2.Text = textBox1.Text;
                textBox2.Visible = true;
                textBox1.Clear();

            }
            else if (label1.Text != "X" && textBox2.Text != "" && textBox1.Text != "")
            {
                textBox2.Text = textBox1.Text;
                textBox2.Visible = true;
                textBox1.Clear();

            }
            if (textBox2.Text != "")
            {
                if (textBox1.Text != "")
                {
                    count = "X";
                    label1.Text = "X";
                    label1.Visible = true;
                    //textBox1.Text = "0";
                    string text = textBox1.Text;

                    string pq = textBox2.Text;
                    textBox2.Visible = true;
                    double dtext = Convert.ToDouble(text);
                    double Dtext = Convert.ToDouble(pq);
                    result = Dtext * dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }
                else
                {
                    count = "X";
                    label1.Text = "X";
                    label1.Visible = true;
                }
            }
            else if (textBox1.Text == "")
            {
                if (textBox2.Text == "")
                {
                    count = "X";
                    label1.Text = "X";
                    label1.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    count = "X";
                    label1.Text = "X";
                    label1.Visible = true;
                    // string text = textBox1.Text;
                    //label2.Text;
                    //label2.Visible = true;
                    double dtext = Convert.ToDouble(textBox2.Text);
                    result = result * 0;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }
            }
            else
            {
                if (b == 0)
                {
                    b = 3;
                    count = "X";
                    label1.Text = "X";
                    label1.Visible = true;
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    double dtext = Convert.ToDouble(textBox1.Text);
                    result = dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    b = 3;
                    count = "X";
                    label1.Text = "X";
                    label1.Visible = true;
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    double dtext = Convert.ToDouble(textBox1.Text);
                    result = result * dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "9";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "9";

                }
            }
            else
            {
                textBox1.Clear();
                c = 0;
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "9";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "9";

                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "8";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "8";

                }
            }
            else
            {
                textBox1.Clear();
                c = 0;
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "8";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "8";

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "7";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "7";

                }
            }
            else
            {
                textBox1.Clear();
                c = 0;
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "7";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "7";

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "4";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "4";

                }
            }
            else
            {
                textBox1.Clear();
                c = 0;
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "4";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "4";

                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "5";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "5";

                }
            }
            else
            {
                textBox1.Clear();
                c = 0;
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "5";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "5";

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "6";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "6";

                }
            }
            else
            {
                textBox1.Clear();
                c = 0;
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "6";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "6";

                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label1.Text == "+")
            {
                if (textBox1.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox2.Text);
                    double Dtext = Convert.ToDouble(textBox1.Text);
                    result = dtext + Dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }

            }
            else if (label1.Text == "X")
            {
                if (textBox1.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox2.Text);
                    double Dtext = Convert.ToDouble(textBox1.Text);
                    result = dtext * Dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }

            }
            else if (label1.Text == "÷")
            {
                if (textBox1.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox2.Text);
                    double Dtext = Convert.ToDouble(textBox1.Text);
                    result = dtext / Dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }

            }
            else if (label1.Text != "-" && textBox2.Text == "" && textBox1.Text == "")
            {
                count = "-";
                label1.Text = "-";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (label1.Text != "-" && textBox2.Text != "" && textBox1.Text == "")
            {
                count = "-";
                label1.Text = "-";
                label1.Visible = true;

            }
            else if (label1.Text != "-" && textBox2.Text == "" && textBox1.Text != "")
            {
                textBox2.Text = textBox1.Text;
                textBox2.Visible = true;
                textBox1.Clear();

            }
            else if (label1.Text != "-" && textBox2.Text != "" && textBox1.Text != "")
            {
                textBox2.Text = textBox1.Text;
                textBox2.Visible = true;
                textBox1.Clear();

            }
            if (textBox2.Text != "")
            {
                if (textBox1.Text != "")
                {
                    count = "-";
                    label1.Text = "-";
                    label1.Visible = true;
                    //textBox1.Text = "0";
                    string text = textBox1.Text;

                    string pq = textBox2.Text;
                    textBox2.Visible = true;
                    double dtext = Convert.ToDouble(text);
                    double Dtext = Convert.ToDouble(pq);
                    result = Dtext - dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }
                else
                {
                    count = "-";
                    label1.Text = "-";
                    label1.Visible = true;
                }
            }
            else if (textBox1.Text == "")
            {
                if (textBox2.Text == "")
                {
                    count = "-";
                    label1.Text = "-";
                    label1.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    count = "-";
                    label1.Text = "-";
                    label1.Visible = true;
                    // string text = textBox1.Text;
                    //label2.Text;
                    //label2.Visible = true;
                    double dtext = Convert.ToDouble(textBox2.Text);
                    result = result - 0;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }
            }
            else
            {
                if (b == 0)
                {
                    b = 3;
                    count = "-";
                    label1.Text = "-";
                    label1.Visible = true;
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    double dtext = Convert.ToDouble(textBox1.Text);
                    result = dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    b = 3;
                    count = "-";
                    label1.Text = "-";
                    label1.Visible = true;
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    double dtext = Convert.ToDouble(textBox1.Text);
                    result = result - dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text == "-")
            {
                if (textBox1.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox2.Text);
                    double Dtext = Convert.ToDouble(textBox1.Text);
                    result = dtext - Dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }

            }
            else if (label1.Text == "X")
            {
                if (textBox1.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox2.Text);
                    double Dtext = Convert.ToDouble(textBox1.Text);
                    result = dtext * Dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }

            }
            else if (label1.Text == "÷")
            {
                if (textBox1.Text != "")

                {
                    double dtext = Convert.ToDouble(textBox2.Text);
                    double Dtext = Convert.ToDouble(textBox1.Text);
                    result = dtext / Dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }

            }
            else if (label1.Text != "+" && textBox2.Text == "" && textBox1.Text == "")
            {
                count = "+";
                label1.Text = "+";
                label1.Visible = true;
                textBox1.Clear();
            }
            else if (label1.Text != "+" && textBox2.Text != "" && textBox1.Text == "")
            {
                count = "+";
                label1.Text = "+";
                label1.Visible = true;

            }
            else if (label1.Text != "+" && textBox2.Text == "" && textBox1.Text != "")
            {
                textBox2.Text = textBox1.Text;
                textBox2.Visible = true;
                textBox1.Clear();

            }
            else if (label1.Text != "+" && textBox2.Text != "" && textBox1.Text != "")
            {
                textBox2.Text = textBox1.Text;
                textBox2.Visible = true;
                textBox1.Clear();

            }
            if (textBox2.Text != "")
            {
                if (textBox1.Text != "")
                {
                    count = "+";
                    label1.Text = "+";
                    label1.Visible = true;
                    //textBox1.Text = "0";
                    string text = textBox1.Text;

                    string pq = textBox2.Text;
                    textBox2.Visible = true;
                    double dtext = Convert.ToDouble(text);
                    double Dtext = Convert.ToDouble(pq);
                    result = Dtext + dtext;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }
                else
                {
                    count = "+";
                    label1.Text = "+";
                    label1.Visible = true;
                }
            }
            else if (textBox1.Text == "")
            {
                if (textBox2.Text == "")
                {
                    count = "+";
                    label1.Text = "+";
                    label1.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    count = "+";
                    label1.Text = "+";
                    label1.Visible = true;
                    // string text = textBox1.Text;
                    //label2.Text;
                    //label2.Visible = true;
                    double dtext = Convert.ToDouble(textBox2.Text);
                    result = result + 0;
                    string Result = Convert.ToString(result);
                    textBox1.Text = Result;
                    textBox2.Text = Result;
                    textBox1.Clear();
                }
            }
            else
            {
                b = 1;
                count = "+";
                label1.Text = "+";
                label1.Visible = true;
                string text = textBox1.Text;
                textBox2.Text = text;
                textBox2.Visible = true;
                double dtext = Convert.ToDouble(text);
                result = result + dtext;
                string Result = Convert.ToString(result);
                textBox1.Text = Result;
                textBox2.Text = Result;
                textBox1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "3";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "3";

                }
            }
            else
            {
                textBox1.Clear();
                c = 0;
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "3";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "3";

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (c == 0)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "2";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "2";

                }
            }
            else
            {
                textBox1.Clear();
                c = 0;
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "2";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "2";

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "1";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "1";

                }
            }
            else
            {
                textBox1.Clear();
                c = 0;
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "1";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "1";

                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            textBox1.TabIndex = 0;
            if (button21.Visible == false)
            {
                button21.Visible = true;
                button22.Visible = true;
                button23.Visible = true;
                button24.Visible = true;
                button25.Visible = true;
                button26.Visible = true;
                button27.Visible = true;
                button28.Visible = true;
                button29.Visible = true;
                button30.Visible = true;
                button31.Visible = true;
                button32.Visible = true;
                button33.Visible = true;
                button34.Visible = true;
                button35.Visible = true;
                label3.Visible = false;
                label2.Visible = true;
            }
            else
            {
                button21.Visible = false;
                button22.Visible = false;
                button23.Visible = false;
                button24.Visible = false;
                button25.Visible = false;
                button26.Visible = false;
                button27.Visible = false;
                button28.Visible = false;
                button29.Visible = false;
                button30.Visible = false;
                button31.Visible = false;
                button32.Visible = false;
                button33.Visible = false;
                button34.Visible = false;
                button35.Visible = false;
                label3.Visible = true;
                label2.Visible =false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "0";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "0";

                }
            }
            else
            {
                textBox1.Clear();
                c = 0;
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "0";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "0";

                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0.";
            }
            else
            {
                string sentence = textBox1.Text;
                char[] charArr = sentence.ToCharArray();
                int j = 0;
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (charArr[i] == '.')
                    {
                        j++;
                    }
                }
                if (j == 0)
                {
                    textBox1.Text = textBox1.Text + ".";
                }
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label1.Text == "l1" && textBox1.Text != "")
            {
                textBox2.Text = textBox1.Text;
                textBox2.Visible = true;
                textBox1.Clear();
            }
            else if (count == "sin")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    result = Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(Math.Sin((result * (Math.PI)) / 180));
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    result = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = Convert.ToString(Math.Sin((result * (Math.PI)) / 180));
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "cos")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    result = Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(Math.Cos((result * (Math.PI)) / 180));
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    result = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = Convert.ToString(Math.Cos((result * (Math.PI)) / 180));
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "tan")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    string dtext = textBox2.Text;
                    double Dtext = Convert.ToDouble(dtext);
                    textBox2.Text = Convert.ToString(Math.Tan((Dtext * (Math.PI)) / 180));
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    string dtext = textBox1.Text;
                    double Dtext = Convert.ToDouble(dtext);
                    textBox2.Text = Convert.ToString(Math.Tan((Dtext * (Math.PI)) / 180));
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "sin-1")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    string dtext = textBox2.Text;
                    double Dtext = Convert.ToDouble(dtext);
                    textBox2.Text = Convert.ToString((Math.Asin(Dtext) * 180) / Math.PI);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    string dtext = textBox1.Text;
                    double Dtext = Convert.ToDouble(dtext);
                    textBox2.Text = Convert.ToString((Math.Asin(Dtext) * 180) / Math.PI);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "cos-1")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    string dtext = textBox2.Text;
                    double Dtext = Convert.ToDouble(dtext);
                    textBox2.Text = Convert.ToString((Math.Acos(Dtext) * 180) / Math.PI);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    string dtext = textBox1.Text;
                    double Dtext = Convert.ToDouble(dtext);
                    textBox2.Text = Convert.ToString((Math.Acos(Dtext) * 180) / Math.PI);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "tan-1")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    string dtext = textBox2.Text;
                    double Dtext = Convert.ToDouble(dtext);
                    textBox2.Text = Convert.ToString((Math.Atan(Dtext) * 180) / Math.PI);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    string dtext = textBox1.Text;
                    double Dtext = Convert.ToDouble(dtext);
                    textBox2.Text = Convert.ToString((Math.Atan(Dtext) * 180) / Math.PI);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "log")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    string dtext = textBox2.Text;
                    double Dtext = Convert.ToDouble(dtext);
                    textBox2.Text = Convert.ToString(Math.Log10(Dtext));
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    string dtext = textBox1.Text;
                    double Dtext = Convert.ToDouble(dtext);
                    textBox2.Text = Convert.ToString(Math.Log10(Dtext));
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "e")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    string dtext = textBox2.Text;
                    double Dtext = Convert.ToDouble(dtext);
                    textBox2.Text = Convert.ToString(Math.Exp(Dtext));
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    string dtext = textBox1.Text;
                    double Dtext = Convert.ToDouble(dtext);
                    textBox2.Text = Convert.ToString(Math.Exp(Dtext));
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "%")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    result = Convert.ToDouble(textBox2.Text);
                    result = result / 100;
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else if (textBox1.Text != "")
                {
                    result = Convert.ToDouble(textBox1.Text);
                    result = result / 100;
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }

            }
            else if (count == "!")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    string sentence = textBox2.Text;
                    char[] charArr = sentence.ToCharArray();
                    int j = 0;
                    for (int i = 0; i < charArr.Length; i++)
                    {
                        if (charArr[i] == '.')
                        {
                            j++;
                        }
                    }
                    if (j == 0)
                    {
                        int num = Convert.ToInt32(textBox2.Text);

                        int fact = 1;

                        for (int i = num; i > 0; i--)

                        {

                            fact = fact * i;

                        }
                        result = fact;
                        textBox2.Text = Convert.ToString(result);
                        textBox2.Visible = true;
                        textBox1.Clear();
                    }
                    else
                    {
                        textBox1.Clear();
                    }

                }
                else if (textBox1.Text != "")
                {
                    string sentence = textBox1.Text;
                    char[] charArr = sentence.ToCharArray();
                    int j = 0;
                    for (int i = 0; i < charArr.Length; i++)
                    {
                        if (charArr[i] == '.')
                        {
                            j++;
                        }
                    }
                    if (j == 0)
                    {
                        int num = Convert.ToInt32(textBox1.Text);
                        int fact = 1;
                        for (int i = num; i > 0; i--)

                        {

                            fact = fact * i;

                        }
                        result = fact;
                        textBox2.Text = Convert.ToString(result);
                        textBox2.Visible = true;
                        textBox1.Clear();
                    }
                    else
                    {
                        textBox1.Clear();
                    }
                }

            }
            else if (count == "√")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    result = Convert.ToDouble(textBox2.Text);
                    result = Math.Sqrt(result);
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else if (textBox1.Text != "")
                {
                    result = Convert.ToDouble(textBox1.Text);
                    result = Math.Sqrt(result);
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }

            }
            else if (count == "π")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    result = Math.PI;
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    result = Convert.ToDouble(textBox2.Text);
                    result = result * Math.PI;
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else if (textBox1.Text != "")
                {
                    result = Convert.ToDouble(textBox1.Text);
                    result = result * Math.PI;
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "x2")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    result = Convert.ToDouble(textBox2.Text);
                    result = result * result;
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    result = Convert.ToDouble(textBox1.Text);
                    result = result * result;
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "x3")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    result = Convert.ToDouble(textBox2.Text);
                    result = result * result * result;
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else
                {
                    result = Convert.ToDouble(textBox1.Text);
                    result = result * result * result;
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "x-1")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    result = Convert.ToDouble(textBox2.Text);
                    result = 1 / result;
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else if (textBox1.Text != "")
                {
                    result = Convert.ToDouble(textBox1.Text);
                    result = 1 / result;
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "+")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text != "" && textBox2.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox1.Text);
                    double Dtext = Convert.ToDouble(textBox2.Text);
                    result = Dtext + dtext;
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "-")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text != "" && textBox2.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox1.Text);
                    double Dtext = Convert.ToDouble(textBox2.Text);
                    result = Dtext - dtext;
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "X")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text != "" && textBox2.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox1.Text);
                    double Dtext = Convert.ToDouble(textBox2.Text);
                    result = Dtext * dtext;
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "÷")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text != "" && textBox2.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox1.Text);
                    double Dtext = Convert.ToDouble(textBox2.Text);
                    result = Dtext / dtext;
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
            else if (count == "^")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text == "" && textBox2.Text != "")
                {
                    textBox1.Clear();
                }
                else if (textBox1.Text != "" && textBox2.Text != "")
                {
                    double dtext = Convert.ToDouble(textBox1.Text);
                    double Dtext = Convert.ToDouble(textBox2.Text);
                    result = Math.Pow(Dtext, dtext);
                    textBox2.Text = Convert.ToString(result);
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = textBox1.Text;
                    textBox2.Visible = true;
                    textBox1.Clear();
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.xBLACK;
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            textBox1.Text = "";
            timer1.Start();
            textBox2.Text = "";
            pictureBox2.Image = Properties.Resources.hh;
           
        }

        private void button37_MouseEnter(object sender, EventArgs e)
        {
          //  button37.Image = Properties.Resources.l;

        }

        private void button37_MouseLeave(object sender, EventArgs e)
        {
          //  button37.Image = Properties.Resources.hh;
        }

        private void button37_Click(object sender, EventArgs e)
        {
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button36_MouseHover(object sender, EventArgs e)
        {
          //  toolTip1.Show("Back", button36);
        }

        private void button37_MouseHover(object sender, EventArgs e)
        {
           // toolTip1.Show("Power Button", button37);
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            if(label3.Visible==true)
            {
                toolTip1.Show("Basic Calculator", button10);
            }
            else
            {
                toolTip1.Show("Scientific Calculator", button10);
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Exit", pictureBox1);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.RED1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.xBLACK;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button36_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            textBox2.Text = "";
            label1.Text = "l1";
            label1.Visible = textBox2.Visible = false;
            textBox1.Clear();
            result = 0;
            b = 0;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Power Button", pictureBox2);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.l;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.hh;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
            textBox2.Text = "";
            label1.Text = "l1";
            label1.Visible = textBox2.Visible = false;
            textBox1.Clear();
            result = 0;
            b = 0;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Back", pictureBox5);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.RED1;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("HH:mm");
            PowerStatus pwr = SystemInformation.PowerStatus;
            String per;
            per = pwr.BatteryLifePercent.ToString();
            double pkl = Convert.ToDouble(per);
            pkl = pkl * 100;
            progressBar1.Value = Convert.ToInt32(pkl);
            label6.Text = pkl.ToString() + "%";
            pictureBox6.Image = Properties.Resources.charging_battery_icon_charger_icon;

        }
    }
}
