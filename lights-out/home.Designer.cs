namespace lights_out
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18.2F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(69, 83);
            label1.Name = "label1";
            label1.Size = new Size(413, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Lights Game";
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 14F);
            button1.Location = new Point(168, 175);
            button1.Name = "button1";
            button1.Size = new Size(204, 56);
            button1.TabIndex = 1;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Showcard Gothic", 14F);
            button2.Location = new Point(168, 251);
            button2.Name = "button2";
            button2.Size = new Size(204, 56);
            button2.TabIndex = 1;
            button2.Text = "Description";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Showcard Gothic", 14F);
            button3.Location = new Point(168, 328);
            button3.Name = "button3";
            button3.Size = new Size(204, 56);
            button3.TabIndex = 1;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(560, 458);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
