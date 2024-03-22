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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.xBLACK;
            pictureBox2.Image = Properties.Resources.hh;
          
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.hh;
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            pictureBox5.Image = Properties.Resources.BACK3;
            pictureBox1.Image = Properties.Resources.xBLACK;
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
            groupBox1.Visible = false;
            textBox1.Visible = false;
            button2.Text = "View";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
            {
                textBox1.Visible = true;
                groupBox1.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                button2.Text = "Hide";
            }
            else
            {
                textBox1.Visible = false;
                groupBox1.Visible = false;
                button2.Text = "View";
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string dtext = monthCalendar1.SelectionStart.ToString();
            int l = dtext.Length;
            char[] arr = dtext.ToCharArray();
            textBox1.Text = "";
             dtext = "";
              if (l < 21)
              {
                  for (int i = 0; i < 9; i++)
                  {
                      dtext = dtext + arr[i];
                  }
              }
              else
              {
                  for (int i = 0; i < 10; i++)
                  {
                      dtext = dtext + arr[i];
                  }
              }
              textBox1.Text = dtext;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            //button6.Image = Properties.Resources.l;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            if(button2.Text=="View")
            {
                toolTip1.Show("View", button2);
            }
            else
            {
                toolTip1.Show("Hide", button2);
            }
        }

        private void monthCalendar1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Calender", monthCalendar1);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.RED1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.xBLACK;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Exit", pictureBox1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Brown;
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Blue;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Back", pictureBox5);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 b = new Form1();
            b.Show();
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
            Form3 h = new Form3();
            h.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dtext = monthCalendar1.SelectionStart.ToString();
            int l = dtext.Length;
            char[] arr = dtext.ToCharArray();
            textBox1.Text = "";
            dtext = "";
            if (l < 21)
            {
                for (int i = 0; i < 9; i++)
                {
                    dtext = dtext + arr[i];
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    dtext = dtext + arr[i];
                }
            }
            textBox1.Text = dtext;
            string p = DateTime.Now.ToString("D");
            char[] a = p.ToCharArray();
            string j = "";
            for (int i = 0; i < 3; i++)
            {
                j = j + a[i];
            }
            if (j == "Thu")
            {
                textBox2.Text = "Thrusday";
            }
            else if (j == "Sat")
            {
                textBox2.Text = "Saturday";
            }
            else if (j == "Sun")
            {
                textBox2.Text = "Sunday";
            }
            else if (j == "Mon")
            {
                textBox2.Text = "Monday";
            }
            else if (j == "Tue")
            {
                textBox2.Text = "Tuesday";
            }
            else if (j == "Wed")
            {
                textBox2.Text = "Wednesday";
            }
            else if (j == "Fri")
            {
                textBox2.Text = "Friday";
            }
            string M = DateTime.Now.ToString("MMMM");
            textBox4.Text = M;
            string D = DateTime.Now.ToString("dd");
            textBox3.Text = D;
            string Y = DateTime.Now.ToString("yyyy");
            textBox5.Text = Y;
            this.BackgroundImage = Properties.Resources.calendar_page_close_up_blue_background_business_planning_appointment_meeting_concept_293060_976;
            pictureBox5.Image = Properties.Resources.BACK3;
            pictureBox2.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;

            PowerStatus pwr = SystemInformation.PowerStatus;
            String per;
            per = pwr.BatteryLifePercent.ToString();
            double pkl = Convert.ToDouble(per);
            pkl = pkl * 100;
            progressBar1.Value = Convert.ToInt32(pkl);
            label6.Text = pkl.ToString() + "%";
            label5.Text = DateTime.Now.ToString("HH:mm");
            pictureBox6.Image = Properties.Resources.charging_battery_icon_charger_icon;
        }
    }
}
