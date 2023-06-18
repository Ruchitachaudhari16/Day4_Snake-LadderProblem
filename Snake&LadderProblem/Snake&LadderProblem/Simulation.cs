using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake_LadderProblem
{
     public  class Simulation
    {
        //Uc2:-The Player rolls the die to get a number between 1 to 6.Use((RANDOM)) to get the number between1 to 6

        public void StartPosition()
        {
             int startPosition = 0;
            Console.WriteLine("Game played with single player at StartPosition:" + startPosition);
        }
        public void RolledDie()
        {
            Random random = new Random();
           int dierolled= random.Next(1,7);
            Console.WriteLine("The Player geta number:" + dierolled);
               
        }
    }
}
