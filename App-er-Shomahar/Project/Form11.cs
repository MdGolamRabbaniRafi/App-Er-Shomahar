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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            pictureBox2.Image = Properties.Resources.hh;
            pictureBox5.Image = Properties.Resources.BACK3;
            pictureBox4.Image = Properties.Resources.xBLACK;
            this.BackgroundImage = Properties.Resources.MicrosoftTeams_image__2_;
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Set Password", button5);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
            this.BackgroundImage = Properties.Resources.MicrosoftTeams_image__2_;
            pictureBox5.Image = Properties.Resources.BACK3;
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            pictureBox4.Image = Properties.Resources.xBLACK;
            pictureBox2.Image = Properties.Resources.hh;
          

        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
           // pictureBox1.Image = Properties.Resources.RED1;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            //toolTip1.Show("Exit", pictureBox1);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
          //  pictureBox1.Image = Properties.Resources.xBLACK;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form7 f3 = new Form7();
            f3.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Black;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Gray;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.RED1;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.xBLACK;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Exit", pictureBox4);
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
            pictureBox8.Image = Properties.Resources.charging_battery_icon_charger_icon;

        }
    }
}
