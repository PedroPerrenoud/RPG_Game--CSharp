using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleState_RPG.States
{
    class State
    {
       protected Stack<State> states;
        public State(Stack<State> states)
        {
            this.states = states;

        }

        public void Update()
        {

        }
    }
}
