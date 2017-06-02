using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    
    public partial class 上 : Form
    {
        int speed = 10;
        int movex;
        int movey;
        
        public 上()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // pictureBox1.Top -= speed;
            movey = -speed;
            movex = 0;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //pictureBox1.Top += speed;
            movey = +speed;
            movex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // pictureBox1.Left -= speed;
            movex = -speed;
            movey = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //pictureBox1.Left += speed;
            movex = +speed;
            movey = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += movex;
            pictureBox1.Top += movey;
        }
    }
}
