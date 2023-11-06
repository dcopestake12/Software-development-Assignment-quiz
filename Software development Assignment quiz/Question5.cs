using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Exit();
        }

        private void Question5_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtBoxEntry.Enabled = false;
            btnSubmit.Enabled = false;

            if (txtBoxEntry.Text.Contains("FIREWALL"))
            {
                lblCorrectOrWrongEntry.Text = "The answer is correct";
            }


            if (txtBoxEntry.Text.Contains("Firewall"))
            {
                lblCorrectOrWrongEntry.Text = "The answer is correct";
            }


            if (txtBoxEntry.Text.Contains("firewall"))
            {
                lblCorrectOrWrongEntry.Text = "The answer is correct";
            }

            else
            {
                lblCorrectOrWrongEntry.Text = "The answer is wrong";
            }
        }
    }
}

