using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Software_development_Assignment_quiz.Homepage;

namespace Software_development_Assignment_quiz
{
    public partial class Question1 : Form
    {

        
        public Question1()
        {
            InitializeComponent();

        }

        private void btnQuestion1_Click(object sender, EventArgs e)
        {
            // Closes the current form thats open
            this.Close();
            //Displays the new question
            Question2 Q2 = new Question2();
            Q2.Show();
            


        }

        


        private void btnOption1_Click(object sender, EventArgs e)
        {
            //The label shows that the answer is correct if the user cliks the button
            lblCorrectOrWrong.Text = "The answer is correct.";
            //Disables all other buttons when the button is clicked
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
            //Adds 1 to the score
            score.currentScore += 1;
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            //The label shows that the answer is incorrect if the user clicks the button
            lblCorrectOrWrong.Text = "The answer is wrong.";
            //Disables all other buttons when the button is clicked
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            //The label shows that the answer is incorrect if the user clicks the button
            lblCorrectOrWrong.Text = "The answer is wrong.";
            //Disables all other buttons when the button is clicked
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            //Disables all other buttons when the button is clicked
            lblCorrectOrWrong.Text = "The answer is wrong.";
            //Disables all other buttons when the button is clicked
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Question1_Load(object sender, EventArgs e)
        {

        }

    }
}