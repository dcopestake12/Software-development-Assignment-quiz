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
            btnQuestion2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnQuestion2
            // 
            btnQuestion2.Location = new Point(284, 236);
            btnQuestion2.Name = "btnQuestion2";
            btnQuestion2.Size = new Size(122, 58);
            btnQuestion2.TabIndex = 0;
            btnQuestion2.Text = "Next Question";
            btnQuestion2.UseVisualStyleBackColor = true;
            btnQuestion2.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 104);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Question 2";
            // 
            // Question2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnQuestion2);
            Name = "Question2";
            Text = "Question2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuestion2;
        private Label label1;
    }
}