using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
            pictureBox1.Image = Properties.Resources.xBLACK;
            pictureBox2.Image = Properties.Resources.enter2;
            pictureBox4.Image = Properties.Resources.hh;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.enter2;
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            pictureBox4.Image = Properties.Resources.hh;
            checkBox1.Checked = false;
            pictureBox1.Image = Properties.Resources.xBLACK;
            timer1.Start();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.RED1;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Exit", pictureBox1);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.xBLACK;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter Password", textBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Form1.password)
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else if(textBox1.Text=="")
            {
                MessageBox.Show("Enter your Password", "Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                textBox1.Clear();
                textBox1.Focus();
            }
           else if (textBox1.Text != Form1.password)
           {
                MessageBox.Show("Wrong Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Clear();
                textBox1.Focus();
           }

        }

        private void pictureBox2_DragOver(object sender, DragEventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter", pictureBox2);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.l;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.hh;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Power Button", pictureBox4);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm");
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
