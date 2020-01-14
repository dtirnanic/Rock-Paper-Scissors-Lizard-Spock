using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLizardSpock
{
    class CPU : Player
    {


        public override void ChooseGesture()
        {
            Console.WriteLine("CPU choosing");

            Random gestures = new Random();

            for (int counter = 0; counter < gesturesList.Count; counter++)
            {
                Console.WriteLine(gesturesList[counter]);
            }
            Console.WriteLine();
        }


    }
}
