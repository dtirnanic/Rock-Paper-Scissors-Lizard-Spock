using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLizardSpock
{
    class Human : Player
    {

        public override void ChooseGesture()
        {

            //Console.WriteLine("Select gesture through list of numbers 1-5\n1) Rock \n2) Paper \n3) Scissors \n4) Lizard \n5) Spock");
            Console.WriteLine("Choose gesture from list by choosing nuber 1-5");

            foreach (string gesture in gesturesList)
            {
                
                Console.WriteLine(gesture.ToString());
            }

            
            string userInput = Console.ReadLine();

            //for (int counter = 0; counter < gesturesList.Count; counter++)
            
                Console.WriteLine(userInput + "\n"); 
            
        }


    }
}
