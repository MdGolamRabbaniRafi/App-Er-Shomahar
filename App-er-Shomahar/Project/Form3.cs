using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Group_Project
{
    public partial class Form3 : Form
    {
        public static string count="";
        string cs = ConfigurationManager.ConnectionStrings["abcd"].ConnectionString;
        public static string back;
        public static int volume=0;

        public Form3()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.xBLACK;
            setvol();
            Back();
            setimage();
            backimage();
            string k = DateTime.Now.ToString("dd");
            DayOfWeek wk = DateTime.Today.DayOfWeek;
            string q = Convert.ToString(wk);
            char[] arr = q.ToCharArray();
            q = "";
            for (int i = 0; i < 3; i++)
            {
                q = q + arr[i];
            }
            button2.Text = "\n"+k + "\n" + q;
          //  button6.Text = "";
            pictureBox2.Image = Properties.Resources.hh;
            if (back == "true")
            {
                backchange();
            }
            backimage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            pictureBox1.Image = Properties.Resources.xBLACK;
            setvol();
            Back();
            setimage();
            backimage();
            if (back=="true")
            {
                backchange();
            }
            if(count!="")
            {
                this.BackgroundImage = imageList1.Images[Convert.ToInt32(count)];
            }
            button7.BackgroundImage = Properties.Resources.phonebook;
            button7.Text = "";
            button6.BackgroundImage = Properties.Resources.glowing_neon_line_alarm_clock_icon_isolated_on_brick_wall_background_wake_up_get_up_concept_time_sign_illustration_vector;
            button6.Text = "";
            timer1.Start();
        }
        void backchange()
        {
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(ChangeImage);
            t.Start();
        }
        private void ChangeImage(object sender, EventArgs e)
        {
            List<Bitmap> ob = new List<Bitmap>();
            ob.Add(Properties.Resources.nature);
            ob.Add(Properties.Resources.sky);
            ob.Add(Properties.Resources.nature2);
            ob.Add(Properties.Resources.nature3);
            ob.Add(Properties.Resources.nature4);
            ob.Add(Properties.Resources.bkkkkkk);
            ob.Add(Properties.Resources.bk3);
            ob.Add(Properties.Resources.bk2);
            ob.Add(Properties.Resources.w1);
            ob.Add(Properties.Resources.w2);
            ob.Add(Properties.Resources.w3);
            ob.Add(Properties.Resources.w4);
            ob.Add(Properties.Resources.w5);
            ob.Add(Properties.Resources.w6);
            ob.Add(Properties.Resources.w7);
            ob.Add(Properties.Resources.w8);

            int l = DateTime.Now.Second % ob.Count;
            this.BackgroundImage = ob[l];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
          //  button6.Image = Properties.Resources.l;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
           // button6.Image = Properties.Resources.hh;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            this.Hide();
            f9.Show();
        }
        public void backimage()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select back from back_random";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                back = (dr["back"].ToString());
            }
            con.Close();
        }
        void setimage()
        {
            imageList1.Images.Add(Properties.Resources.sky);
            imageList1.Images.Add(Properties.Resources.nature);
            imageList1.Images.Add(Properties.Resources.nature2);
            imageList1.Images.Add(Properties.Resources.nature3);
            imageList1.Images.Add(Properties.Resources.nature4);
            imageList1.Images.Add(Properties.Resources.bkkkkkk);
            imageList1.Images.Add(Properties.Resources.bk3);
            imageList1.Images.Add(Properties.Resources.bk2);
            imageList1.Images.Add(Properties.Resources.w1);
            imageList1.Images.Add(Properties.Resources.w2);
            imageList1.Images.Add(Properties.Resources.w3);
            imageList1.Images.Add(Properties.Resources.w4);
            imageList1.Images.Add(Properties.Resources.w5);
            imageList1.Images.Add(Properties.Resources.w6);
            imageList1.Images.Add(Properties.Resources.w7);
            imageList1.Images.Add(Properties.Resources.w8);
        }
        void Back()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count from back_select";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                count = (dr["count"].ToString());
            }
            con.Close();
        }
        void setvol()
        {
            SqlConnection con = new SqlConnection(cs);
        con.Open();
            SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select vol from volume";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                 volume= Convert.ToInt32(dr["vol"].ToString());
            }
    con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form14 ob14 = new Form14();
            ob14.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Calculator", button1);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Calender", button2);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Notepad", button3);

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Music Player", button4);
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Settings", button5);
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Phonebook", button7);
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
          //  toolTip1.Show("Power Button", button6);
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

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.hh;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Power Button", pictureBox2);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form15 f = new Form15();
            f.Show();
            this.Hide();
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

        private void button6_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.Show("Clock", button6);
        }
    }
}
