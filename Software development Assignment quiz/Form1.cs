using System.Runtime.CompilerServices;

namespace Software_development_Assignment_quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            Question_1 Q1 = new Question_1();
                Q1.Show();
            
        }
    }
}