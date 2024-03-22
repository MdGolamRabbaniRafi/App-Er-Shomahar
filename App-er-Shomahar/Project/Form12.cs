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
    public partial class Form12 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["abcd"].ConnectionString;
        static string s;

        public Form12()
        {
            InitializeComponent();
            select();
            pictureBox5.Image = Properties.Resources.BACK3;
            pictureBox4.Image = Properties.Resources.xBLACK;
            pictureBox2.Image = Properties.Resources.hh;
            // pictureBox1.Image = Properties.Resources.xBLACK;
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            this.BackgroundImage = Properties.Resources._1125765_bigthumbnail;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            this.BackgroundImage = Properties.Resources._1125765_bigthumbnail;
            select();
            pictureBox5.Image = Properties.Resources.BACK3;
            pictureBox4.Image = Properties.Resources.xBLACK;
            pictureBox2.Image = Properties.Resources.hh;
            // pictureBox1.Image = Properties.Resources.xBLACK;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form3.back == "true")
            {
                SqlConnection co = new SqlConnection(cs);
                co.Open();
                SqlCommand cm = co.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from back_random where c='" + Convert.ToString(1) + "'";
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
                cmd.CommandText = "update back_random set back=@back where c=@c";
                cmd.Parameters.AddWithValue("c", s);
                cmd.Parameters.AddWithValue("@back", "false");
                cmd.ExecuteNonQuery();
                //  listBox1.Items.Remove(listBox1.SelectedItem);
                Form3.back = "false";
                MessageBox.Show("Stopped home background changed randomly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //   button1.Text= "Change Background randomly";
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();

            }
            else
            {
                SqlConnection co = new SqlConnection(cs);
                co.Open();
                SqlCommand cm = co.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from back_random where c='" + Convert.ToString(1) + "'";
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
                cmd.CommandText = "update back_random set back=@back where c=@c";
                cmd.Parameters.AddWithValue("c", s);
                cmd.Parameters.AddWithValue("@back", "true");
                cmd.ExecuteNonQuery();
                Form3.back = "true";
             //   button1.Text = "Stop Change Background randomly";
              //  MessageBox.Show("");
                MessageBox.Show("Now home background will be changed randomly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            Form3 f = new Form3();
            f.backimage();
            select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            this.Hide();
        }
        void select()
        {
            if(Form3.back=="true")
            {
                button1.Text = "Stop Change Background randomly";
                Form3.count = "";
                update();
            }
            else
            {
                button1.Text = "Change Background randomly";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        void update()
        {
            SqlConnection co = new SqlConnection(cs);
            co.Open();
            SqlCommand cm = co.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from back_select where c='" + Convert.ToString(1) + "'";
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
            cmd.CommandText = "update back_select set count=@count where c=@c";
            cmd.Parameters.AddWithValue("c", s);
            cmd.Parameters.AddWithValue("@count", Form3.count);
            cmd.ExecuteNonQuery();
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
          //  pictureBox1.Image = Properties.Resources.RED1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox1.Image = Properties.Resources.xBLACK;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
         //   toolTip1.Show("Exit", pictureBox1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gray;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.xBLACK;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.RED1;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Exit", pictureBox4);
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

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Back",pictureBox5);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
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
            pictureBox8.Image = Properties.Resources.charging_battery_icon_charger_icon;

        }
    }
}
