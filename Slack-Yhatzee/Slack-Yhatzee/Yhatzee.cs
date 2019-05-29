using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slack_Yhatzee
{
    class Yhatzee
    {
        //Game order:
        //pregame - Nothing is happening yet
        //Dice are rolled
        //Lock in Dice
        //Round 1
        //Make second dice roll
        //Lock in dice
        //Round 2
        //Make final dice roll
        //Score dice

        public enum gameStateTypes { Pregame, FirstRoll, SecondRoll, FinalRoll };

        private gameStateTypes gameStatus;

        private int topScore = 0;
        private int bottomScore = 0;
        private int topBonus = 0;
        private int totalScore = 0;

        internal gameStateTypes GameStatus { get => gameStatus; set => gameStatus = value; }

        public int TopScore { get => topScore;}
        public int BottomScore { get => bottomScore;}
        public int TopBonus { get => topBonus;}
        public int TotalScore { get => totalScore;}

        public Yhatzee(gameStateTypes gameStatus)
        {
            this.GameStatus = gameStatus;

        }

        public void addTopScore(int scoreAdd)
        {
            topScore += scoreAdd;
            totalScore += scoreAdd;

            if (topScore >= 63 && topBonus == 0)
            {
                topBonus = 35;
            }
        }

        public void addBottomScore(int scoreAdd)
        {
            bottomScore += scoreAdd;
            totalScore += scoreAdd;
        }



    }
}
