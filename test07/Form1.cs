using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // button1.Left += 100;
            timer1.Enabled = true;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //button1.Left += 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Left += 1;
            button1.Top += 1;
        }
    }
}