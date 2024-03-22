using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Group_Project
{

    public partial class Form14 : Form
    {
        string[] p;
        string c;
        string[] file;
        string Pl;
        char[] Lp;
      //  string[] j;
        string cs = ConfigurationManager.ConnectionStrings["abcd"].ConnectionString;
        //  string file;
     //   string[] arr;
        OpenFileDialog kp;
        int PP;

        static int v;
        
        public Form14()
        {
            InitializeComponent();
            update();
            boxshow();
            pictureBox7.Image = Properties.Resources.BACK3;
            pictureBox8.Image = Properties.Resources.headphone;
            pictureBox10.Image = Properties.Resources.hh;
            pictureBox11.Image = Properties.Resources.xBLACK;
            pictureBox9.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.Remove1;
            pictureBox6.Visible = false;
            pictureBox4.Image = Properties.Resources.play;
            c = "play";
            timer2.Start();
            // groupBox1.Visible = false;
            update();
            boxshow();
            pictureBox7.Image = Properties.Resources.BACK3;
            pictureBox8.Image = Properties.Resources.headphone;
            pictureBox10.Image = Properties.Resources.hh;
            pictureBox11.Image = Properties.Resources.xBLACK;
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            kp = op;
            op.Multiselect = true;
           if(op.ShowDialog()==System.Windows.Forms.DialogResult.OK)
           {
                p = op.FileNames;
                file = op.FileNames;
                for(int i=0;i<file.Length;i++)
                {
                    listBox1.Items.Add(file[i]);
                }
           }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count!=0)
            {
                pictureBox6.Visible = true;
                int l = listBox1.SelectedIndex;
                axWindowsMediaPlayer1.URL = listBox1.SelectedItem.ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();
                
                pictureBox4.Image = Properties.Resources.Pause;
                c = "pause";
                // groupBox1.Text = axWindowsMediaPlayer1.URL;
                // groupBox1.Visible = true;
                update();
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(axWindowsMediaPlayer1.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                progressBar1.Value = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
                if(listBox1.SelectedItems.Count!=0)
                {
                    label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();
                    label3.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                  
                }
                else
                {
                    label2.Text = "";
                    label3.Text = "";
                }
            }
          
            label1.Text = Convert.ToString(trackBar1.Value) + "%";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void update()
        {
            label2.Text = "";
            label3.Text = "";
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
                v = Convert.ToInt32(dr["vol"].ToString());
            }
            con.Close();
            trackBar1.Value = v;
            label1.Text = Convert.ToString(trackBar1.Value)+"%";
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            v = trackBar1.Value;
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            label1.Text = Convert.ToString(trackBar1.Value) + "%";
        }

        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration * e.X / progressBar1.Width;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
            int o = 0;
            boxshow();
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            //op.Filter = "Video (.wmv)|*.wmv|Music(mp3)*.mp3|ALL Files(*.*)|*.*";
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                p = op.FileNames;
                file = op.FileNames;
                //= new string[p.Length];
                for (int i = 0; i < file.Length; i++)
                {
                    listBox1.Items.Add(file[i]);
                 //   richTextBox1.Text = Path.GetFileName(op.FileName);
                    o++;
                }

            }
            if(o!=0)
            {
                  for (int i = 0; i < p.Length; i++)
                  {
                      string lk = DateTime.Now.ToString("hh:mm:ss tt");
                      SqlConnection con = new SqlConnection(cs);
                      con.Open();
                      string query = "Insert into  music_tle values(@music,@c)";
                      SqlCommand cmd = new SqlCommand(query, con);
                      cmd.Parameters.AddWithValue("@music", p[i]);
                      cmd.Parameters.AddWithValue("@c", lk);
                      cmd.ExecuteNonQuery();
                      con.Close();

                  }
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        void boxshow()
        {
            listBox1.Items.Clear();
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select music from Music_tle";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["music"].ToString());
            }
            con.Close();
            pictureBox1.Image = Properties.Resources.Addm__1_;
            pictureBox2.Image = Properties.Resources.Previous;
            pictureBox3.Image = Properties.Resources.StopMu;
            
            pictureBox5.Image = Properties.Resources.Nextmu;

        }
      

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            /*if (listBox2.SelectedItems.Count != 0)
            {
                int l = listBox2.SelectedIndex;
                listBox1.SelectedIndex = l;
                string lpo = listBox1.SelectedItem.ToString();
                axWindowsMediaPlayer1.URL = lpo;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                button2.Text = "Pause";
                //  groupBox1.Text = axWindowsMediaPlayer1.URL;
              //  groupBox1.Visible = true;
                update();
              //  richTextBox1.Text = Path.GetFileName(axWindowsMediaPlayer1.URL.FileName);

            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0 && listBox1.SelectedItems.Count != 0)
            {

                var cheak=   MessageBox.Show("Are you sure to remove this song?", "Remove Music", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(cheak==DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Music_tle where music='" + listBox1.SelectedItem.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    progressBar1.Value = 0;
                    label2.Text = "";
                    label3.Text = "";
                    //  listBox1.Items.Remove(listBox1.SelectedItem);
                    con.Close();
                    // groupBox1.Text = "";
                    //  groupBox1.Visible = false;
                    //   p = "";
                    //  boxshow();
                }
                else if(cheak == DialogResult.No)
                {

                }
                else if(cheak == DialogResult.Cancel)
                {

                }
            }
            else if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Music player is empty");
            }
            else if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Music");
            }
            boxshow();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int o = 0;
            boxshow();
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            //op.Filter = "Video (.wmv)|*.wmv|Music(mp3)*.mp3|ALL Files(*.*)|*.*";
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                p = op.FileNames;
                file = op.FileNames;
                //= new string[p.Length];
                for (int i = 0; i < file.Length; i++)
                {
                    listBox1.Items.Add(file[i]);
                    //   richTextBox1.Text = Path.GetFileName(op.FileName);
                    o++;
                }

            }
            if (o != 0)
            {
                for (int i = 0; i < p.Length; i++)
                {
                    string lk = DateTime.Now.ToString("hh:mm:ss tt");
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "Insert into  music_tle values(@music,@c)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@music", p[i]);
                    cmd.Parameters.AddWithValue("@c", lk);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Add", pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                if (listBox1.SelectedIndex > 0)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
                }
                else
                {
                    listBox1.SelectedIndex = p.Length - 1;
                }
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Previous", pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                progressBar1.Value = 0;
                label2.Text = "";
                label3.Text = "";
                pictureBox6.Visible = false;
                listBox1.SelectedIndex= - 1;

            }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Stop", pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (c == "play" && listBox1.SelectedItems.Count != 0)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox4.Image = Properties.Resources.Pause;
                c = "pause";
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                pictureBox4.Image = Properties.Resources.play;
                c = "play";
            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        { 
            if (c =="play")
            {
                toolTip1.Show("Play", pictureBox4);
            }
            else
            {
                toolTip1.Show("Pause", pictureBox4);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e) 
        {
            if (listBox1.Items.Count != 0)
            {
                if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                }
                else
                {
                    listBox1.SelectedIndex = 0;
                }
            }
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Next", pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0 && listBox1.SelectedItems.Count != 0)
            {

                var cheak = MessageBox.Show("Are you sure to remove this song?", "Remove Music", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (cheak == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Music_tle where music='" + listBox1.SelectedItem.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    progressBar1.Value = 0;
                    label2.Text = "";
                    label3.Text = "";
                    //  listBox1.Items.Remove(listBox1.SelectedItem);
                    con.Close();
                    // groupBox1.Text = "";
                    //  groupBox1.Visible = false;
                    //   p = "";
                    //  boxshow();
                }
                else if (cheak == DialogResult.No)
                {

                }
                else if (cheak == DialogResult.Cancel)
                {

                }
            }
            else if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Music player is empty", "Remove Music", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a music", "Remove Music", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            boxshow();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Remove", pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.xBLACK;

        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.RED1;

        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Exit",pictureBox7);

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.RED1;
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Exit", pictureBox11);
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.xBLACK;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.l;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.hh;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Power Button", pictureBox10);
        }

        private void pictureBox7_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.Show("Back", pictureBox7);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PowerStatus pwr = SystemInformation.PowerStatus;
            label5.Text = DateTime.Now.ToString("HH:mm");
            String per;
            per = pwr.BatteryLifePercent.ToString();
            double pkl = Convert.ToDouble(per);
            pkl = pkl * 100;
            progressBar2.Value = Convert.ToInt32(pkl);
            label6.Text = pkl.ToString() + "%";
            pictureBox12.Image = Properties.Resources.charging_battery_icon_charger_icon;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
