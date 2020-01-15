using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLizardSpock
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        




        public void RunGame()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock! \n\nThe rules are as follows:\nRock crushes Scissors \nScissors cuts Paper \nPaper covers Rock \nRock crushes Lizard \nLizard poisons Spock \nSpocksmashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock \nSpock vaporizes Rock\n");

            ChooseGameMode();

            PlayersChooseGestures();

            CompareResults();

            DisplayFinalResults();

            AskPlayAgain();

        }

        public void ChooseGameMode()
        {
            Console.WriteLine("Game mode? Input either 1 or 2. \n1)P Vs. P \n2)P Vs. CPU");
            string userInput = Console.ReadLine();
            {
                if (userInput == "1")
                {
                    playerOne = new Human();
                    playerTwo = new Human();
                    Console.WriteLine("You have chosen P Vs. P");
                }
                else
                {
                    playerOne = new Human();
                    playerTwo = new CPU();
                    Console.WriteLine("You have chosen P Vs. CPU");
                }
                Console.ReadLine();
                Console.Clear();

            }

        }

        public void PlayersChooseGestures()
        {
           
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
  
        }

        public void CompareResults()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)


                if (playerOne.choice == playerTwo.choice)
                {
                    Console.WriteLine("Tie, pick again");
                    PlayersChooseGestures();
                }
                else if (playerOne.choice == "rock" && (playerTwo.choice == "scissors" || playerTwo.choice == "lizzard"))
                {

                    Console.WriteLine("player one wins");
                    playerOne.score ++;
                    DisplayRound();
                    PlayersChooseGestures();
                }

                else if (playerOne.choice == "paper" && (playerTwo.choice == "rock" || playerTwo.choice == "spock"))
                {
                    Console.WriteLine("player one wins");
                    playerOne.score ++;
                    DisplayRound();
                    PlayersChooseGestures();
                }

                else if (playerOne.choice == "scissors" && (playerTwo.choice == "paper" || playerTwo.choice == "Lizzard"))
                {
                    Console.WriteLine("player one wins");
                    playerOne.score ++;
                    DisplayRound();
                    PlayersChooseGestures();
                }

                else if (playerOne.choice == "lizzard" && (playerTwo.choice == "paper" || playerTwo.choice == "spock"))
                {
                    Console.WriteLine("player one wins");
                    playerOne.score ++;
                    DisplayRound();
                    PlayersChooseGestures();
                }

                else if (playerOne.choice == "spock" && (playerTwo.choice == "scissors" || playerTwo.choice == "Lizzard"))
                {
                    Console.WriteLine("player one wins");
                    playerOne.score ++;
                    DisplayRound();
                    PlayersChooseGestures();
                }
                else
                {
                    Console.WriteLine("player two wins");
                    playerTwo.score ++;
                    DisplayRound();
                    PlayersChooseGestures();
                }
           
        } 

        public void DisplayRound()
        {
            string round = $"Player one chose {playerOne.choice} \nPlayer two chose {playerTwo.choice}\n\nPlayer one score {playerOne.score}\nPlayer two score {playerTwo.score}";

            Console.WriteLine(round);
            Console.ReadLine();
            Console.Clear();
        }

        public void TallyRound()
        {
           
        }

        public void DisplayFinalResults()
        {


            if (playerOne.score == 2)
            {
                Console.WriteLine("Player one wins!");
            }

            else if (playerTwo.score == 2)
            {
                Console.WriteLine("Player two wins!");
            }

            else
            {
                DisplayRound();
            }

        }

        public void AskPlayAgain()
        {
            Console.WriteLine("Would you like to play again? Type either y or n");
            string userInput = Console.ReadLine();

            if (userInput == "y")
            {
                ChooseGameMode();
            }
            else if (userInput == "n")
            {
                Console.WriteLine("Have a nice day!");
            }
            else
            {
                AskPlayAgain();
            }





        }

    }
}
