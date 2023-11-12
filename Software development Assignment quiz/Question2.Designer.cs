namespace Software_development_Assignment_quiz
{
    partial class Question2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQuestion = new Label();
            txtBoxEntry = new TextBox();
            btnSubmit = new Button();
            btnNext = new Button();
            lblCorrectOrWrong = new Label();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(289, 111);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(218, 15);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Who is the current minister of deffence?";
            // 
            // txtBoxEntry
            // 
            txtBoxEntry.Location = new Point(289, 172);
            txtBoxEntry.Name = "txtBoxEntry";
            txtBoxEntry.Size = new Size(218, 23);
            txtBoxEntry.TabIndex = 1;
            txtBoxEntry.TextChanged += txtBoxEntry_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(565, 171);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(80, 32);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(332, 242);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 38);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblCorrectOrWrong
            // 
            lblCorrectOrWrong.AutoSize = true;
            lblCorrectOrWrong.Location = new Point(349, 339);
            lblCorrectOrWrong.Name = "lblCorrectOrWrong";
            lblCorrectOrWrong.Size = new Size(0, 15);
            lblCorrectOrWrong.TabIndex = 4;
            // 
            // Question2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCorrectOrWrong);
            Controls.Add(btnNext);
            Controls.Add(btnSubmit);
            Controls.Add(txtBoxEntry);
            Controls.Add(lblQuestion);
            Name = "Question2";
            Text = "Question2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private TextBox txtBoxEntry;
        private Button btnSubmit;
        private Button btnNext;
        private Label lblCorrectOrWrong;
    }
}