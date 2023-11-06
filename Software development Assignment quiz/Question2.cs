using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_development_Assignment_quiz
{
    public partial class Question2 : Form
    {
        public Question2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Question3 Q3 = new Question3();
            Q3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBoxEntry_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
        //This disables button and textbox when submit button is clicked.
            txtBoxEntry.Enabled = false;
            btnSubmit.Enabled = false;

        //This checks that the users input matches up with these statements else the answer is wrong.
            if (txtBoxEntry.Text.Contains("Local Area Network"))
            {
                lblCorrectOrWrongEntry.Text = "The answer is correct";
            }

            else if (txtBoxEntry.Text.Contains("local area network"))
            {
                lblCorrectOrWrongEntry.Text = "The answer is correct";
            }
            else if (txtBoxEntry.Text.Contains("LAN"))
            {
                lblCorrectOrWrongEntry.Text = "The answer is correct";
            }

            else if (txtBoxEntry.Text.Contains("lan"))
            {
                lblCorrectOrWrongEntry.Text = "The answer is correct";
            }

            else
            {
                lblCorrectOrWrongEntry.Text = "The answer is wrong";
            }
        }

        private void lblCorrectOrWrongEntry_Click(object sender, EventArgs e)
        {

        }
    }
}
