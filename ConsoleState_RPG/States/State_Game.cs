using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleState_RPG.States
{
    internal class State_Game : State
    {

        public void ProcessInput(int input)
        {
            switch (input)
            {
                case 0: //Exit Game
                    this.end = true;
                    break;

                case 1: //New Game

                    break;

                case 2: //
                    
                    break;

                case 3:
                    //Delete Character
                    break;

                default:
                    break;
            }
        }
        public State_Game(Stack<State> states) : base(states)
        {
            
        }

        override public void Update()
        {
            Console.WriteLine(Gui.MenuTitle("Game State"));
            Console.WriteLine(Gui.MenuOption(0,"Return to Menu"));


            Console.Write(">> ");
            int input = Convert.ToInt32(Console.ReadLine());

            this.ProcessInput(input);
        }
    }
}
