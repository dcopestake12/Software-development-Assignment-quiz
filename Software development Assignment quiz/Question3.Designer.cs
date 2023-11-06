namespace Software_development_Assignment_quiz
{
    partial class Question3
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
            btnQuestion3 = new Button();
            btnOption1 = new Button();
            btnOption2 = new Button();
            btnOption3 = new Button();
            btnOption4 = new Button();
            lblCorrectOrWrong = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 60);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "What is a WAN?";
            // 
            // btnQuestion3
            // 
            btnQuestion3.Location = new Point(319, 364);
            btnQuestion3.Name = "btnQuestion3";
            btnQuestion3.Size = new Size(94, 50);
            btnQuestion3.TabIndex = 1;
            btnQuestion3.Text = "Next";
            btnQuestion3.UseVisualStyleBackColor = true;
            btnQuestion3.Click += btnQuestion3_Click;
            // 
            // btnOption1
            // 
            btnOption1.Location = new Point(134, 139);
            btnOption1.Name = "btnOption1";
            btnOption1.Size = new Size(219, 49);
            btnOption1.TabIndex = 2;
            btnOption1.Text = "Its a network that connects different networks that are within the same city.";
            btnOption1.UseVisualStyleBackColor = true;
            btnOption1.Click += btnOption1_Click;
            // 
            // btnOption2
            // 
            btnOption2.Location = new Point(475, 139);
            btnOption2.Name = "btnOption2";
            btnOption2.Size = new Size(244, 49);
            btnOption2.TabIndex = 3;
            btnOption2.Text = "It encodes data that is sent acrross the internet and hides the senders IP address.";
            btnOption2.UseVisualStyleBackColor = true;
            btnOption2.Click += btnOption2_Click;
            // 
            // btnOption3
            // 
            btnOption3.Location = new Point(134, 238);
            btnOption3.Name = "btnOption3";
            btnOption3.Size = new Size(219, 99);
            btnOption3.TabIndex = 4;
            btnOption3.Text = "This is a Wide Area Network that is in multiple locations and is made up of multiple LAN's  the internet is an example of a WAN ";
            btnOption3.UseVisualStyleBackColor = true;
            btnOption3.Click += btnOption3_Click;
            // 
            // btnOption4
            // 
            btnOption4.Location = new Point(475, 238);
            btnOption4.Name = "btnOption4";
            btnOption4.Size = new Size(244, 32);
            btnOption4.TabIndex = 5;
            btnOption4.Text = "It's a method to secure a network.";
            btnOption4.UseVisualStyleBackColor = true;
            btnOption4.Click += btnOption4_Click;
            // 
            // lblCorrectOrWrong
            // 
            lblCorrectOrWrong.AutoSize = true;
            lblCorrectOrWrong.Location = new Point(353, 450);
            lblCorrectOrWrong.Name = "lblCorrectOrWrong";
            lblCorrectOrWrong.Size = new Size(0, 15);
            lblCorrectOrWrong.TabIndex = 6;
            // 
            // Question3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 533);
            Controls.Add(lblCorrectOrWrong);
            Controls.Add(btnOption4);
            Controls.Add(btnOption3);
            Controls.Add(btnOption2);
            Controls.Add(btnOption1);
            Controls.Add(btnQuestion3);
            Controls.Add(label1);
            Name = "Question3";
            Text = "Question3";
            Load += Question3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnQuestion3;
        private Button btnOption1;
        private Button btnOption2;
        private Button btnOption3;
        private Button btnOption4;
        private Label lblCorrectOrWrong;
    }
}