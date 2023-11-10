using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harry_Potter_Game
{
    public class Player
    {
        public int myScore { get; set; }
        public int bestScore { get; set; }

        public Player()
        {
            this.myScore = 0;
            this.bestScore = 0;
        }

        public Player(int bestScore)
        {
            this.myScore = 0;
            this.bestScore = bestScore;
        }

        public Player(int myScore, int bestScore)
        {
            this.myScore = myScore;
            this.bestScore = bestScore;
        }
    }
}
