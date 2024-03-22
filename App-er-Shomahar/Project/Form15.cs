using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Configuration;
using System.Data.SqlClient;

namespace Group_Project
{
    public partial class Form15 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["abcd"].ConnectionString;
        int mili =0, sec=0, min=0, h=0,H=0;
        string minute, hour="",music;
        string Min, Hour, second;
        bool cheak;
        string lp = "";
        string playmusic = "";
        int t = 0;
        int j = 0;
        string set = "";
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            boxshow();
            timer3.Start();
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            label10.Visible = false;
            label3.Visible = true;
            label1.Visible = false;
            label4.Visible = false;
            label8.Visible = true;
            label7.Visible = false;
            label9.Visible = true;
            pictureBox2.Image = Properties.Resources.hh;
            pictureBox4.Image = Properties.Resources.glowing_neon_line_alarm_clock_icon_isolated_on_brick_wall_background_wake_up_get_up_concept_time_sign_illustration_vector;
            button1.Image = Properties.Resources.clock_ico__3___3_;
            button2.Image = Properties.Resources.Stopwatch2__3_;
            button3.Image = Properties.Resources.ablarm__8___1_;
            pictureBox1.Image = Properties.Resources.xBLACK;
           
            pictureBox8.Image = Properties.Resources.charging_battery_icon_charger_icon;
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            pictureBox5.Image = Properties.Resources.BACK3;
            timer1.Start();
            pictureBox7.Image = Properties.Resources.red_start_png_5;
            lp = "start";
            pictureBox9.Image = Properties.Resources.reset_button_icon_1;
            pictureBox9.Visible = false;
            pictureBox7.Visible = false;
            cheak = false;
            mili = 0;
            sec = 0; 
            min = 0;
            h = 0;
            H = 0;
           for(int i=0;i<24;i++)
           {
                if (i<10)
                {
                    comboBox1.Items.Add("0"+Convert.ToString(i));
                }
                else
                {
                    comboBox1.Items.Add(i);
                }
            }
            for (int i = 0; i < 60; i++)
            {
                if (i < 10)
                {
                    comboBox2.Items.Add("0"+Convert.ToString(i));
                }
                else
                {
                    comboBox2.Items.Add(i);
                }
            }
            cheaka();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            if(playmusic=="play")
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from alarm_table where music='" + music + "'";
                cmd.ExecuteNonQuery();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                con.Close();
                playmusic = "stop";
                Hour = "";
                hour = "";
                Min = "";
                minute = "";
                second = "";
                music = "";
                label13.Text = "";
                label13.Visible = false;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                pictureBox10.Visible = true;
                pictureBox6.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                label10.Visible = false;
                label2.Visible = false;
                t = 0;
            }
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 j = new Form1();
            j.Show();
            this.Hide();
            if (playmusic == "play")
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from alarm_table where music='" + music + "'";
                cmd.ExecuteNonQuery();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                con.Close();
                playmusic = "stop";
                Hour = "";
                hour = "";
                Min = "";
                minute = "";
                second = "";
                music = "";
                label13.Text = "";
                label13.Visible = false;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                pictureBox10.Visible = true;
                pictureBox6.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                label10.Visible = false;
                label2.Visible = false;
                t = 0;
            }
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
            Form3 k = new Form3();
            k.Show();
            this.Hide();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Back", pictureBox5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PowerStatus pwr = SystemInformation.PowerStatus;
            String per;
            per = pwr.BatteryLifePercent.ToString();
            double pkl = Convert.ToDouble(per);
            pkl = pkl * 100;
            progressBar1.Value = Convert.ToInt32(pkl);
            label6.Text = pkl.ToString() + "%";
            label5.Text = DateTime.Now.ToString("HH:mm");
            label2.Text = DateTime.Now.ToString("ff");
            label9.Text = DateTime.Now.ToString("ss");
            label8.Text = DateTime.Now.ToString("mm");
            label3.Text = DateTime.Now.ToString("HH");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if(lp=="start")
            {
                cheak = true;
                lp = "pause";
                pictureBox7.Image = Properties.Resources.download__1__removebg_preview;
                timer2.Start();
            }
            else
            {
               cheak= false;
                lp = "start";
                pictureBox7.Image = Properties.Resources.red_start_png_5;
                timer2.Stop();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            cheak = false;
            lp = "start";
            pictureBox7.Image = Properties.Resources.red_start_png_5;
            label7.Text = "00";
            label4.Text = "00";
            mili = 0;
            sec = 0;
            min = 0;
            h = 0;
            label1.Text = "00";
            label10.Text = "00";
            timer2.Stop();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            boxshow();
            Hour = DateTime.Now.ToString("HH");
            Min = DateTime.Now.ToString("mm");
            second = DateTime.Now.ToString("ss");
            // listBox1.SelectedIndex = 0;
            if(Hour==hour && minute==Min && second=="00" && hour!="")
            {
                if (music != "" && playmusic != "play")
                {
                    axWindowsMediaPlayer1.URL = music;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    playmusic = "play";
                    t++;
                }
              
            }
            if (playmusic == "play" && t != 0 && j==0)
            {
                j++;
                var cheak = MessageBox.Show("Stop Alarm?", "Ring.... Ring....", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (cheak == DialogResult.Yes && t != 0)
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from alarm_table where music='" + music + "'";
                    cmd.ExecuteNonQuery();
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    con.Close();
                    playmusic = "stop";
                    Hour = "";
                    hour = "";
                    Min = "";
                    minute = "";
                    second = "";
                    music = "";
                    label13.Text = "";
                    label13.Visible = false;
                    comboBox1.Visible = true;
                    comboBox2.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    pictureBox10.Visible = true;
                    pictureBox6.Visible = false;
                    panel4.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    label10.Visible = false;
                    label2.Visible = false;
                    t = 0;
                }
                else if (cheak == DialogResult.No)
                {
                    j = 0;
                }
                else if (cheak == DialogResult.Cancel)
                {
                    j=0;
                }
            }

            cheaka();
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            boxshow();
            if(hour.Length<=0)
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                pictureBox10.Visible = true;
                pictureBox6.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                label10.Visible = false;
                label2.Visible = false;
            }
            else
            {
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                pictureBox10.Visible = true;
                pictureBox6.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                label10.Visible = false;
                label2.Visible = false;
                label13.Visible = true;
            }
            cheaka();
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            timer3.Start();
            if (set == "set")
            {
                if (comboBox1.Text != "" && comboBox2.Text != "")
                {
                    OpenFileDialog op = new OpenFileDialog();
                    if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string lk = DateTime.Now.ToString("hh:mm:ss tt");
                        SqlConnection con = new SqlConnection(cs);
                        string query = "Insert into alarm_table values(@music,@hour,@mini,@c)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@hour", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@mini", comboBox2.Text);
                        cmd.Parameters.AddWithValue("@music", op.FileName);
                        cmd.Parameters.AddWithValue("@c", lk);
                        con.Open();
                        int p = cmd.ExecuteNonQuery();
                        if (p > 0)
                        {
                            MessageBox.Show("Alarm set successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            comboBox1.SelectedIndex = -1;
                            comboBox2.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Alarm does not set successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();

                    }

                }
                boxshow();
                if (hour != "" && minute != "")
                {
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    label12.Visible = false;
                    label11.Visible = false;
                    label13.Visible = true;
                }

            }
            else
            {
                var cheak = MessageBox.Show("Remove Alarm?", "alarm remove", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (cheak == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from alarm_table where music='" + music + "'";
                    cmd.ExecuteNonQuery();
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    con.Close();
                    playmusic = "stop";
                    Hour = "";
                    hour = "";
                    Min = "";
                    minute = "";
                    second = "";
                    music = "";
                    label13.Text = "";
                    label13.Visible = false;
                    comboBox1.Visible = true;
                    comboBox2.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    pictureBox10.Visible = true;
                    pictureBox6.Visible = false;
                    panel4.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    label10.Visible = false;
                    label2.Visible = false;
                    
                }
            }
            cheaka();

        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            if(lp=="start")
            {
                toolTip1.Show("Start", pictureBox7);
            }
            else
            {
                toolTip1.Show("Pause", pictureBox7);
            }
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Show("Reset", pictureBox9);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(cheak)
            {
                mili++;
                if(mili<=100)
                {
                    sec++;
                    mili = 0;
                    if (sec >= 60)
                    {
                        min++;
                        sec = 0;
                        if (min >= 60)
                        {
                            h++;
                            min = 0;
                            if(h<=60)
                            {
                                h = 0;
                                H++;
                            }
                        }
                    }
                }
            }
            label7.Text = string.Format("{0:00}", min);
            label4.Text = string.Format("{0:00}", h);
            label1.Text = string.Format("{0:00}", H);
            label10.Text= string.Format("{0:00}", sec);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label13.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            pictureBox10.Visible = false;
            pictureBox6.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;

            label10.Visible = true;
            label3.Visible = false;
            label1.Visible = true;
            label4.Visible = true;
            label8.Visible = false;
            label7.Visible = true;
            label9.Visible = false;
            label2.Visible = false;
            pictureBox7.Visible = true;
            pictureBox9.Visible = true;


         

        }
        void boxshow()
        {

            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from alarm_table";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                hour = dr["hour"].ToString();
                minute= dr["mini"].ToString();
                music= dr["music"].ToString();
                if(hour!=""&&minute!="")
                {
                    label13.Text = "Alarm set at: " + hour + " : " + minute;
                }

            }
            con.Close();
          
        }
        void cheaka()
        {
            if (comboBox1.Visible == true)
            {
                pictureBox10.Image = Properties.Resources.red_start_png_5;
                set = "set";
            }
            else
            {
                pictureBox10.Image = Properties.Resources.stop_removebg_preview;
                set = "remove";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            label2.Visible = true;
            label13.Visible = false;
            timer1.Start();
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            pictureBox10.Visible = false;
            pictureBox6.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;

            pictureBox9.Visible = false;
            pictureBox7.Visible = false;
            label3.Visible = true;
            label1.Visible = false;
            label4.Visible = false;
            label8.Visible = true;
            label7.Visible = false;
            label9.Visible = true;
            label10.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            pictureBox7.Visible = false;
        }
    }
}
