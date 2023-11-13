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
    public partial class Question2 : Form
    {
        public Question2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //When submit button is clicked textbox and submit button are disabled
            txtBoxEntry.Enabled = false;
            btnSubmit.Enabled = false;

            //These if and if else statements are used to show the user got the answer correct   
            if (txtBoxEntry.Text.Contains("Grant Shapps"))
            {
                lblCorrectOrWrong.Text = "The answer is correct.";
                //Adds 1 to the score
                score.currentScore += 1;
            }


            else if (txtBoxEntry.Text.Contains("grant shapps"))
            {
                lblCorrectOrWrong.Text = "The answer is correct.";
                score.currentScore += 1;
            }

            else if (txtBoxEntry.Text.Contains("grantshapps"))
            {
                lblCorrectOrWrong.Text = "The answer is correct.";
                score.currentScore += 1;
            }
            // The else is used if the user enters the incorrect answer
            else
            {
                lblCorrectOrWrong.Text = "The answer is wrong.";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Hides the current form thats open so it is not visible
            this.Hide();
            //Displays question 3
            Question3 Q3 = new Question3();
            Q3.Show();
        }

        private void txtBoxEntry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

