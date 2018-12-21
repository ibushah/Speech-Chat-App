using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    class structuring
    {
        Control mtext, wtext;
        public structuring(Control _mtext,Control _wtext)
        {
            this.mtext = _mtext;
            this.wtext = _wtext;
        }
        public void presentation()
        {

           
                mtext.Text =
                   mtext.Text += "User: ";
                mtext.Text += wtext.Text;
                mtext.Text += "\r\n";
                FinalClass fin = new FinalClass(wtext.Text);
                mtext.Text += "Nargis: " + fin.output;
                wtext.Text = "";
                mtext.Text += "\r\n\r\n";
            
            
        }
    }
}
