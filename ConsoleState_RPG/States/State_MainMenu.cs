using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleState_RPG.States
{
    internal class State_MainMenu : State
    {
        public State_MainMenu(Stack<State> states)
            : base(states) 
        {
            
            this.states.Push(new State_Game(this.states));
        }


    }
}
