using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JJGSpeechRecognizer
{
    public partial class SpeechGUI : Form
    {
        
        public SpeechGUI()
        {
            InitializeComponent();
        }

        private void BTNStop_Click(object sender, EventArgs e)
        {
            BTNStop.Hide();
            BTNStart.Show();
            SpeechRecognizer.Stop();
            //SpeechRecognizer.RecognizeStop();
        }
        private void BTNStart_Click(object sender, EventArgs e)
        {
            BTNStart.Hide();
            BTNStop.Show();

            //SpeechRecognizer.Recognize(this);
            SpeechRecognizer.Start();
        }
        private void SpeechGUI_Load(object sender, EventArgs e)
        {
            //The recognizer grammar is loaded when the form is loaded.
            SpeechRecognizer.GrammarLoader(this);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private bool mouseDown;
        private Point lastLocation;
        private void SpeechGUI_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void SpeechGUI_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void SpeechGUI_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
    }
}
