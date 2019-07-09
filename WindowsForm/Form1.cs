using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
// this is for mp3 player
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        // this is for the mp3 player variables
        private string _command;
        private bool isOpen;

        // this is the command for mp3 player (must import system.runtime.interopservices)

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int returnLength, IntPtr hwmdCallback);


        public Form1()
        {
            InitializeComponent();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            string fNumber = txOne.Text;
            string sNumber = txTwo.Text;
            int firstNumber;
            int secondNumber;
            Int32.TryParse(fNumber, out firstNumber);
            Int32.TryParse(sNumber, out secondNumber);
            int s = firstNumber + secondNumber;
            string sum = Convert.ToString(s);
            lbOut.Text = "The Sum IS: " + sum;



        }

        private void BtSubtract_Click(object sender, EventArgs e)
        {
            string fNumber = txOne.Text;
            string sNumber = txTwo.Text;
            int firstNumber;
            int secondNumber;
            Int32.TryParse(fNumber, out firstNumber);
            Int32.TryParse(sNumber, out secondNumber);
            int s = firstNumber - secondNumber;
            string sum = Convert.ToString(s);
            lbOut.Text = "The Sum IS: " + sum;
        }

        private void BtMultiply_Click(object sender, EventArgs e)
        {
            string fNumber = txOne.Text;
            string sNumber = txTwo.Text;
            int firstNumber;
            int secondNumber;
            Int32.TryParse(fNumber, out firstNumber);
            Int32.TryParse(sNumber, out secondNumber);
            int s = firstNumber * secondNumber;
            string sum = Convert.ToString(s);
            lbOut.Text = "The Sum IS: " + sum;
        }

        private void BtDivide_Click(object sender, EventArgs e)
        {
            string fNumber = txOne.Text;
            string sNumber = txTwo.Text;
            int firstNumber;
            int secondNumber;
            Int32.TryParse(fNumber, out firstNumber);
            Int32.TryParse(sNumber, out secondNumber);
            int s = firstNumber / secondNumber;
            string sum = Convert.ToString(s);
            lbOut.Text = "The Sum IS: " + sum;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txOne.Clear();
            txTwo.Clear();
            lbOut.Text = " ";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
                string myFirstText = txOne.Text;
                string mySecondText = txTwo.Text;

            if (ckMale.Checked)
            {
                

                lbOut.Text = "Hello " + myFirstText + " " + mySecondText + " You Are A Male";
            }

            else if (ckFemale.Checked)
            {
                lbOut.Text = "Hello " + myFirstText + " " + mySecondText + " You Are A Female";
            }

            else { lbOut.Text = "No Box Is Checked!"; }

            
        }

        // this looks for the mp3 file

        private void BtBrowes_Click(object sender, EventArgs e)
        {

            OpenFileDialog mp3File = new OpenFileDialog();
            mp3File.Filter = "mp3 files|*.mp3|All files (*.*)|*.*";
            mp3File.FilterIndex = 1;

            if (mp3File.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = mp3File.FileName.ToString();

            }





        }

        // this plays the mp3 file

        public void Play(bool loop)
        {

            if (isOpen)
            {
                _command = "play MediaFile";

                if (loop)
                
                    _command += "REPEAT";
                mciSendString(_command, null, 0, IntPtr.Zero);

                

            }



        }

        // this opens the mp3 player

        public void OpenPlayer(string sFileName)
        {

            _command = "open \"" + sFileName + "\" type mpegvideo alias MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);
            isOpen = true;
        }

        // this closes the mp3 player

        public void ClosePlayer()
        {
            _command = "close MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);
            isOpen = false;

        }


        // this is to play the mp3 with button

        private void BtPlay_Click(object sender, EventArgs e)
        {

            try
            {
                this.OpenPlayer(this.textBox1.Text);
                this.Play(false);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        // this stops the mp3 from playing

        private void BtStop_Click(object sender, EventArgs e)
        {

            try
            {

                this.ClosePlayer();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
