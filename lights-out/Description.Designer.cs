namespace lights_out
{
    partial class Description
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Description));
            GoBackBtn = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // GoBackBtn
            // 
            GoBackBtn.Font = new Font("Showcard Gothic", 16.2F);
            GoBackBtn.Location = new Point(267, 440);
            GoBackBtn.Name = "GoBackBtn";
            GoBackBtn.Size = new Size(112, 45);
            GoBackBtn.TabIndex = 0;
            GoBackBtn.Text = "Home";
            GoBackBtn.UseVisualStyleBackColor = true;
            GoBackBtn.Click += GoBackBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.Location = new Point(88, 50);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.RightToLeft = RightToLeft.Yes;
            richTextBox1.Size = new Size(475, 384);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Description
            // 
            ClientSize = new Size(656, 526);
            Controls.Add(richTextBox1);
            Controls.Add(GoBackBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Description";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Button GoBackBtn;
        private RichTextBox richTextBox1;
    }
}