namespace lights_out
{
    partial class GameBoard
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
            moveL = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ThreeBtn = new Button();
            FourBtn = new Button();
            FiveBtn = new Button();
            HomeBtn = new Button();
            ExitAppBtn = new Button();
            GivUpBtn = new Button();
            StartBtn = new Button();
            label3 = new Label();
            ShowStatusBtn = new Button();
            ReblayBtn = new Button();
            pestL = new Label();
            SuspendLayout();
            // 
            // moveL
            // 
            moveL.AutoSize = true;
            moveL.Font = new Font("Showcard Gothic", 16.2F);
            moveL.ForeColor = SystemColors.ButtonHighlight;
            moveL.Location = new Point(166, 65);
            moveL.Name = "moveL";
            moveL.Size = new Size(32, 35);
            moveL.TabIndex = 6;
            moveL.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12.2F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(151, 27);
            label1.TabIndex = 5;
            label1.Text = "Move Count:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Location = new Point(141, 122);
            tableLayoutPanel1.MaximumSize = new Size(320, 320);
            tableLayoutPanel1.MinimumSize = new Size(450, 450);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(450, 450);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Showcard Gothic", 13.2F);
            ThreeBtn.Location = new Point(440, 65);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(94, 37);
            ThreeBtn.TabIndex = 8;
            ThreeBtn.Text = "3X3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Showcard Gothic", 13.2F);
            FourBtn.Location = new Point(540, 65);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(94, 37);
            FourBtn.TabIndex = 8;
            FourBtn.Text = "4X4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Showcard Gothic", 13.2F);
            FiveBtn.Location = new Point(640, 65);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(94, 37);
            FiveBtn.TabIndex = 8;
            FiveBtn.Text = "5X5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.Font = new Font("Showcard Gothic", 9.2F);
            HomeBtn.Location = new Point(12, 11);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(94, 29);
            HomeBtn.TabIndex = 9;
            HomeBtn.Text = "GO Back";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // ExitAppBtn
            // 
            ExitAppBtn.Font = new Font("Showcard Gothic", 9.2F);
            ExitAppBtn.Location = new Point(112, 11);
            ExitAppBtn.Name = "ExitAppBtn";
            ExitAppBtn.Size = new Size(132, 29);
            ExitAppBtn.TabIndex = 10;
            ExitAppBtn.Text = "Exit The App";
            ExitAppBtn.UseVisualStyleBackColor = true;
            ExitAppBtn.Click += ExitAppBtn_Click;
            // 
            // GivUpBtn
            // 
            GivUpBtn.BackColor = Color.DeepPink;
            GivUpBtn.Font = new Font("Showcard Gothic", 16.2F);
            GivUpBtn.ForeColor = SystemColors.ButtonHighlight;
            GivUpBtn.Location = new Point(400, 616);
            GivUpBtn.Name = "GivUpBtn";
            GivUpBtn.Size = new Size(156, 57);
            GivUpBtn.TabIndex = 11;
            GivUpBtn.Text = "GivUP";
            GivUpBtn.UseVisualStyleBackColor = false;
            GivUpBtn.Click += GivUpBtn_Click;
            // 
            // StartBtn
            // 
            StartBtn.Font = new Font("Showcard Gothic", 16.2F);
            StartBtn.Location = new Point(185, 616);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(192, 57);
            StartBtn.TabIndex = 12;
            StartBtn.Text = "Start Game";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12.2F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(205, 69);
            label3.Name = "label3";
            label3.Size = new Size(159, 27);
            label3.TabIndex = 13;
            label3.Text = "Best Record :";
            // 
            // ShowStatusBtn
            // 
            ShowStatusBtn.Font = new Font("Showcard Gothic", 13.2F);
            ShowStatusBtn.Location = new Point(527, 8);
            ShowStatusBtn.Name = "ShowStatusBtn";
            ShowStatusBtn.Size = new Size(207, 37);
            ShowStatusBtn.TabIndex = 15;
            ShowStatusBtn.Text = "show Status";
            ShowStatusBtn.UseVisualStyleBackColor = true;
            ShowStatusBtn.Click += ShowStatusBtn_Click;
            // 
            // ReblayBtn
            // 
            ReblayBtn.Font = new Font("Showcard Gothic", 13.2F);
            ReblayBtn.Location = new Point(400, 8);
            ReblayBtn.Name = "ReblayBtn";
            ReblayBtn.Size = new Size(126, 37);
            ReblayBtn.TabIndex = 16;
            ReblayBtn.Text = "Replay History";
            ReblayBtn.UseVisualStyleBackColor = true;
            ReblayBtn.Click += ReblayBtn_Click;
            // 
            // pestL
            // 
            pestL.AutoSize = true;
            pestL.Font = new Font("Showcard Gothic", 16.2F);
            pestL.ForeColor = SystemColors.ButtonHighlight;
            pestL.Location = new Point(367, 64);
            pestL.Name = "pestL";
            pestL.Size = new Size(32, 35);
            pestL.TabIndex = 14;
            pestL.Text = "0";
            // 
            // GameBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.Salmon;
            ClientSize = new Size(746, 722);
            Controls.Add(ReblayBtn);
            Controls.Add(ShowStatusBtn);
            Controls.Add(pestL);
            Controls.Add(label3);
            Controls.Add(StartBtn);
            Controls.Add(GivUpBtn);
            Controls.Add(ExitAppBtn);
            Controls.Add(HomeBtn);
            Controls.Add(FiveBtn);
            Controls.Add(FourBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(moveL);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GameBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "game_3x3";
            Load += game_3x3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label moveL;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ThreeBtn;
        private Button FourBtn;
        private Button FiveBtn;
        private Button HomeBtn;
        private Button ExitAppBtn;
        private Button GivUpBtn;
        private Button StartBtn;
        private Label label3;
        private Button ShowStatusBtn;
        private Button ReblayBtn;
        private Label pestL;
    }
}