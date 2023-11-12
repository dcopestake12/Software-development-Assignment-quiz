using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Software_development_Assignment_quiz.Homepage;


namespace Software_development_Assignment_quiz
{
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
            //This converts the score to a string and displays it in the label
            lblScore.Text = "Your score is: " + score.currentScore.ToString() + " out of 5.";

            // If the user gets over 2 questions it says they don't need to retake the test
            if (score.currentScore > 2)
            {
                LblRetake.Text = "You don't need to to retake the test ";
            }

            // If they only get 2 or less questions correct then the user needs to retake the quiz
            else
            {
                LblRetake.Text = "You need to retake the test";

            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes the program when button is clicked
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
