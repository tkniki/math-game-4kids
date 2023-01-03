using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace math_game_4kids.GameLogic
{
    public class Game
    {

        #region Fields

        public int PlayerScores { get; set; }
        public int RobotScores { get; set; }
        private Difficulty difficulty;
        public Operation operation { get; set; }

        #endregion

        public Game(Difficulty difficulty)
        {
            PlayerScores = 0;
            RobotScores = 0;
            this.difficulty = difficulty;
        }

        private void generateOperationByDifficulty()
        {
            switch (difficulty)
            {
                case Difficulty.EASY:
                    operation = new EasyOperation();
                    break;
                case Difficulty.MEDIUM:
                    operation = new MediumOperation();
                    break;
                case Difficulty.HARD:
                    operation = new HardOperation();
                    break;
                default:
                    break;
            }
        }
        
        public void PlayRound()
        {
            generateOperationByDifficulty();
        }


    }
}
