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
        public string PlayerOneChoice;
        public string PlayerTwoChoice;
        public int PlayerOneScore;
        public int PlayerTwoScore;
        public Players player1;
        public Players player2;
        //public Players player3 = new Human();

        //constructor
        public Simulation()
        {
            PlayerOneScore = 0;
            PlayerTwoScore = 0;
        }

        //member methods
        public void ChooseGameMode()
        {
            Console.WriteLine("Which game mode would you like? \n1. Single Player \n2. Multiplayer");
            int gameMode = Convert.ToInt32(Console.ReadLine());
            if (gameMode == 1)
            {
                RunSinglePlayerGame();
            }
            else
            {
                RunMultiPlayerGame();
            }
        }
        
        public void RunSinglePlayerGame()
        {
            while (PlayerOneScore < 3 && PlayerTwoScore < 3)
            {
                //Player One (human) chooses gesture
                player1 = new Human();
                player1.ChooseGesture();

                //Player Two (computer) chooses gesture
                player2 = new Computer();
                player2.ChooseGesture(); 
                CompareChoices(PlayerOneChoice, PlayerTwoChoice);
            };

            DeclareWinner(PlayerOneScore, PlayerTwoScore);

        }

        public void RunMultiPlayerGame()
        {
            while (PlayerOneScore < 3 && PlayerTwoScore < 3)
            {
                //Player One (human) chooses gesture
                player1 = new Human();
                player1.ChooseGesture();

                //Player Two (human) chooses gesture
                player2 = new Human();
                player2.ChooseGesture();
                CompareChoices(PlayerOneChoice, PlayerTwoChoice);
            };

            DeclareWinner(PlayerOneScore, PlayerTwoScore);
        }

        public void CompareChoices(string PlayerOneChoice, string PlayerTwoChoice)
        {


        }

        public void DeclareWinner(int PlayerOneScore, int PlayerTwoScore)
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
