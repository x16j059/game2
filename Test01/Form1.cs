using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test01
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ans;
            ans = int.Parse(textBox1.Text) + int.Parse (textBox2.Text);
            textBox3add.Text= String.Format("{0}",ans);
        }
        
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int ans;
                ans = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                textBox3add.Text = String.Format("{0}", ans);
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int ans;
                ans = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                textBox3add.Text = String.Format("{0}", ans);
            }
        }
    }
}