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

            Random random = new Random();
            int num = random.Next(0,4);

            {
                Console.WriteLine(gesturesList[num]);

            }
            Console.WriteLine(); 
        }


    }
}
