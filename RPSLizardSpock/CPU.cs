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
            Console.WriteLine("CPU choosing... Press enter");
            Console.ReadLine();

            Random random = new Random();
            int num = random.Next(0,5);

            choice = gesturesList[num];
            Console.WriteLine(choice);
            Console.ReadLine();
            
            Console.Clear();
        }


    }
}
