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
    public partial class Form9 : Form
    {
        string p = "";
        static string s;
        string cs = ConfigurationManager.ConnectionStrings["abcd"].ConnectionString;
        public Form9()
        {
            InitializeComponent();
            boxshow();
            pictureBox2.Image = Properties.Resources.hh;
            pictureBox1.Image = Properties.Resources.xBLACK;
            pictureBox1.Image = Properties.Resources.xBLACK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
            button2.BackColor = Color.Gray;
            pictureBox1.Image = Properties.Resources.xBLACK;
            pictureBox7.Image = Properties.Resources.Addm__1_;
            pictureBox6.Image = Properties.Resources.edit;
            pictureBox4.Image = Properties.Resources.Remove1;
            pictureBox1.Image = Properties.Resources.xBLACK;
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            pictureBox5.Image = Properties.Resources.BACK3;
            this.BackgroundImage = Properties.Resources.pbook3;
            pictureBox2.Image = Properties.Resources.hh;
            boxshow();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lp = 0;
           
                int k = 0;
                char[] pl = (textBox2.Text).ToCharArray();
                
                  try 
                  {
                   for(int i=0;i<pl.Length;i++)
                   {
                    string l = Convert.ToString(pl[i]);
                    k = Convert.ToInt32(l);
                   }
                   lp = 2;
                  }
                  catch (Exception)
                  {
                    MessageBox.Show("Only Numbers are acceptable", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox2.Clear();
                    textBox2.Focus();
                    lp = 0;
                  }
                

         
            if(lp!=0)
            {
                if (p == "")
                {
                    string lk = DateTime.Now.ToString("hh:mm:ss tt");
                    SqlConnection con = new SqlConnection(cs);
                    string query = "Insert into phn_table values(@Name,@Number,@c)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Number", textBox2.Text);
                    cmd.Parameters.AddWithValue("@c", lk);
                    con.Open();
                    int p = cmd.ExecuteNonQuery();
                    if (p > 0)
                    {
                        MessageBox.Show("Contact save successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label1.Visible = false;
                        label2.Visible = false;
                        textBox2.Visible = false;
                        textBox1.Visible = false;
                        button2.Visible = false;
                        dataGridView1.Visible = true;
                        pictureBox7.Visible = true;
                        pictureBox6.Visible = true;
                        pictureBox4.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Contact Does not save successfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    con.Close();
                    boxshow();
                }
                else
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update phn_table set Name=@Name,Number=@Number where c=@c";
                    cmd.Parameters.AddWithValue("c", s);
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Number", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    //  listBox1.Items.Remove(listBox1.SelectedItem);
                    con.Close();
                    boxshow();
                    label1.Visible = false;
                    label2.Visible = false;
                    textBox2.Visible = false;
                    textBox1.Visible = false;
                    button2.Visible = false;
                    dataGridView1.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox4.Visible = true;
                    textBox1.Clear();
                    textBox2.Clear();
                    p = "";
                    boxshow();
                    MessageBox.Show("Contact Edited successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
          
        }
        void boxshow()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = " select * from phn_table";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable data =new DataTable();
            cmd.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.Columns[2].Visible = false;
            if(textBox1.Visible==true)
            {
                dataGridView1.Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
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

        private void button3_MouseHover(object sender, EventArgs e)
        {
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Name", textBox1);

        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Number", textBox2);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Save", button2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Back",pictureBox5);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 h = new Form1();
            h.Show();
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button2.Visible = true;
            dataGridView1.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox4.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                p = "e";
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                button2.Visible = true;
                dataGridView1.Visible = false;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from phn_table where Name='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox2.Text = dr["Number"].ToString();
                    textBox1.Text = dr["Name"].ToString();
                    s = dr["c"].ToString();
                }
                con.Close();
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox4.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select data properly", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from phn_table where Name='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                //  listBox1.Items.Remove(listBox1.SelectedItem);
                con.Close();
                p = "";
                boxshow();
            }
            catch (Exception)
            {
                int i = dataGridView1.Rows.Count;
                // label3.Text = Convert.ToString(i);
                if (i < 2)
                {
                    MessageBox.Show("No data founded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please select data properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkGray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gray;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Add", pictureBox7);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Edit", pictureBox6);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Remove", pictureBox4);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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
