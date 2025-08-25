namespace lights_out
{
    partial class Reportcs
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
            WinsLT = new Label();
            LoseLT = new Label();
            RecordLT = new Label();
            button1 = new Button();
            GamesL = new Label();
            WinsL = new Label();
            LoseL = new Label();
            RecordL = new Label();
            S1 = new Button();
            S2 = new Button();
            S3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12.2F);
            label1.Location = new Point(134, 136);
            label1.Name = "label1";
            label1.Size = new Size(92, 27);
            label1.TabIndex = 0;
            label1.Text = "Games :";
            // 
            // WinsLT
            // 
            WinsLT.AutoSize = true;
            WinsLT.Font = new Font("Showcard Gothic", 12.2F);
            WinsLT.Location = new Point(134, 182);
            WinsLT.Name = "WinsLT";
            WinsLT.Size = new Size(81, 27);
            WinsLT.TabIndex = 0;
            WinsLT.Text = "Wins : ";
            // 
            // LoseLT
            // 
            LoseLT.AutoSize = true;
            LoseLT.Font = new Font("Showcard Gothic", 12.2F);
            LoseLT.Location = new Point(134, 223);
            LoseLT.Name = "LoseLT";
            LoseLT.Size = new Size(72, 27);
            LoseLT.TabIndex = 0;
            LoseLT.Text = "Lose :";
            // 
            // RecordLT
            // 
            RecordLT.AutoSize = true;
            RecordLT.Font = new Font("Showcard Gothic", 12.2F);
            RecordLT.Location = new Point(134, 262);
            RecordLT.Name = "RecordLT";
            RecordLT.Size = new Size(77, 27);
            RecordLT.TabIndex = 0;
            RecordLT.Text = "Best : ";
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 12.2F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(147, 335);
            button1.Name = "button1";
            button1.Size = new Size(107, 42);
            button1.TabIndex = 1;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GamesL
            // 
            GamesL.AutoSize = true;
            GamesL.Font = new Font("Showcard Gothic", 16.2F);
            GamesL.Location = new Point(244, 130);
            GamesL.Name = "GamesL";
            GamesL.Size = new Size(32, 35);
            GamesL.TabIndex = 0;
            GamesL.Text = "0";
            // 
            // WinsL
            // 
            WinsL.AutoSize = true;
            WinsL.Font = new Font("Showcard Gothic", 16.2F);
            WinsL.Location = new Point(243, 177);
            WinsL.Name = "WinsL";
            WinsL.Size = new Size(32, 35);
            WinsL.TabIndex = 0;
            WinsL.Text = "0";
            // 
            // LoseL
            // 
            LoseL.AutoSize = true;
            LoseL.Font = new Font("Showcard Gothic", 16.2F);
            LoseL.Location = new Point(242, 217);
            LoseL.Name = "LoseL";
            LoseL.Size = new Size(32, 35);
            LoseL.TabIndex = 0;
            LoseL.Text = "0";
            // 
            // RecordL
            // 
            RecordL.AutoSize = true;
            RecordL.Font = new Font("Showcard Gothic", 16.2F);
            RecordL.Location = new Point(244, 262);
            RecordL.Name = "RecordL";
            RecordL.Size = new Size(32, 35);
            RecordL.TabIndex = 0;
            RecordL.Text = "0";
            RecordL.Click += label8_Click;
            // 
            // S1
            // 
            S1.Font = new Font("Showcard Gothic", 12.2F);
            S1.ForeColor = SystemColors.ActiveCaptionText;
            S1.Location = new Point(29, 55);
            S1.Name = "S1";
            S1.Size = new Size(107, 42);
            S1.TabIndex = 1;
            S1.Text = "S 3";
            S1.UseVisualStyleBackColor = true;
            S1.Click += button3_Click;
            // 
            // S2
            // 
            S2.Font = new Font("Showcard Gothic", 12.2F);
            S2.ForeColor = SystemColors.ActiveCaptionText;
            S2.Location = new Point(159, 55);
            S2.Name = "S2";
            S2.Size = new Size(107, 42);
            S2.TabIndex = 1;
            S2.Text = "S 4";
            S2.UseVisualStyleBackColor = true;
            S2.Click += button4_Click;
            // 
            // S3
            // 
            S3.Font = new Font("Showcard Gothic", 12.2F);
            S3.ForeColor = SystemColors.ActiveCaptionText;
            S3.Location = new Point(294, 55);
            S3.Name = "S3";
            S3.Size = new Size(107, 42);
            S3.TabIndex = 1;
            S3.Text = "S 5";
            S3.UseVisualStyleBackColor = true;
            S3.Click += button5_Click;
            // 
            // Reportcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(430, 416);
            Controls.Add(S3);
            Controls.Add(S2);
            Controls.Add(S1);
            Controls.Add(button1);
            Controls.Add(RecordL);
            Controls.Add(RecordLT);
            Controls.Add(LoseL);
            Controls.Add(LoseLT);
            Controls.Add(WinsL);
            Controls.Add(WinsLT);
            Controls.Add(GamesL);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reportcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportcs";
            Load += Reportcs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label WinsLT;
        private Label LoseLT;
        private Label RecordLT;
        private Button button1;
        private Label GamesL;
        private Label WinsL;
        private Label LoseL;
        private Label RecordL;
        private Button S1;
        private Button S2;
        private Button S3;
    }
}