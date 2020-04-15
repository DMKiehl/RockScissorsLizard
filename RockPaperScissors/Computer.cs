using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
     class Computer : Players
    {
        //member variables
        Random myRandom = new Random();

        //constructor
        public Computer(string playerChoice)
        {
            //ChooseGesture(playerChoice);
        }

        
        //member methods
        public override string ChooseGesture(string playerChoice)
        {
            int index = myRandom.Next(Gestures.Count);
            Console.WriteLine(Gestures[index]);
            return (Gestures[index]);
            //int min = 1;
            //int max = 6;

            //string result = Convert.ToString(myRandom.Next(min, max));
            //return result;
        }
    }
}
