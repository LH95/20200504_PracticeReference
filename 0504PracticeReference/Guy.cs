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

        public void TellMe(string message, Guy WhoSaidIt)
        {
            MessageBox.Show(WhoSaidIt.Name + " says : " + message, WhoSaidIt.Name);
        }

        public void SpeakTo(string message,Guy WhoToTalkTo)
        {
            // 物件溝通使用this
            WhoToTalkTo.TellMe(message, this);
        }
    }
}