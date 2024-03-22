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
    public partial class Form13 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["abcd"].ConnectionString;
        int p = 0;
        string s;
        public Form13()
        {
            InitializeComponent();
            pictureBox6.Image = Properties.Resources.xBLACK;
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            pictureBox4.Image = Properties.Resources.hh;
            pictureBox1.Image = Properties.Resources.Previous;
            pictureBox2.Image = Properties.Resources.Nextmu;
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
            pictureBox5.Image = Properties.Resources.BACK3;
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            pictureBox2.Image = Properties.Resources.Nextmu;
            pictureBox4.Image = Properties.Resources.hh;
          //  button1.Text = "";
            //button6.Text = "";
            pictureBox1.Image = Properties.Resources.Previous;
            //button6.Image = Properties.Resources.hh;
            //button1.Image = Properties.Resources.BACK3;
            pictureBox6.Image = Properties.Resources.xBLACK;
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


            // imageList1.Images[0] = Properties.Resources.sky;
            //   imageList1.Images[1] = Properties.Resources.nature;
            // imageList1.Images[2] = Properties.Resources.nature2;
            //  imageList1.Images[3] = Properties.Resources.nature3;
            //  imageList1.Images[4] = Properties.Resources.nature4;
            this.BackgroundImage = imageList1.Images[p];
            pictureBox1.Image = Properties.Resources.Previous;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3.count = Convert.ToString(p);
            update();
           // MessageBox.Show("");
            MessageBox.Show("Home Screen Background set successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();

        }
        void set()
        {
            Form3.count="";
            update();
           // MessageBox.Show(");
            MessageBox.Show("Home Screen Background Removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            set();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 f1 = new Form12();
            f1.Show();
            this.Hide();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (p != 0)
            {
                p--;
            }
            else
            {
                p = imageList1.Images.Count - 1;
            }
            this.BackgroundImage = imageList1.Images[p];

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Previous Image", pictureBox1);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Next Image", pictureBox2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (p < imageList1.Images.Count - 1)
            {
                p++;
            }
            else
            {
                p = 0;
            }
            this.BackgroundImage = imageList1.Images[p];
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
           // pictureBox7.Image = Properties.Resources.RED1;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
          //  pictureBox7.Image = Properties.Resources.xBLACK;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
          //  toolTip1.Show("Exit", pictureBox7);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
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

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Gray;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.RED1;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Exit", pictureBox6);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.xBLACK;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.l;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Power Button", pictureBox4);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.hh;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Show();
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
            pictureBox8.Image = Properties.Resources.charging_battery_icon_charger_icon;
            label5.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
