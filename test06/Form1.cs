using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test06
{
    public partial class Form1 : Form
    {
        // Random r;
        int c;
        String[] msg;
        public Form1()
        {
            InitializeComponent();
            // r = new Random();
            c = 0;
            msg = new string[3];
            msg[0] = "おはよう";
            msg[1] = "こんにちは";
            msg[2] = "こんばんは";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = msg[c];
            c = (c + 1)%3;
    }
    }
}