namespace Software_development_Assignment_quiz
{
    partial class Question_1
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
            btnNextQ1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 122);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Question 1";
            label1.Click += label1_Click;
            // 
            // btnNextQ1
            // 
            btnNextQ1.Location = new Point(312, 228);
            btnNextQ1.Name = "btnNextQ1";
            btnNextQ1.Size = new Size(141, 58);
            btnNextQ1.TabIndex = 1;
            btnNextQ1.Text = "Next Question";
            btnNextQ1.UseVisualStyleBackColor = true;
            btnNextQ1.Click += btnNextQ1_Click;
            // 
            // Question_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 523);
            Controls.Add(btnNextQ1);
            Controls.Add(label1);
            Name = "Question_1";
            Text = "Question_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNextQ1;
    }
}