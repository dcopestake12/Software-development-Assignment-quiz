using System.Runtime.CompilerServices;

namespace Software_development_Assignment_quiz
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Question1 Q1 = new Question1();
            Q1.Show();

        }

        private void Homepage_Load(object sender, EventArgs e)
        {
        }
    }
}