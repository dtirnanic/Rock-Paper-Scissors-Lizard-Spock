using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLizardSpock
{
    abstract class Player 
    {
        public string name;
        public int score;
        public List<string> gesturesList = new List<string>() { "rock", "paper", "scissors", "lizzard", "spock" };

        public Player()
        {
            score = 0;

        }

        public abstract void ChooseGesture();
        
           
        
    }
  
}

