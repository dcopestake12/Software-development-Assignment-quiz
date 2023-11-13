namespace Software_development_Assignment_quiz
{
    partial class Question1
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
            btnOption1 = new Button();
            btnOption2 = new Button();
            btnOption3 = new Button();
            btnOption4 = new Button();
            lblQuestion = new Label();
            btnQuestion1 = new Button();
            lblCorrectOrWrong = new Label();
            SuspendLayout();
            // 
            // btnOption1
            // 
            btnOption1.Location = new Point(179, 159);
            btnOption1.Name = "btnOption1";
            btnOption1.Size = new Size(164, 89);
            btnOption1.TabIndex = 0;
            btnOption1.Text = "1707";
            btnOption1.UseVisualStyleBackColor = true;
            btnOption1.Click += btnOption1_Click;
            // 
            // btnOption2
            // 
            btnOption2.Location = new Point(179, 284);
            btnOption2.Name = "btnOption2";
            btnOption2.Size = new Size(164, 57);
            btnOption2.TabIndex = 1;
            btnOption2.Text = "1950";
            btnOption2.UseVisualStyleBackColor = true;
            btnOption2.Click += btnOption2_Click;
            // 
            // btnOption3
            // 
            btnOption3.Location = new Point(467, 159);
            btnOption3.Name = "btnOption3";
            btnOption3.Size = new Size(238, 53);
            btnOption3.TabIndex = 2;
            btnOption3.Text = "1521";
            btnOption3.UseVisualStyleBackColor = true;
            btnOption3.Click += btnOption3_Click;
            // 
            // btnOption4
            // 
            btnOption4.Location = new Point(467, 284);
            btnOption4.Name = "btnOption4";
            btnOption4.Size = new Size(238, 57);
            btnOption4.TabIndex = 3;
            btnOption4.Text = "1840";
            btnOption4.UseVisualStyleBackColor = true;
            btnOption4.Click += btnOption4_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(267, 109);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(328, 15);
            lblQuestion.TabIndex = 4;
            lblQuestion.Text = "Select the option for which year the british army was formed.";
            lblQuestion.Click += label1_Click;
            // 
            // btnQuestion1
            // 
            btnQuestion1.Location = new Point(295, 404);
            btnQuestion1.Name = "btnQuestion1";
            btnQuestion1.Size = new Size(121, 51);
            btnQuestion1.TabIndex = 5;
            btnQuestion1.Text = "Next Question";
            btnQuestion1.UseVisualStyleBackColor = true;
            btnQuestion1.Click += btnQuestion1_Click;
            // 
            // lblCorrectOrWrong
            // 
            lblCorrectOrWrong.AutoSize = true;
            lblCorrectOrWrong.Location = new Point(332, 480);
            lblCorrectOrWrong.Name = "lblCorrectOrWrong";
            lblCorrectOrWrong.Size = new Size(0, 15);
            lblCorrectOrWrong.TabIndex = 6;
            // 
            // Question1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(lblCorrectOrWrong);
            Controls.Add(btnQuestion1);
            Controls.Add(lblQuestion);
            Controls.Add(btnOption4);
            Controls.Add(btnOption3);
            Controls.Add(btnOption2);
            Controls.Add(btnOption1);
            Name = "Question1";
            Text = "What is a router?";
            Load += Question1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOption1;
        private Button btnOption2;
        private Button btnOption3;
        private Button btnOption4;
        private Label lblQuestion;
        private Button btnQuestion1;
        private Label lblCorrectOrWrong;
    }
}