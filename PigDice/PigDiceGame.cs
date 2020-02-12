using System;
using System.Collections.Generic;
using System.Text;

namespace PigDice {
    public class PigDiceGame {

        private Random rnd = new Random(DateTime.Now.Millisecond);

        public int RollTheDie() {
            return rnd.Next(1, 7);
        }

        public int PigDice() {

            var score = 0;
            var ROLL = RollTheDie();
            while (ROLL != 1) {
                score += ROLL;
                ROLL = RollTheDie();
            }
            return score;
        }

        public void PLAY() {
            var WorldRecordScore = 450;
            var highScore = 0;
            var GamesToPlay = 100000000;
            while(GamesToPlay > 0 || highScore < WorldRecordScore) {
                var score = PigDice();
                if (score > highScore) {
                    highScore = score;
                    Console.WriteLine($"New highscore is {score} ");
                }

                GamesToPlay--;
            }
            Console.WriteLine($"New WW Score is {highScore}");
            

        }

    }
}
