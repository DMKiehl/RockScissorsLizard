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
        public Human(string playerChoice)
        {
            
        }

        //member methods
        public override string ChooseGesture(string playerChoice)
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
                ChooseGesture("New Choice");
            }
            
            return choice;
        }


    }
}
