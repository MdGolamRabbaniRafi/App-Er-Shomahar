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
    public partial class Form7 : Form
    {
        string s;
        string cs = ConfigurationManager.ConnectionStrings["abcd"].ConnectionString;
        public Form7()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.xBLACK;
            trackBar1.Value = Convert.ToInt32(Form3.volume);
            label2.Text = Convert.ToString(trackBar1.Value) + "%";
            this.BackgroundImage = Properties.Resources.settings;
            pictureBox1.Image = Properties.Resources.xBLACK;
            trackBar1.Visible = false;
            pictureBox2.Image = Properties.Resources.hh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.xBLACK;
            pictureBox5.Image = Properties.Resources.BACK3;
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            trackBar1.Value =Form3.volume;
            label2.Text = Convert.ToString(trackBar1.Value) + "%";
            label2.Visible = false;
            button6.Visible = false;
            trackBar1.Visible = false;
            boxshow();
            pictureBox1.Image = Properties.Resources.xBLACK;
            pictureBox2.Image = Properties.Resources.hh;
            timer1.Start();
            // label1.Text = Form1.password;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            boxshow();
            if(Form1.password==null)
            {
                Form11 f8 = new Form11();
                f8.Show();
                this.Hide();
            }
            else if( Form1.password == "")
            {
                Form11 f8 = new Form11();
                f8.Show();
                this.Hide();
            }
            else
            {
                Form8 f11 = new Form8();
                f11.Show();
                this.Hide();
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
        }
        void boxshow()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select pass from pass_table";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Form1.password = (dr["pass"].ToString());
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button4.Visible = false;
            button6.Visible = true;
            trackBar1.Visible = true;
            label2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(trackBar1.Value) + "%";
            Form3.volume = trackBar1.Value;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button1.Visible = true;
            button4.Visible = true;
            button6.Visible = false;
            trackBar1.Visible = false;
            label2.Visible = false;
            update();
        }
        void update()
        {
            SqlConnection co = new SqlConnection(cs);
            co.Open();
            SqlCommand cm = co.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from volume where vol='" +Convert.ToString(Form3.volume) + "'";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                s = dr["c"].ToString();
            }
            co.Close();
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update volume set vol=@vol where c=@c";
            cmd.Parameters.AddWithValue("@c", "1");
            cmd.Parameters.AddWithValue("@vol", Convert.ToString(trackBar1.Value));
            cmd.ExecuteNonQuery();
            //  listBox1.Items.Remove(listBox1.SelectedItem);
            con.Close();

        }

        private void button38_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
        }

        private void trackBar1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(label2.Text, trackBar1);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.xBLACK;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.RED1;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Exit", pictureBox1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Gray;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Gray;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Black;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.RED1;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.xBLACK;
        }

        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.Show("Exit", pictureBox1);
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
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
