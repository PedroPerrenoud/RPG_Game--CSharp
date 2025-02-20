using System;
using System.Collections.Generic;
using System.Collections;
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
        private ArrayList characterList; //Where we gonna to insert our caracters created to not delete them on the end of Character State


        //Private Functions
        private void initVariables()
        {
            this.end = false;
        }

        private void initCharacterList()
        {
            this.characterList = new ArrayList();
        }

        private void InitStates() 
        {
            this.states = new Stack<State>();

            //Push the first state
            this.states.Push(new State_MainMenu(this.states, this.characterList));
        }

        //Constructors and Destructors
        public Game()
        {
            this.initVariables();
            this.initCharacterList();
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
