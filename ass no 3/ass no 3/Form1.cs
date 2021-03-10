using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass_no_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
            this.Size = new Size(600, 650);
            TrackBar t = new TrackBar();
            t.Size = new Size(550, 30);
            t.BackColor = Color.Black;
            t.Location = new Point(10, 540);
            this.Controls.Add(t);
            
            TextBox[] tb = new TextBox[5];
            for (int i = 0; i < tb.Length; i++)
            {
                tb[i] = new TextBox();
                tb[i].Text = "              SEC. # 1 FLOOR # " + i;
                tb[i].Size = new Size(200, 50);
                tb[i].BackColor = Color.Blue;
                tb[i].ForeColor = Color.White;
                tb[i].Location = new Point(200, 520 - (i * 20));
                this.Controls.Add(tb[i]);
            }
            Button[] b = new Button[6];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = new Button();
                b[i].Text = "SEC. # 2 FLOOR #  " + i;
                b[i].Size = new Size(160, 20);
                b[i].BackColor = Color.Gray;
                b[i].ForeColor = Color.White;
                b[i].Location = new Point(220, 420 - (i * 20));
                this.Controls.Add(b[i]);
            }
            Label[] l = new Label[10];
            for (int i = 0; i < l.Length; i++)
            {
                l[i] = new Label();
                l[i].Text = "   SEC. # FLOOR # " + i;
                l[i].Size = new Size(120, 20);
                l[i].BackColor = Color.Red;
                l[i].ForeColor = Color.White;
                l[i].Location = new Point(240, 300 - (i * 20));
                this.Controls.Add(l[i]);
            }
        }
    }
}
