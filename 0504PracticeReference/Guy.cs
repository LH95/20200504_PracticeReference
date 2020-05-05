using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0504PracticeReference
{
    class Guy
    {
        public int Old;
        public string Name;

        public void WhoAmI()
        {
            MessageBox.Show("  \" "+ Name + " \"  ,  Old:" + Old, Name+"'s");
        }
    }
}