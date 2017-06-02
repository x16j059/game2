﻿using System;
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
        int speed = 40;
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
            //
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += movex;
            pictureBox1.Top += movey;
        }

        private void 上_Load(object sender, EventArgs e)
        {
            //
        }


        //keybord
        private void 上_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                movey = -speed;
                movex = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                movey = +speed;
                movex = 0;
            }
             if (e.KeyCode == Keys.Left)
            {
                movex = -speed;
                movey = 0;
            }
             if (e.KeyCode == Keys.Right)
            {
                movex = +speed;
                movey = 0;
            }
        }

        private void 上_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                movey = 0;
                movex = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                movey = 0;
                movex = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                movex = 0;
                movey = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                movex = 0;
                movey = 0;
            }
        }
    }
}
