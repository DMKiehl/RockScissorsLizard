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
            player1 = new Human("Player One");
            player2 = new Computer("Player Two");
            while (PlayerOneScore < 3 && PlayerTwoScore < 3)
            {
                //Player One (human) chooses gesture
                
                player1.ChooseGesture("Player One");
                PlayerOneChoice = player1.choice;

                //Player Two (computer) chooses gesture
                
                player2.ChooseGesture("Player Two");
                PlayerTwoChoice = player2.choice;

                CompareChoices(PlayerOneChoice, PlayerTwoChoice);
            };

            DeclareWinner(PlayerOneScore, PlayerTwoScore);

        }

        public void RunMultiPlayerGame()
        {
            player1 = new Human("Player One");
            player2 = new Human("Player Two");
            while (PlayerOneScore < 3 && PlayerTwoScore < 3)
            {
                //Player One (human) chooses gesture
                player1.ChooseGesture("Player One");
                PlayerOneChoice = player1.choice;

                //Player Two (human) chooses gesture 
                player2.ChooseGesture("Player Two");
                PlayerTwoChoice = player2.choice;

                CompareChoices(PlayerOneChoice, PlayerTwoChoice);
            };

            DeclareWinner(PlayerOneScore, PlayerTwoScore);
        }

        public void CompareChoices(string PlayerOneChoice, string PlayerTwoChoice)
        {
            if (PlayerOneChoice == "Rock")
            {
                if (PlayerTwoChoice == "Scissors")
                {
                    Console.WriteLine("Rock crushes Scissors");
                    Console.WriteLine("Player One wins this round!");
                    PlayerOneScore++;
                }
                else if (PlayerTwoChoice == "Paper")
                {
                    Console.WriteLine("Paper covers Rock");
                    Console.WriteLine("Player Two wins this round!");
                    PlayerTwoScore++;
                }
                else if (PlayerTwoChoice == "Lizard")
                {
                    Console.WriteLine("Rock crushes Lizard");
                    Console.WriteLine("Player One wins this round!");
                    PlayerOneScore++;
                }
                else
                {
                    Console.WriteLine("Spock vaporizes Rock");
                    Console.WriteLine("Player Two wins this round!");
                    PlayerTwoScore++;
                }
            }
            else if (PlayerOneChoice == "Scissors")
            {
                if (PlayerTwoChoice == "Paper")
                {
                    Console.WriteLine("Scissors cuts Paper");
                    Console.WriteLine("Player One wins this round!");
                    PlayerOneScore++;
                }
                else if (PlayerTwoChoice == "Spock")
                {
                    Console.WriteLine("Spock smashes Scissors");
                    Console.WriteLine("Player Two wins this round!");
                    PlayerTwoScore++;
                }
                else if (PlayerTwoChoice == "Rock")
                {
                    Console.WriteLine("Rock crushes Scissors");
                    Console.WriteLine("Player Two wins this round!");
                    PlayerTwoScore++;
                }
                else
                {
                    Console.WriteLine("Scissors decapitates Lizard");
                    Console.WriteLine("Player One wins this round!");
                    PlayerOneScore++;
                }
            }
            else if (PlayerOneChoice == "Lizard")
            {
                if (PlayerTwoChoice == "Spock")
                {
                    Console.WriteLine("Lizard poisons Spock");
                    Console.WriteLine("Player One wins this round!");
                    PlayerOneScore++;
                }
                else if (PlayerTwoChoice == "Rock")
                {
                    Console.WriteLine("Rock crushes Lizard");
                    Console.WriteLine("Player Two wins this round!");
                    PlayerTwoScore++;
                }
                else if (PlayerTwoChoice == "Scissors")
                {
                    Console.WriteLine("Scissors decapitates Lizard");
                    Console.WriteLine("Player Two wins this round!");
                    PlayerTwoScore++;
                }
                else
                {
                    Console.WriteLine("Lizard eats Paper");
                    Console.WriteLine("Player One wins this round!");
                    PlayerOneScore++;
                }
            }
            else if (PlayerOneChoice == "Paper")
            {
                if (PlayerTwoChoice == "Spock")
                {
                    Console.WriteLine("Paper disproves Spock");
                    Console.WriteLine("Player One wins this round!");
                    PlayerOneScore++;
                }
                else if(PlayerTwoChoice == "Scissors")
                {
                    Console.WriteLine("Scissors cuts Paper");
                    Console.WriteLine("Player Two wins this round!");
                    PlayerTwoScore++;
                }
                else if(PlayerTwoChoice == "Rock")
                {
                    Console.WriteLine("Paper covers Rock");
                    Console.WriteLine("Player One wins this round!");
                    PlayerOneScore++;
                }
                else
                {
                    Console.WriteLine("Lizard eats Paper");
                    Console.WriteLine("Player Two wins this round!");
                    PlayerTwoScore++;
                }
            }
            else if (PlayerOneChoice == "Spock")
            {
                if(PlayerTwoChoice == "Rock")
                {
                    Console.WriteLine("Spock vaporizes Rock");
                    Console.WriteLine("Player One wins this round!");
                    PlayerOneScore++;
                }
                else if (PlayerTwoChoice == "Paper")
                {
                    Console.WriteLine("Paper disproves Spock");
                    Console.WriteLine("Player Two wins this round!");
                    PlayerTwoScore++;
                }
                else if(PlayerTwoChoice == "Scissors")
                {
                    Console.WriteLine("Spock smashes Scissors");
                    Console.WriteLine("Player One wins this round!");
                    PlayerOneScore++;
                }
                else
                {
                    Console.WriteLine("Lizard poisons Spock");
                    Console.WriteLine("Player Two wins this round!");
                    PlayerTwoScore++;
                }

            }
            else
            {
                Console.WriteLine("You tie, please play again!");
            }
            Console.ReadLine();

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
