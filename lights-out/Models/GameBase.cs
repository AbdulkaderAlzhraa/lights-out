using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lights_out.Models
{
    public abstract class GameBase
    {
        public TableLayoutPanel board { get; set; } = null!;
        public Label countMoveLable { get; set; } = null!;
        public Label bestRecordLable { get; set; } = null!;
        public Button GiveUpButton { get; set; } = null!;
        public Button ReplayButton { get; set; } = null!;
        public int rowCount { get; set; }
        public int columnCount { get; set; }
        public bool GameIsStarted { get; set; }
        protected GameBase()
        {
            
        }
        public GameBase(TableLayoutPanel board, Label countLabel, Label bestLabel, Button giveUpBtn, Button replayBtn, int size)
        {
            this.board = board;
            this.countMoveLable = countLabel;
            this.bestRecordLable = bestLabel;
            this.GiveUpButton = giveUpBtn;
            this.ReplayButton = replayBtn;
            this.rowCount = size;
            this.columnCount = size;
           
        }
        public abstract void Game_stat();
        public abstract void GiveUp();
        public abstract bool CheckIfAllButtonsAreOff();
    }
}
