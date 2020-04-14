using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Human : Players
    {
       //member variables

        //constructor
        public Human()
        {
            
        }

        //member methods
        public override string ChooseGesture()
        {
            Console.WriteLine("Please choose a gesture from the list: \n");
            foreach (string gesture in Gestures)
            {
                Console.WriteLine(gesture);
                
            }
            choice = Console.ReadLine();
            if (choice == "Rock" || choice == "Paper" || choice == "Scissors" || choice == "Lizard" || choice == "Spock")
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Select not valid, please choose again");
                ChooseGesture();
            }
            
            return choice;
        }


    }
}
