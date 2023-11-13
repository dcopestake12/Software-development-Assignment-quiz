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
    public partial class Question3 : Form
    {
        public Question3()
        {
            InitializeComponent();
        }

        private void btnQuestion3_Click(object sender, EventArgs e)
        {
            //Hides the current form thats open so it is not visible
            this.Hide();
            //Displays question 4
            Question4 Q4 = new Question4();
            Q4.Show();
        }

        private void Question3_Load(object sender, EventArgs e)
        {

        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            //Displays a message in the label saying the answer is wrong when button is clicked
            lblCorrectOrWrong.Text = "The answer is wrong.";
            //This disables all buttons when the button is clicked
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            //Displays a message in the label saying the answer is wrong when button clicked
            lblCorrectOrWrong.Text = "The answer is correct.";
            //This disables all buttons when the button is clicked
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
            //Adds 1 to the score
            score.currentScore += 1;

        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            //Displays a message in the label saying the answer is wrong when button clicked
            lblCorrectOrWrong.Text = "The answer is wrong.";
            //This disables all buttons when the button is clicked
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            //Displays a message in the label saying the answer is wrong when button clicked
            lblCorrectOrWrong.Text = "The answer is wrong.";
            //This disables all buttons when the button is clicked
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
        }
    }
}
