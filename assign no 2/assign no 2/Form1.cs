using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assign_no_2
{
    public partial class Form1 : Form
    {
      //  bool moveLeft, moveUp, moveRight, moveDown;
        int speed = 12;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pictureBox6.Left += 10;
            }
            if (e.KeyCode == Keys.Right)
            {
                pictureBox6.Left +=10;
            }
            if (e.KeyCode == Keys.Up)
            {
                pictureBox6.Top+=10;
            }
            if (e.KeyCode == Keys.Down)
            {
                pictureBox6.Top-=10;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int j = rnd.Next(1, 1100);
            int k = rnd.Next(1, 450);
            int l = rnd.Next(1, 1100);
            int m = rnd.Next(1, 450);
            int n = rnd.Next(1, 1100);
            int o = rnd.Next(1, 450);
            int p = rnd.Next(1, 1100);
            int q = rnd.Next(1, 450);
            pictureBox1.Location = new Point(j, k);
            pictureBox2.Location = new Point(l, m);
            pictureBox3.Location = new Point(n, o);
            pictureBox4.Location = new Point(p, q);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
