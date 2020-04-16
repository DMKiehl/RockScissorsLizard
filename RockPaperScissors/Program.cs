using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Simulation simulation = new Simulation();
                simulation.RunGame();
                Console.WriteLine("Do you want to play again? \nYes \nNo");
                input = Console.ReadLine();
            } while (input == "Yes");
            
           
            
            


            
            

        }
    }
}
