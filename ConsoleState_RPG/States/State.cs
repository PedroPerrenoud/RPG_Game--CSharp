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
       protected bool end = false;
        public State(Stack<State> states)
        {
            this.states = states;

        }

        public bool RquestEnd()
        {
            return this.end;
        }

        virtual public void Update()
        {

        }
    }
}
