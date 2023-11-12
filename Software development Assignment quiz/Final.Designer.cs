namespace Software_development_Assignment_quiz
{
    partial class Final
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
            btnClose = new Button();
            lblScore = new Label();
            LblRetake = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(288, 271);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 83);
            btnClose.TabIndex = 0;
            btnClose.Text = "End Quiz";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(288, 117);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(0, 15);
            lblScore.TabIndex = 1;
            lblScore.Click += label1_Click;
            // 
            // LblRetake
            // 
            LblRetake.AutoSize = true;
            LblRetake.Location = new Point(288, 161);
            LblRetake.Name = "LblRetake";
            LblRetake.Size = new Size(0, 15);
            LblRetake.TabIndex = 2;
            // 
            // Final
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblRetake);
            Controls.Add(lblScore);
            Controls.Add(btnClose);
            Name = "Final";
            Text = "Final";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label lblScore;
        private Label LblRetake;
    }
}