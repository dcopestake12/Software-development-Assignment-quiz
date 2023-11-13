using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Software_development_Assignment_quiz.Homepage;

namespace Software_development_Assignment_quiz
{
    public partial class Question5 : Form
    {
        public Question5()
        {
            InitializeComponent();
        }

        private void btnQuestion5_Click(object sender, EventArgs e)
        {

            //Hides the current form thats open so it is not visible
            this.Hide();
            //Displays the last final form
            Final Fi = new Final();
            Fi.Show();
        }

        private void Question5_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //When submit button is clicked textbox and submit button are disabled
            txtBoxEntry.Enabled = false;
            btnSubmit.Enabled = false;


            //These if and if else statements are used to show the user got the answer correct 
            if (txtBoxEntry.Text.Contains("Lympstone"))
            {
                lblCorrectOrWrongEntry.Text = "The answer is correct";
                //Adds 1 to the score
                score.currentScore += 1;
            }


            else if (txtBoxEntry.Text.Contains("lympstone"))
            {
                lblCorrectOrWrongEntry.Text = "The answer is correct";
                //Adds 1 to the score
                score.currentScore += 1;
            }

            else if (txtBoxEntry.Text.Contains("Lympstone Commando"))
            {
                lblCorrectOrWrongEntry.Text = "The answer is correct";
                //Adds 1 to the score
                score.currentScore += 1;
            }

            else if (txtBoxEntry.Text.Contains("lympstone commando"))
            {
                lblCorrectOrWrongEntry.Text = "The answer is correct";
                //Adds 1 to the score
                score.currentScore += 1;
            }

            //The else is used if the user entered the wrong answer
            else
            {
                lblCorrectOrWrongEntry.Text = "The answer is wrong";
            }
        }

        private void txtBoxEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbScore_Click(object sender, EventArgs e)
        {

        }
    }
}

