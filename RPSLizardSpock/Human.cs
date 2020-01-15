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

            Console.WriteLine("Choose gesture from list by choosing nuber 1-5");

            foreach (string gesture in gesturesList)
            {
                
                Console.WriteLine(gesture.ToString());
            }
            
            int numberChoice = int.Parse(Console.ReadLine());
            choice = gesturesList[numberChoice - 1];
            Console.WriteLine(choice + "\n");
            Console.ReadLine();
        }
         


    }
}
