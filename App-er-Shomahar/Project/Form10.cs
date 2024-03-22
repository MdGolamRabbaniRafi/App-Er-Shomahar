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
    public partial class Form10 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["abcd"].ConnectionString;
        static string s;
        public Form10()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.password;
            pictureBox1.Image = Properties.Resources.enter2;
            pictureBox5.Image = Properties.Resources.BACK3;
            pictureBox4.Image = Properties.Resources.xBLACK;
            pictureBox2.Image = Properties.Resources.hh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Your passwor first");
                textBox1.Focus();
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
            pictureBox1.Image = Properties.Resources.enter2;
            pictureBox4.Image = Properties.Resources.xBLACK;
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            pictureBox5.Image = Properties.Resources.BACK3;
            textBox2.UseSystemPasswordChar = true;
            textBox1.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
            checkBox2.Checked = false;
            pictureBox2.Image = Properties.Resources.hh;
            if(Form1.password==null|Form1.password=="")
            {
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = false;
                textBox3.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Clear();
                textBox1.Focus();
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label4.Visible = true;
                textBox3.Visible = true;
                textBox1.Visible = false;
                textBox2.Visible = false;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox1.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox1.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (label4.Visible == false)
            {
                if (textBox1.Text == textBox2.Text && textBox1.Text!=""&& textBox1.Text != null)
                {
                    if (Form1.password == "" | Form1.password == null)
                    {
                        string lk = DateTime.Now.ToString("hh:mm:ss tt");
                        SqlConnection con = new SqlConnection(cs);
                        string query = "Insert into pass_table values(@pass,@c)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                        cmd.Parameters.AddWithValue("@c", lk);
                        con.Open();
                        int p = cmd.ExecuteNonQuery();
                        if (p > 0)
                        {
                            MessageBox.Show("Password set successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Clear();
                            textBox2.Clear();
                            Form1.password = textBox2.Text;
                            Form7 f7 = new Form7();
                            f7.Show();
                            this.Hide();
                            Form8.remove = null;
                            Form8.set = "set";
                        }
                        else
                        {
                            MessageBox.Show("Password does not save successfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        con.Close();
                    }
                    else
                    {
                        SqlConnection co = new SqlConnection(cs);
                        co.Open();
                        SqlCommand cm = co.CreateCommand();
                        cm.CommandType = CommandType.Text;
                        cm.CommandText = "select * from pass_table where pass='" + Form1.password + "'";
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
                        cmd.CommandText = "update pass_table set pass=@pass where c=@c";
                        cmd.Parameters.AddWithValue("c", s);
                        cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Form1.password = textBox2.Text;
                        MessageBox.Show("Password change successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Clear();
                        textBox2.Clear();
                        Form7 f7 = new Form7();
                        f7.Show();
                        this.Hide();
                    }
                }

                else if (textBox1.Text == "")
                {
                    MessageBox.Show("Fill the both box", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Focus();
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Fill the both box", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox2.Focus();
                }
                else if (textBox1.Text != textBox2.Text)
                {
                    MessageBox.Show("Password are not matched", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Focus();
                }
            }
            else if (label4.Visible == true)
            {
                if (Form8.remove == "remove")
                {
                    if (textBox3.Text == Form1.password)
                    {
                        SqlConnection con = new SqlConnection(cs);
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from pass_table where pass='" + Form1.password + "'";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Form1.password = "";
                        MessageBox.Show("Password Removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form7 f7 = new Form7();
                        f7.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);                         textBox3.Clear();
                        textBox3.Focus();
                    }
                }
                else if (textBox3.Text == Form1.password)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label4.Visible = false;
                    textBox3.Visible = false;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Clear();
                    textBox1.Focus();
                    checkBox2.Checked = false;
                }
                else
                {
                    MessageBox.Show("Wrong Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); textBox3.Clear();
                    textBox3.Clear();
                    textBox3.Focus();
                }
            }

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter", pictureBox1);
        }

        private void button38_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.RED1;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.xBLACK;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Exit", pictureBox2);
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter Password", textBox3);
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter Password", textBox1);
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Confirm Password", textBox2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.RED1;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Exit", pictureBox4);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.xBLACK;
        }

        private void pictureBox2_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.l;
        }

        private void pictureBox2_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.Show("Power Button",pictureBox4);
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.hh;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            Form8.remove = null;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.Show();
            Form8.remove = null;
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
