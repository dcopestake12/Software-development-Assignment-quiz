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
    public partial class Question4 : Form
    {
        public Question4()
        {
            InitializeComponent();
        }

        private void btnQuestion4_Click(object sender, EventArgs e)
        {
            // Closes the current form thats open
            this.Hide();
            //Displays the new question
            Question5 Q5 = new Question5();
            Q5.Show();
        }

        private void Question4_Load(object sender, EventArgs e)
        {

        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            //The label shows that the answer is incorrect if the user clicks the button
            lblCorrectOrWrong.Show();
            lblCorrectOrWrong.Text = "The answer is incorrect.";
            //Disables all other buttons when the button is clicked
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            //The label shows that the answer is incorrect if the user clicks the button
            lblCorrectOrWrong.Show();
            lblCorrectOrWrong.Text = "The answer is incorrect.";
            //Disables all other buttons when the button is clicked
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            //The label shows that the answer is incorrect if the user clicks the button
            lblCorrectOrWrong.Show();
            lblCorrectOrWrong.Text = "The answer is incorrect.";
            //Disables all other buttons when the button is clicked
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            //The label shows that the answer is correct if the user clicks the button
            lblCorrectOrWrong.Show();
            lblCorrectOrWrong.Text = "The answer is correct.";
            //Disables all other buttons when the button is clicked
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
            //Adds 1 to the score
            score.currentScore += 1;
        }
    }
}
