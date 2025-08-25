using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lights_out.Models;

namespace lights_out
{
    public partial class GameHistoryForm : Form
    {
        private readonly GameTrak gameTracker;
        private readonly Game game;
        public GameHistoryForm(GameTrak tracker, Game gameInstance)
        {
            InitializeComponent();
            gameTracker = tracker;
            game = gameInstance;
            LoadHistory();
        }

        private void LoadHistory()
        {
            var records = gameTracker.GetAllRecords();
            int row = 0;

            foreach (var record in records)
            {
                var label = new Label
                {
                    Text = record.ToString(),
                    AutoSize = true,
                    Margin = new Padding(5)
                };

                var replayButton = new Button
                {
                    Text = "Replay",
                    Tag = record,
                    AutoSize = true
                };
                replayButton.Click += ReplayButton_Click!;

                var panel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Top,
                    AutoSize = true
                };
                panel.Controls.Add(label);
                panel.Controls.Add(replayButton);

                flowLayoutPanel1.Controls.Add(panel);
                row++;
            }
        }

        private async void ReplayButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is GameRecord record)
            {
                this.Close(); 
                if(game.columnCount != record.GridSize)
                {
                    MessageBox.Show("you are not in the corect board","hi");
                }
                else{
                    await game.ReplayGame(record);
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
