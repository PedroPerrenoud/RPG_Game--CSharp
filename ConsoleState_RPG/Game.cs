using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            Console.WriteLine(this.states.GetHashCode());

            //Push the first state
            this.states.Push(new State(this.states));
        }

        //Constructors and Destructors
        public Game()
        {
            Console.WriteLine( "Game Class working" );
            this.initVariables();
            this.InitStates();

        }

        public void Run()
        {
            while( !this.end )
            {
                Console.WriteLine( "If you want to finish [N<0]" );
                Console.Write( "Choose a number [N>0]>> " );
                int number = Convert.ToInt32( Console.ReadLine() );

                // I omitted the curly braces because the code is only one line long, so it can be written directly under the if/else statement without needing braces.
                if (number < 0)
                    this.end = true;
                else
                    Console.WriteLine( "The number choose are> " + number );
            }
            Console.WriteLine( "Ending Game..." );
        }
    }
}
