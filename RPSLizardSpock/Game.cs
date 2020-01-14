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
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();



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

            }

        }


    }
}
