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
            ///Guy
            A = new Guy() { Name = "A", Old = 23 };
            B = new Guy() { Name = "B", Old = 24 };
            ///MenuMaker
            MenuMaker menu = new MenuMaker() { Randomizer = new Random() };
            label2.Text = menu.GetMenuItem();
            label3.Text = menu.GetMenuItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A.WhoAmI();
            A.TellMe("Hi! I am A. ", A);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            B.WhoAmI();
            B.SpeakTo("Hello!! I am B. ", A);
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
            B.Old = 6666;
            B.WhoAmI();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }


    }
}
