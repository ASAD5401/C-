using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assign_no_1
{
    public partial class Form1 : Form
    {
        Double tick = 0.0;
        Double speed = 0.0;
        int rem_dis=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int frm_wid = this.Width;
            int picbox_wid = pictureBox1.Width;
            tick++;
            pictureBox1.Left += 10;
            pictureBox2.Left += 8;
            if (pictureBox1.Left > (frm_wid-picbox_wid))
            {
                timer1.Stop();
                speed = frm_wid / tick;
                label1.Text = "Speed is : "+Convert.ToString(Math.Round(speed,2));
                rem_dis = frm_wid - pictureBox2.Location.X;
                speed = (frm_wid - rem_dis) / tick;
                label2.Text = "Speed is : " + Convert.ToString(Math.Round(speed, 2));
                MessageBox.Show("UPPER CAR IS WINNER!!!"+Environment.NewLine+label1.Text+Environment.NewLine+label2.Text);
                
            }
            
            else if (pictureBox2.Left > (frm_wid - picbox_wid))
            {
                timer1.Stop();
                speed = frm_wid / tick;
                label2.Text = "Speed is : " + Convert.ToString(Math.Round(speed, 2));
                rem_dis = frm_wid - pictureBox1.Location.X;
                speed = (frm_wid - rem_dis) / tick;
                label1.Text = "Speed is : " + Convert.ToString(Math.Round(speed, 2));
                MessageBox.Show("LOWER CAR IS WINNER!!!" + Environment.NewLine + label1.Text + Environment.NewLine + label2.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        
    }
}
