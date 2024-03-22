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
    public partial class Form8 : Form
    {
        public static string remove;
        public static string set;
        public Form8()
        {
            InitializeComponent();
            pictureBox5.Image = Properties.Resources.BACK3;
            pictureBox1.Image = Properties.Resources.xBLACK;
            pictureBox2.Image = Properties.Resources.hh;
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
            remove = "remove";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.BackgroundImage = Properties.Resources.closed_finger_on_keyboard_word_260nw_566513329;
            pictureBox1.Image = Properties.Resources.xBLACK;
            pictureBox2.Image = Properties.Resources.hh;
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            pictureBox5.Image = Properties.Resources.BACK3;
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
          //  button4.Image = Properties.Resources.l;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkGray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gray;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.RED1;
        }

        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.Show("Exit", pictureBox1);
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.xBLACK;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.l;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Power Button", pictureBox2);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.hh;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form7 f3 = new Form7();
            f3.Show();
            this.Hide();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Back", pictureBox5);
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
