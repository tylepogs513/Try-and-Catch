using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try_and_Catch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enterButt_Click(object sender, EventArgs e)
        {
            int number; // will store value entered by user

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(inputBox.Text);
                outputLabel.Text = "You entered the number " + number;
            }
            catch // display error message if input is not a number
            {
                outputLabel.Text = "You must enter an integer";
                return;
            }
        }
    }
}
