namespace Software_development_Assignment_quiz
{
    partial class Question4
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
            btnQuestion4 = new Button();
            btnOption2 = new Button();
            btnOption1 = new Button();
            btnOption3 = new Button();
            btnOption4 = new Button();
            lblCorrectOrWrong = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 82);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 0;
            label1.Text = "What is a draft in the milatry?";
            // 
            // btnQuestion4
            // 
            btnQuestion4.Location = new Point(313, 327);
            btnQuestion4.Name = "btnQuestion4";
            btnQuestion4.Size = new Size(98, 56);
            btnQuestion4.TabIndex = 1;
            btnQuestion4.Text = "Next";
            btnQuestion4.UseVisualStyleBackColor = true;
            btnQuestion4.Click += btnQuestion4_Click;
            // 
            // btnOption2
            // 
            btnOption2.Location = new Point(442, 156);
            btnOption2.Name = "btnOption2";
            btnOption2.Size = new Size(194, 61);
            btnOption2.TabIndex = 2;
            btnOption2.Text = "Where the military ask you to work a at a certain place such as a war zone.";
            btnOption2.UseVisualStyleBackColor = true;
            btnOption2.Click += btnOption2_Click;
            // 
            // btnOption1
            // 
            btnOption1.Location = new Point(218, 156);
            btnOption1.Name = "btnOption1";
            btnOption1.Size = new Size(161, 61);
            btnOption1.TabIndex = 3;
            btnOption1.Text = "Training that you must complete when nyou join the milatry.";
            btnOption1.UseVisualStyleBackColor = true;
            btnOption1.Click += btnOption1_Click;
            // 
            // btnOption3
            // 
            btnOption3.Location = new Point(218, 267);
            btnOption3.Name = "btnOption3";
            btnOption3.Size = new Size(172, 43);
            btnOption3.TabIndex = 4;
            btnOption3.Text = "There is no such thing as a draft.";
            btnOption3.UseVisualStyleBackColor = true;
            btnOption3.Click += btnOption3_Click;
            // 
            // btnOption4
            // 
            btnOption4.Location = new Point(442, 267);
            btnOption4.Name = "btnOption4";
            btnOption4.Size = new Size(194, 43);
            btnOption4.TabIndex = 5;
            btnOption4.Text = "When you forced to complete certain tasks.";
            btnOption4.UseVisualStyleBackColor = true;
            btnOption4.Click += btnOption4_Click;
            // 
            // lblCorrectOrWrong
            // 
            lblCorrectOrWrong.AutoSize = true;
            lblCorrectOrWrong.Location = new Point(341, 408);
            lblCorrectOrWrong.Name = "lblCorrectOrWrong";
            lblCorrectOrWrong.Size = new Size(0, 15);
            lblCorrectOrWrong.TabIndex = 6;
            // 
            // Question4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCorrectOrWrong);
            Controls.Add(btnOption4);
            Controls.Add(btnOption3);
            Controls.Add(btnOption1);
            Controls.Add(btnOption2);
            Controls.Add(btnQuestion4);
            Controls.Add(label1);
            Name = "Question4";
            Text = "Question4";
            Load += Question4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnQuestion4;
        private Button btnOption2;
        private Button btnOption1;
        private Button btnOption3;
        private Button btnOption4;
        private Label lblCorrectOrWrong;
    }
}