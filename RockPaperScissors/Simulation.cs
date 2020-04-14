using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Simulation
    {
        //member variables
        public int PlayerOneChoice;
        public int PlayerTwoChoice;
        public int PlayerOneScore;
        public int PlayerTwoScore;

        //constructor
        public Simulation()
        {
            PlayerOneScore = 0;
            PlayerTwoScore = 0;
        }

        //member methods
        public void RunGame()
        {
            while (PlayerOneScore < 3 && PlayerTwoScore < 3)
            {
                //Player one choose a gesture

                //player two choose a gesture

                CompareChoices(PlayerOneChoice, PlayerTwoChoice)
            }

        }

        public void CompareChoices(int choice1, int choice 2)
        {

        }

        public void DeclareWinner()
        {
            if(PlayerOneScore == 3)
            {
                Console.WriteLine("Player One Wins!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Player Two Wins");
                Console.ReadLine();
            }

        }


    }
}
