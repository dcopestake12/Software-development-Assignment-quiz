namespace Software_development_Assignment_quiz
{
    partial class Question5
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
            label1 = new Label();
            btnQuestion5 = new Button();
            txtBoxEntry = new TextBox();
            btnSubmit = new Button();
            lblCorrectOrWrongEntry = new Label();
            lblQuestion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 93);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // btnQuestion5
            // 
            btnQuestion5.Location = new Point(305, 279);
            btnQuestion5.Name = "btnQuestion5";
            btnQuestion5.Size = new Size(117, 66);
            btnQuestion5.TabIndex = 1;
            btnQuestion5.Text = "Finish Quiz";
            btnQuestion5.UseVisualStyleBackColor = true;
            btnQuestion5.Click += btnQuestion5_Click;
            // 
            // txtBoxEntry
            // 
            txtBoxEntry.Location = new Point(227, 174);
            txtBoxEntry.Name = "txtBoxEntry";
            txtBoxEntry.Size = new Size(249, 23);
            txtBoxEntry.TabIndex = 2;
            txtBoxEntry.TextChanged += txtBoxEntry_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(504, 173);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblCorrectOrWrongEntry
            // 
            lblCorrectOrWrongEntry.AutoSize = true;
            lblCorrectOrWrongEntry.Location = new Point(329, 399);
            lblCorrectOrWrongEntry.Name = "lblCorrectOrWrongEntry";
            lblCorrectOrWrongEntry.Size = new Size(0, 15);
            lblCorrectOrWrongEntry.TabIndex = 4;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(212, 112);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(358, 15);
            lblQuestion.TabIndex = 5;
            lblQuestion.Text = "What is the name of the milatry base located in Devon near Exeter?";
            // 
            // Question5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblQuestion);
            Controls.Add(lblCorrectOrWrongEntry);
            Controls.Add(btnSubmit);
            Controls.Add(txtBoxEntry);
            Controls.Add(btnQuestion5);
            Controls.Add(label1);
            Name = "Question5";
            Text = "Question5";
            Load += Question5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnQuestion5;
        private TextBox txtBoxEntry;
        private Button btnSubmit;
        private Label lblCorrectOrWrongEntry;
        private Label lblQuestion;
    }
}