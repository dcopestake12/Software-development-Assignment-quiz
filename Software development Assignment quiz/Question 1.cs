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
    public partial class Question_1 : Form
    {
        public Question_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNextQ1_Click(object sender, EventArgs e)
        {
            Question2 Q2 = new Question2();
                Q2.Show();
        }
    }
}
