using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0504PracticeReference
{
    public partial class Form1 : Form
    {
        Guy A;
        Guy B;
        public Form1()
        {
            InitializeComponent();
            A = new Guy() { Name = "A", Old = 23 };
            B = new Guy() { Name = "B", Old = 24 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            B.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guy tmp;
            tmp = B;
            B = A;
            A = tmp;
            MessageBox.Show("Object Swapped");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            A = B;
            A.Old = 6666;
            A.WhoAmI();
        }
    }
}
