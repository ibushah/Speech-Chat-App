using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication11
{
    class TextModifier
    {

      string _s;
     
        

        public TextModifier(string s)

        {
            this._s = s;

        }
        public string str
        {
            get
            {
                return this._s;
            }
            set
            {
                this._s = value;
            }
        }

        protected string remwhitespa()
        {
            string result = string.Empty;
            char[] textchar = this._s.ToCharArray();

            char prevchar = ' ';
            for (int i  = 0; i  <textchar.Length; i ++)
            {
                char current = textchar[i];
                if (prevchar == ' ' && current == prevchar)
                    continue; //ignore this
                else
                    result = result + current;
                prevchar = current;
            }
            this._s = result;
            return this._s;
        }

        protected string nichay()
        {
            string f=this._s.ToLower();
            this._s=f;
            return this._s;
        
        }
        public  string tamam()
        {
            nichay();
            remwhitespa();
            return this._s;
        }
        
        
    }
}
