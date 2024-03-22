using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Group_Project
{
    public partial class Form6 : Form
    {
        static int j = 0;
        static int k = 0;
        string cs = ConfigurationManager.ConnectionStrings["abcd"].ConnectionString;
        static string s;
      //  ArrayList notepadname = new ArrayList();
      //  ArrayList notetext = new ArrayList();
        static string p = ""; 


        //  public static string[] notepadname=new string[20];
        //  public static string[] notetext = new string[20];

        public Form6()
        {
            InitializeComponent();
         
            button7.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            groupBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            this.BackgroundImage = Properties.Resources.notepad1;
            pictureBox2.Image = Properties.Resources.hh;
            pictureBox1.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox7.Image = Properties.Resources.Remove1;
            pictureBox4.Image = Properties.Resources.xBLACK;
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            pictureBox1.Image = Properties.Resources.Addm__1_;
            pictureBox5.Image = Properties.Resources.BACK3;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.wifi_error_wrong_incorrect_disconnect_260nw;
            pictureBox6.Image = Properties.Resources.edit;
            pictureBox1.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox2.Image = Properties.Resources.hh;
            boxshow();
            groupBox1.Text = "";
            timer1.Start();
            pictureBox4.Image = Properties.Resources.xBLACK;
            pictureBox5.Image = Properties.Resources.BACK3;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(p=="")
            {
                pictureBox1.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                listBox1.Visible = true;
                string lk = DateTime.Now.ToString("hh:mm:ss tt");
                SqlConnection con = new SqlConnection(cs);
                string query = "Insert into mynotetable values(@Name,@Text,@arrindex)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Text", textBox2.Text);
                cmd.Parameters.AddWithValue("@arrindex",lk);
                con.Open();
                int p = cmd.ExecuteNonQuery();
                if (p > 0)
                {
                    MessageBox.Show("Information save successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    boxshow();
                }
                else
                {
                    MessageBox.Show("Information does not save successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                label1.Visible = false;
                label2.Visible = false;
                textBox2.Visible = false;
                textBox1.Visible = false;
                button7.Visible = false;
                textBox1.Clear();
                textBox2.Clear();
                boxshow();
            }
            else
            {
                // int i = listBox1.SelectedIndex;
                //  notepadname.RemoveAt(i);
                //  notetext.RemoveAt(i);
                //   int i=listBox1.SelectedIndex;
                //  string add = textBox1.Text;
                //   listBox1.Items.RemoveAt(i);
                //   listBox1.Items.Insert(i, add);
                //   notepadname.Insert(i,textBox1.Text);
                //   notetext.Insert(i,textBox2.Text);



                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update mynotetable set Name=@name,Text=@text where arrindex=@arrindex";
                cmd.Parameters.AddWithValue("arrindex", s);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@text", textBox2.Text);
                cmd.ExecuteNonQuery();
                //  listBox1.Items.Remove(listBox1.SelectedItem);
                con.Close();
                groupBox1.Text = "";
                groupBox1.Visible = false;
                boxshow();
                label1.Visible = false;
                label2.Visible = false;
                textBox2.Visible = false;
                textBox1.Visible = false;
                button7.Visible = false;
                textBox1.Clear();
                textBox2.Clear();
                p = "";
                boxshow();
                pictureBox1.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                listBox1.Visible = true;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count != 0)
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from mynotetable where Name='" + listBox1.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox1.Text = dr["Text"].ToString();
                }
                con.Close();
                groupBox1.Visible = true;
            }
            else
            {
                int a = 10;
                int b = a;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1 =new  Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
        void boxshow()
        {
            listBox1.Items.Clear();
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Name from mynotetable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["Name"].ToString());
            }
            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            j++;
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            k++;
        }

        private void button38_Click(object sender, EventArgs e)
        {
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           // toolTip1.Show("Back", button1);
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
           // toolTip1.Show("Power Button", button6);
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter Name", textBox1);
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter Text", textBox2);
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Save", button7);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {

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

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.l;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
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
            toolTip1.Show("Back", pictureBox5);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form3 h = new Form3();
            h.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
            button7.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            groupBox1.Visible = false;
            p = "";
            listBox1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            boxshow();

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0 && listBox1.SelectedItems.Count != 0)
            {
                //  int i = listBox1.SelectedIndex;
                // textBox1.Text = Convert.ToString(notepadname[i]);
                // textBox2.Text = Convert.ToString(notetext[i]);
                p = "edit";
                label1.Visible = true;
                label2.Visible = true;
                textBox2.Visible = true;
                textBox1.Visible = true;
                button7.Visible = true;
                groupBox1.Visible = false;
                listBox1.Visible = false;
                pictureBox1.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from mynotetable where Name='" + listBox1.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox2.Text = dr["Text"].ToString();
                    textBox1.Text = dr["Name"].ToString();
                    s = dr["arrindex"].ToString();
                }
                con.Close();
            }
            else if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Notepad is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Sellect a item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Edit", pictureBox6);
        }

        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.Show("Add", pictureBox1);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0 && listBox1.SelectedItems.Count != 0)
            {
                var cheak = MessageBox.Show("Are you sure to remove this Item?", "Remove Item", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (cheak == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from mynotetable where Name='" + listBox1.SelectedItem.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    //  listBox1.Items.Remove(listBox1.SelectedItem);
                    con.Close();
                    groupBox1.Text = "";
                    groupBox1.Visible = false;
                    p = "";
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
                MessageBox.Show("Notepad is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Sellect a item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            boxshow();

        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Remove", pictureBox7);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
