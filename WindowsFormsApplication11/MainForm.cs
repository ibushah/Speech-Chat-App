using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace WindowsFormsApplication11
{
    public partial class MainForm : Form
    {
      SpeechSynthesizer read = new SpeechSynthesizer();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
            writetxt.Focus();
            
            maintxt.AcceptsReturn = true;
            // Allow the TAB key to be entered in the TextBox control.
            maintxt.AcceptsTab = true;
            // Set WordWrap to true to allow text to wrap to the next line.
            maintxt.WordWrap = true;
        }

        private void writetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            writetxt.Text = "";
            maintxt.Text = "";
        }

        private void writetxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                

                if (!string.IsNullOrWhiteSpace(writetxt.Text))
                {
                    maintxt.Text += "User: ";
                    maintxt.Text += writetxt.Text;
                    maintxt.Text += "\r\n";


                    FinalClass fin = new FinalClass(writetxt.Text);

                    maintxt.Text += "Nargis: " + fin.output;
                    writetxt.Text = "";
                    maintxt.Text += "\r\n\r\n";
                    if (fin.output != "yes")
                    {
                        speak(fin.output);
                    }
                    else
                    {
                        read.Rate = 5;
                        speak("Cats n dogs Cats n dogs Cats n dogs Cats n dogs Cats n dogs Cats n dogs Cats n dogs Cats n dogs Cats n dogs Cats n dogs Cats n dogs");
                
                    }
                }
          
            else
            {
                MessageBox.Show("Error:Atleast Write Something");
            }
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(writetxt.Text))
            {
                maintxt.Text += "User: ";
                maintxt.Text += writetxt.Text;
                maintxt.Text += "\r\n";


                FinalClass fin = new FinalClass(writetxt.Text);

                maintxt.Text += "Nargis: " + fin.output;
                writetxt.Text = "";
                maintxt.Text += "\r\n\r\n";
                if (fin.output != "yes")
                {
                    speak(fin.output);
                }
                else
                {

                    speak("btk btk btk btk btk btk btk btk btk btk btk btk");
                }
            }
            else
            {
                MessageBox.Show("ERROR:Atleast write something");
            }
          
          
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            stop();
           
        }
        public void speak(string s)
        {
            read.Dispose();
            read = new SpeechSynthesizer();
            read.SelectVoiceByHints(VoiceGender.Female);
            read.Rate = 0;
            read.SpeakAsync(s);
        }
        public void stop()
        {
            read.Dispose();
        }
    }
}
