using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test05
{
    public partial class Form1 : Form
    {
        int v;
        Random r;
        public Form1()
        {
            r = new Random(100);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(r.Next()%2==0)
           
            label1.Text = "デスソース";
        }
        else{
        label1.Text = "シュネッケン";
    }
}