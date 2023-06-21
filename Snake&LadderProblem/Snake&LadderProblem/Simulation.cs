using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake_LadderProblem
{
    public class Simulation
    {

        public const int NO_PLAY = 0;
        public const int IS_LADDER = 1;
        public const int IS_SNAKE = 2;
        public const int startPosition = 0;

        public void StartPosition()
        {
            int startPosition = 0;
            Console.WriteLine("Game played with single player at StartPosition:" + startPosition);
        }
        public void RolledDie()
        {
            Random random = new Random();
            int dierolled = random.Next(1, 7);
            Console.WriteLine("The Player geta number:" + dierolled);

        }
    
    public void OptionCheck()
        {
            //UC3: The Player then checks for a Option. They are No Play,
            //Ladder or Snake. -Use((RANDOM)) to check for Options
            
            int playerPosition = 0;

            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            Console.WriteLine("Dice Number :" + diceRoll);

            Random random1 = new Random();
            int optionCheck = random1.Next(0, 3);
            Console.WriteLine("Option " + optionCheck);
            switch (optionCheck)
            {
                case NO_PLAY:
                    playerPosition = 0;
                    break;
                case IS_LADDER:
                    playerPosition += diceRoll;
                    break;
                case IS_SNAKE:
                    playerPosition -= diceRoll;
                    break;
            }
            Console.WriteLine("Player Position :" + playerPosition);
        }
    }
}
       