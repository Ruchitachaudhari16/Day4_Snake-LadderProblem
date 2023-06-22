using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_LadderProblem
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake & Ladder Problem");
            Simulation simulation = new Simulation();
          simulation.StartPlaying();

            Console.ReadLine(); 
        }
    }
}
