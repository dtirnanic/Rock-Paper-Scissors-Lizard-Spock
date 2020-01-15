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
        string chosenGesture;


        

        public void RunGame()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock! \n\nThe rules are as follows:\nRock crushes Scissors \nScissors cuts Paper \nPaper covers Rock \nRock crushes Lizard \nLizard poisons Spock \nSpocksmashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock \nSpock vaporizes Rock\n");

            ChooseGameMode();
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();
            DisplayFinalResults();
            CompareResults();
            DisplayFinalResults();

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
                Console.Clear();

            }

        }

       

        public void CompareResults()
        {
            do


            if (playerOne.choice == playerTwo.choice)
            {
                Console.WriteLine("Tie, pick again");
            }

            else if (playerOne.choice == "rock" && (playerTwo.choice == "paper" || playerTwo.choice == "spock"))
            {
                Console.WriteLine("player one wins");
                playerOne.score++;
            }
            else if (playerTwo.choice == "rock" && (playerOne.choice == "paper" || playerOne.choice == "spock"))
            {
                Console.WriteLine("player two wins");
                playerTwo.score++;
            }
            else if (playerOne.choice == "paper" && playerTwo.choice == "rock")
            {
                Console.WriteLine("player one wins");
                playerOne.score++;
            }
            else if (playerTwo.choice == "paper" && playerOne.choice == "rock")
            {
                Console.WriteLine("player two wins");
                playerTwo.score++;
            }
            else if (playerOne.choice == "scissors" && playerTwo.choice == "paper" || playerTwo.choice == "Lizard")
            {
                Console.WriteLine("player one wins");
                playerOne.score++;
            }
            else if (playerTwo.choice == "scissors" && playerOne.choice == "paper" || playerOne.choice == "Lizard")
            {
                Console.WriteLine("player two wins");
                playerTwo.score++;
            }
            else if (playerOne.choice == "lizard" && playerTwo.choice == "paper" || playerTwo.choice == "spock")
            {
                Console.WriteLine("player one wins");
                playerOne.score++;
            }
            else if (playerTwo.choice == "lizard" && playerOne.choice == "paper" || playerOne.choice == "spock")
            {
                Console.WriteLine("player two wins");
                playerTwo.score++;
            }
            else if (playerOne.choice == "spock" && playerTwo.choice == "scissors")
            {
                Console.WriteLine("player one wins");
                playerOne.score++;
            }
            else if (playerTwo.choice == "spock" && playerOne.choice == "scissors")
            {
                Console.WriteLine("player two wins");
                playerTwo.score++;
            }
            while (playerOne.score < 2 || playerTwo.score < 2) ;

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
            Console.WriteLine("Would you like to play again?");

        }

    }
}
