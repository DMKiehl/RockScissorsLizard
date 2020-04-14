using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Players
    {
        //member variables
        public string choice;
        public List<string> Gestures;

        //constructor
        public Players()
        {
            Gestures = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            //foreach (string gesture in Gestures)
            //{
            //    Console.WriteLine(gesture);
            //    Console.ReadLine();
            //}
        }

        //member methods
        public abstract string ChooseGesture();


    }
}
