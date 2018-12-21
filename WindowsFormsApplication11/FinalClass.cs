using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    class FinalClass :TextModifier
    {
        string _input;
        string _output;

        public FinalClass(string input)
            : base(input)
        {
            this._input = input;
            sawal();
        }
        public string input
        {
            get
            {
                return _input;
            }
            set
            {
                _input = value;
            }
        }
        public string output
        {
            get
            {
                return _output;
            }
            set
            {
                _output = value;
            }
        }
        public void sawal()
        {
           
                switch (tamam())
                {
                    case "how are you":
                        _output = "Machines are always fine";

                        break;
                    case "How can i help you":
                        _output = "You can't hlp me";
                        break;
                    case "what are you doing":
                        _output = "I am fine sir";
                        break;
                    case "How can I hlp you":
                        _output = "You can't hlp me";
                        break;
                    case "what are you wearing":
                        _output = "I am fine sir";
                        break;
                    case "make me a sandwich":
                        _output = "You can't hlp me";
                        break;
                    case "call me an ambulance":
                        _output = "I am fine sir";
                        break;
                    case "i love you":
                        _output = "You can't hlp me";
                        break;
                    case "when is your birthday":
                        _output = "I am fine sir";
                        break;
                    case "who is your daddy and what does he do":
                        _output = "You can't hlp me";
                        break;
                    case "who is your favourite footballer":
                        _output = "I am fine sir";
                        break;
                    case "what is the meaning of life":
                        _output = "You can't hlp me";
                        break;
                    case "who makes the best projects":
                        _output = "I am fine sir";
                        break;
                    case "can you murder someone for me":
                        _output = "You can't hlp me";
                        break;
                    case "who is siri":
                        _output = "I am fine sir";
                        break;
                    case "you are my best friend":
                        _output = "You can't hlp me";
                        break;
                    case "how do i pass my finals":
                        _output = "I am fine sir";
                        break;
                    case "tell me a joke":
                        _output = "You can't hlp me";
                        break;
                    case "when the world is going to end":
                        _output = "I am fine sir";
                        break;
                    case "does santa exist":
                        _output = "You can't hlp me";
                        break;
                    case "i think i am drunk":
                        _output = "I am fine sir";
                        break;
                    case "are you a robot":
                        _output = "You can't hlp me";
                        break;
                    case "do you have any pets":
                        _output = "I am fine sir";
                        break;
                    case "how much do you cost":
                        _output = "You can't hlp me";
                        break;
                    case "":
                        _output = "I am fine sir";
                        break;
                    case "I would like to jump of the bridge":
                        _output = "You can't hlp me";
                        break;
                    case "are you a woman or man":
                        _output = "I am fine sir";
                        break;
                    case "do you believe in god":
                        _output = "You can't hlp me";
                        break;
                    case "how old are you":
                        _output = "I am fine sir";
                        break;
                    case "what is your favourite game":
                        _output = "You can't hlp me";
                        break;
                    case "which game do you hate the most":
                        _output = "I am fine sir";
                        break;
                    case "how much do you earn":
                        _output = "You can't hlp me";
                        break;
                    case "do you smoke":
                        _output = "You can't hlp me";
                        break;
                    case "what are you doing today after work":
                        _output = "I am fine sir";
                        break;
                    case "do you sleep":
                        _output = "You can't hlp me";
                        break;
                    case "what is your favourite colour":
                        _output = "I am fine sir";
                        break;
                    case "will you vote for nawaz":
                        _output = "You can't hlp me";
                        break;
                    case "I need to hide a body":
                        _output = "I am fine sir";
                        break;
                    case "what does the fox say":
                        _output = "You can't hlp me";
                        break;
                    case "do you beatbox":

                        _output = "yes";
                        break;
                    case "do you sing":
                        _output="ooh lala ooooh lala ooooooh lala , sorry no";
                        break;
                    default:
                        _output = "could not get you";
                        break;
                }
         

        }


        public void beatbox()
        {

            _output = "yes";
                    
           
        }
      
    }
    }

        
    

