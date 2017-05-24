using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test03
{
    public partial class Form1 : Form
    {
        int[] dayCount = new int[12];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dayCount[0] = 31;
            dayCount[1] = 28;
            dayCount[2] = 31;
            dayCount[3] = 30;
            dayCount[4] = 31;
            dayCount[5] = 30;
            dayCount[6] = 31;
            dayCount[7] = 31;
            dayCount[8] = 30;
            dayCount[9] = 31;
            dayCount[10] = 30;
            dayCount[11] = 31;
        }
        int m = int.Parse(TextBox1.Text);

    }
}
