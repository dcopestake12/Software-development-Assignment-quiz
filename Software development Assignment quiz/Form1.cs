using System.Runtime.CompilerServices;

namespace Software_development_Assignment_quiz
{
    public partial class Homepage : Form
    {
       public static class score
        {
            public static int currentScore { get; set; }
        }
        public Homepage()
        {
            InitializeComponent();
             
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //This hides the homepage
            this.Hide();
            //Thes allows question 1 to be shown
            Question1 Q1 = new Question1();
            Q1.Show();

        }

        private void Homepage_Load(object sender, EventArgs e)
        {
        }
    }
}