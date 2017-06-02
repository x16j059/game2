using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kadai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new System.Random();
                
            int v = r.Next() % 3;
            System.String m;
            if (v == 1)
            {
                m = "大吉";
            }
            else if (v == 2)
            {
                m = "吉";
            }
            else if (v == 3)
            {
                m = "凶";
            }
            else 
            {
                m = "大凶";
            }
           
        }
        
        Label=
        Labe1l.Text= m;
    }
}
