using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_LadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake & Ladder Problem");
            Simulation simulation = new Simulation();
            simulation.StartPosition();
            simulation.RolledDie();
            simulation.OptionCheck();

            Console.ReadLine(); 
        }
    }
}
