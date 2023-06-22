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
﻿
            public int startPositiont = 0;
            public int RolledDie = 0;
            public int Choice = 0;
            int Option = 0;
            public void StartPlaying()
            {
                Console.WriteLine("Game started");
                while (startPositiont != 100)
                {
                    Random random = new Random();
                RolledDie = random.Next(1, 7);  //Random value betw 1 to 6
                    Console.WriteLine("Dice Number is : " + RolledDie);
                    Choice = random.Next(0, 3); //value to check its snake or ladder
                    Console.WriteLine("Dice value :" + Choice);
                 

                    switch (Choice)
                    {
                        case 0:  //for no play if choice =0
                            Console.WriteLine("No Play");
                            break;
                        case 1:                         //if choice =1
                            startPositiont += RolledDie;    //startPoisition = startPoint +RolledDie
                        Console.WriteLine("Got Ladder: " + startPositiont);
                            break;
                        case 2:
                            startPositiont -= RolledDie;        //if choice=2
                            Console.WriteLine("snake Attack: " + startPositiont); //startPoisition -RolledDie
                        break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                    if (startPositiont < 0) //if 0<0 then it will start again
                    {
                        startPositiont = 0;
                    }
                }
            }
        }
    }





       