namespace lights_out.Models
{
    public class Game : GameBase 
    {
        public int Move_count { get; set; }
        public int playCount { get; set; }
        public int winCount { get; set; }
        public int GivUpCount { get; set; }
        public int BestRecord { get; set; }
        public bool IsReplaying { get; set; } = false;

        private GameRecord currentGameRecord;
        public GameTrak gameTracker { get; set; } = new GameTrak();

        private IGameStateGenerator _gameStateGenerator;
        public Game()
        {
            currentGameRecord = new GameRecord();
            _gameStateGenerator = new GameStateGenerator();
        }
        public Game(TableLayoutPanel board, Label countLabel, Label bestLabel, Button giveUpBtn, Button replayBtn,int size)
        : base(board, countLabel, bestLabel, giveUpBtn, replayBtn, size)
        {
            currentGameRecord = new GameRecord();
            _gameStateGenerator = new GameStateGenerator();
        }

        public void clear_bord()
        {           
            board.Controls.Clear();
            board.ColumnStyles.Clear();
            board.RowStyles.Clear();
            board.RowCount = rowCount;
            board.ColumnCount = columnCount;

            for (int i = 0; i < columnCount; i++)
            {
                board.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnCount));
            }

            for (int i = 0; i < rowCount; i++)
            {
                board.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rowCount));
            }
        }

        public void InitializeBord()
        {
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    Button btn = new Button
                    {
                        Dock = DockStyle.Fill,
                        ImageAlign = ContentAlignment.MiddleCenter
                    };
                    Image originalImage = Image.FromFile("C:\\Users\\acer\\source\\repos\\lights-out\\lights-out\\assits\\bulb.png");
                    Image resizedImage = new Bitmap(originalImage, new Size(70, 70));
                    btn.Image = resizedImage;
                    btn.Click += Button_Click;
                    board.Controls.Add(btn, col, row);
                }
            }
        }

        public void Start_Game()
        {
            clear_bord();
            GameIsStarted = true;
            Move_count = 0;
            countMoveLable.Text = "0";

            InitializeBord();

            currentGameRecord = new GameRecord
            {
                DatePlayed = DateTime.Now,
                GridSize = rowCount,
                Moves = new List<Move>()
            };

            ColorRandomizeButtons();
        }

        public void ColorRandomizeButtons()
        {
            currentGameRecord.InitialState = new List<bool>();
            List<Button> buttons = board.Controls.OfType<Button>().ToList();

            // Use the injected generator to create a solvable state
            _gameStateGenerator.GenerateSolvableState(buttons, rowCount, columnCount, ref currentGameRecord);
        }
        public void ChangeStateOfBtn(bool state)
        {
            GiveUpButton.Enabled = !state;
            ReplayButton.Enabled = !state;
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            if (!GameIsStarted || IsReplaying) return;

            Button clickedButton = (sender as Button)!;
            int row = board.GetRow(clickedButton);
            int col = board.GetColumn(clickedButton);

            currentGameRecord.Moves.Add(new Move { Row = row, Column = col });

            Move_count++;
            countMoveLable.Text = Move_count.ToString();

            ToggleButton(clickedButton);
            ToggleAdjacentButtons(clickedButton);

            if (CheckIfAllButtonsAreOff())
            {
                Win_Stat();
            }
        }

        public void ToggleAdjacentButtons(Button clickedButton)
        {
            int col = board.GetColumn(clickedButton);
            int row = board.GetRow(clickedButton);

            ToggleButtonAtPosition(col, row - 1);
            ToggleButtonAtPosition(col, row + 1);
            ToggleButtonAtPosition(col - 1, row);
            ToggleButtonAtPosition(col + 1, row);
        }

        public void ToggleButtonAtPosition(int col, int row)
        {
            if (col >= 0 && col < board.ColumnCount && row >= 0 && row < board.RowCount)
            {
                Button? button = board.GetControlFromPosition(col, row) as Button;
                if (button != null)
                {
                    ToggleButton(button);
                }
            }
        }

        public void ToggleButton(Button button)
        {
            if (button.BackColor == Color.LightGreen)
            {
                button.BackColor = SystemColors.Control;
                button.ForeColor = Color.Gray;
            }
            else
            {
                button.BackColor = Color.LightGreen;
                button.ForeColor = Color.Black;
            }
        }

        public override bool CheckIfAllButtonsAreOff()
        {
            foreach (Control control in board.Controls)
            {
                if (control is Button button && button.BackColor == Color.LightGreen)
                    return false;
            }
            return true;
        }

        public void Win_Stat()
        {
            MessageBox.Show($"You Win By {Move_count} Moves", "Great", MessageBoxButtons.OK);
            winCount++;
            Dsabel_button();
            GameIsStarted = false;
            Best_Record();
            currentGameRecord.IsWin = true;
            gameTracker.AddRecord(currentGameRecord);
        }

        public override void GiveUp()
        {
            GivUpCount++;
            GameIsStarted = false;
            Dsabel_button();

            currentGameRecord.IsWin = false;
            gameTracker.AddRecord(currentGameRecord);

            MessageBox.Show("You gave up!", "Info", MessageBoxButtons.OK);
        }

        public async Task ReplayGame(GameRecord record)
        {
            IsReplaying = true;
            ChangeStateOfBtn(true);
            clear_bord();
            InitializeBord();
            GameIsStarted = false;

            //Initial
            if (record.InitialState != null && record.InitialState.Count == board.Controls.Count)
            {
                for (int i = 0; i < board.Controls.Count; i++)
                {
                    if (board.Controls[i] is Button button)
                    {
                        bool isOn = record.InitialState[i];
                        button.BackColor = isOn ? Color.LightGreen : SystemColors.Control;
                        button.ForeColor = isOn ? Color.Black : Color.Gray;
                        button.FlatAppearance.BorderSize = 0;
                    }
                }
            }

            await Task.Delay(500);

            foreach (var move in record.Moves)
            {
                foreach (Control control in board.Controls)
                {
                    if (control is Button b)
                        b.FlatAppearance.BorderSize = 0;
                }

                var button = board.GetControlFromPosition(move.Column, move.Row) as Button;
                if (button != null)
                {
                    ToggleButton(button);
                    ToggleAdjacentButtons(button);
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderColor = Color.Yellow;
                    button.FlatAppearance.BorderSize = 6;
                    button.Refresh();
                    await Task.Delay(1200);
                }
            }

            ChangeStateOfBtn(false);
            MessageBox.Show(record.IsWin ? "this Game End with Win" : "this Game End with Lose", "Note", MessageBoxButtons.OK);
            IsReplaying = false;
        } 

        public void Dsabel_button()
        {
            foreach (Control control in board.Controls)
            {
                if (control is Button btn)
                {
                    btn.Click -= Button_Click;
                }
            }
        }

        public void ResetGame()
        {
            playCount++;
            Start_Game();
        }

        public void Best_Record()
        {
            if (BestRecord == 0 || BestRecord > Move_count)
            {
                BestRecord = Move_count;
                bestRecordLable.Text = BestRecord.ToString();
            }
        }

        public override void Game_stat()
        {
            if (GameIsStarted)
            {
                MessageBox.Show("Complete the Game OR Give Up", "Please", MessageBoxButtons.OK);
            }
            else
            {
                ResetGame();
            }
        }
    }
}
