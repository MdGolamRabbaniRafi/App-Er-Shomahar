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
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["abcd"].ConnectionString;
        // public static string image;
        public static string password;
        public Form1()
        {
            InitializeComponent();
            boxshow();
            pictureBox1.Image = Properties.Resources.xBLACK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boxshow();
            if (password==null)
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else if(password=="")
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.l;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.hh;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boxshow();
            pictureBox1.Image = Properties.Resources.xBLACK;
          
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
                password = (dr["pass"].ToString());
            }
            con.Close();
            button1.Text = "";
            button1.Image = Properties.Resources.hh;
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

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.xBLACK;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Power Button", button1);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Exit", pictureBox1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form16 r = new Form16();
            r.Show();
            this.Hide();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }
    }
}
