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
            txtBoxEntry = new TextBox();
            lblCorrectOrWrongEntry = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // btnQuestion2
            // 
            btnQuestion2.Location = new Point(275, 291);
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
            label1.Location = new Point(187, 105);
            label1.Name = "label1";
            Size size = new Size(173, 15);
            label1.Size = size;
            label1.TabIndex = 1;
            label1.Text = "Who is the minister of defence?";
            label1.Click += label1_Click;
            // 
            // txtBoxEntry
            // 
            txtBoxEntry.Location = new Point(205, 169);
            txtBoxEntry.Name = "txtBoxEntry";
            txtBoxEntry.Size = new Size(303, 23);
            txtBoxEntry.TabIndex = 2;
            txtBoxEntry.TextChanged += txtBoxEntry_TextChanged;
            // 
            // lblCorrectOrWrongEntry
            // 
            lblCorrectOrWrongEntry.AutoSize = true;
            lblCorrectOrWrongEntry.Location = new Point(318, 377);
            lblCorrectOrWrongEntry.Name = "lblCorrectOrWrongEntry";
            lblCorrectOrWrongEntry.Size = new Size(0, 15);
            lblCorrectOrWrongEntry.TabIndex = 3;
            lblCorrectOrWrongEntry.Click += lblCorrectOrWrongEntry_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(548, 169);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Question2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(lblCorrectOrWrongEntry);
            Controls.Add(txtBoxEntry);
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
        private TextBox txtBoxEntry;
        private Label lblCorrectOrWrongEntry;
        private Button btnSubmit;
    }
}