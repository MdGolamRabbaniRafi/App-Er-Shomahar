using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 g = new Form1();
            g.Show();
            this.Hide();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.BACK3;
            pictureBox1.Image = Properties.Resources.MicrosoftTeams_image1;
            pictureBox2.Image = Properties.Resources.rafi_project1;
            pictureBox3.Image = Properties.Resources.faris;
            pictureBox4.Image = Properties.Resources.opee;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Back", pictureBox5);
        }
    }
}
