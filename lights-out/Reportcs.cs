using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;
using Game = lights_out.Models.Game;
namespace lights_out
{
    public partial class Reportcs : Form
    {
        Game game3;
        Game game4;
        Game game5;
      
        public Reportcs(Game game3, Game game4, Game game5)
        {
            this.game3 = game3;
            this.game4 = game4;
            this.game5 = game5;
            InitializeComponent();
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();   
        }

        private void Reportcs_Load(object sender, EventArgs e)
        {
            var game = getGameToShowStatus(3);
            showStatus(game);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var game = getGameToShowStatus(3);
            showStatus(game);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var game = getGameToShowStatus(4);
            showStatus(game);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           var game = getGameToShowStatus(5);
           showStatus(game);
        }
        private void ColorOfB(int x)
        {
            S1.BackColor = SystemColors.Control;
            S2.BackColor = SystemColors.Control;
            S3.BackColor = SystemColors.Control;

            Button? selectedButton = x switch
            {
                3 => S1,
                4 => S2,
                5 => S3,
                _ => null
            };
            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.LightGreen;
            }
        }
        private void showStatus(Game gameStatus)
        {
            ColorOfB(gameStatus.rowCount);
            GamesL.Text = gameStatus.playCount.ToString();
            WinsL.Text = gameStatus.winCount.ToString();
            LoseL.Text = gameStatus.GivUpCount.ToString();
            RecordL.Text = gameStatus.BestRecord.ToString();
        }
        private Game getGameToShowStatus(int gameSize)
        {
            var currentGame = gameSize;
            Game? activeGame = currentGame switch
            {
                3 => game3,
                4 => game4,
                5 => game5,
                _ => null
            };
            return activeGame ?? game3;
        }
    }
}
