using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleState_RPG.States;


namespace ConsoleState_RPG
{
    class Game
    {
        //Variables
        private bool end;
        public bool End
        {
            get { return this.end; }
            set { this.end = value; }   
        }
        
        private Stack<State> states;


        //Private Functions
        private void initVariables()
        {
            this.end = false;
        }

        private void InitStates() 
        {
            this.states = new Stack<State>();

            //Push the first state
            this.states.Push(new State_MainMenu(this.states));
            this.states.Push(new State_Game(this.states));
        }

        //Constructors and Destructors
        public Game()
        {
            this.initVariables();
            this.InitStates();
        }

        public void Run()
        {
            while (this.states.Count > 0)
            {
                    this.states.Peek().Update();

                    if (this.states.Peek().RquestEnd())
                        this.states.Pop();
            }
            Console.WriteLine("Ending the Game....");
        }
    }
}
