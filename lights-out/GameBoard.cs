using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lights_out.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;
using Button = System.Windows.Forms.Button;

namespace lights_out
{
    public partial class GameBoard : Form
    {

        Game game3x3;
        Game game4x4;
        Game game5x5;

        public GameBoard()
        {
            this.game3x3 = new Game();
            this.game4x4 = new Game();
            this.game5x5 = new Game();
            InitializeComponent();
        }
        private void game_3x3_Load(object sender, EventArgs e)
        {
            game3x3 = new Game(tableLayoutPanel1, moveL, pestL, GivUpBtn, ReblayBtn, 3);
            game4x4 = new Game(tableLayoutPanel1, moveL, pestL, GivUpBtn, ReblayBtn, 4);
            game5x5 = new Game(tableLayoutPanel1, moveL, pestL, GivUpBtn, ReblayBtn, 5);
        }
        //

        private void HandleSwitchGame(int targetSize, Game otherGame1, Game otherGame2)
        {
            int currentSize = tableLayoutPanel1.RowCount;

            if (currentSize == targetSize)
            {
                HandleGameSwitch(targetSize);
                return;
            }

            if (!otherGame1.GameIsStarted && !otherGame2.GameIsStarted)
            {
                HandleGameSwitch(targetSize);
            }
            else
            {
                MessageBox.Show("Complete this Game or Give Up", "Please");
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            HandleSwitchGame(3, game4x4, game5x5);
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            HandleSwitchGame(4, game3x3, game5x5);
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            HandleSwitchGame(5, game3x3, game4x4);
        }
        //
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Close();
        }
        //
        private void ExitAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
  
        //زر الاستسلام
        private void GivUpBtn_Click(object sender, EventArgs e)
        {
            int currentGameSize = tableLayoutPanel1.RowCount;

            Game? activeGame = currentGameSize switch
            {
                3 => game3x3,
                4 => game4x4,
                5 => game5x5,
                _ => null
            };

            if (activeGame != null && !activeGame.CheckIfAllButtonsAreOff())
            {
                activeGame.GiveUp();
            }
            else
            {
                MessageBox.Show("You Are Not Able To Give Up", "Notice", MessageBoxButtons.OK);
            }

        }
        private void ColorOfB(int x)
        {
            ThreeBtn.BackColor = SystemColors.Control;
            FourBtn.BackColor = SystemColors.Control;
            FiveBtn.BackColor = SystemColors.Control;

            Button? selectedButton = x switch
            {
                3 => ThreeBtn,
                4 => FourBtn,
                5 => FiveBtn,
                _ => null
            };
            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.LightGreen;
            }
        }

        // تحديد المستوى المراد لعبه
        private void HandleGameSwitch(int x)
        {
            Game? selectedGame = x switch
            {
                3 => game3x3,
                4 => game4x4,
                5 => game5x5,
                _ => null
            };

            if (selectedGame != null)
            {
                selectedGame.Game_stat();
                ColorOfB(x);
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            int currentColumns = tableLayoutPanel1.ColumnCount;

            int gridSize = currentColumns switch
            {
                3 => 3,
                4 => 4,
                5 => 5,
                _ => 3 // القيمة الافتراضية
            };

            HandleGameSwitch(gridSize);
        }
        // بعت النتائج لواجهة الاحصائيات
        private void ShowStatusBtn_Click(object sender, EventArgs e)
        {
            Reportcs rep = new Reportcs(game3x3, game4x4, game5x5);
            rep.Show();
        }

        private void ReblayBtn_Click(object sender, EventArgs e)
        {
            Game currentGame;

            int gridSize = tableLayoutPanel1.RowCount;

            if (gridSize == 3)
                currentGame = game3x3;
            else if (gridSize == 4)
                currentGame = game4x4;
            else
                currentGame = game5x5;

            GameHistoryForm historyForm = new GameHistoryForm(currentGame.gameTracker, currentGame);
            historyForm.Show();

        }

        private void btnSuggestMove_Click(object sender, EventArgs e)
        {
            
        }
    }
}
