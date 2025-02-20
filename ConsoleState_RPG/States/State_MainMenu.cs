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
            
        }

        public void ProcessInput(int input)
        {
            switch(input)
            {
                case 0: //Exit Game
                    this.end = true;
                    break;
                
                case 1: //New Game
                    this.states.Push(new State_Game(this.states));
                    break;

                case 2: //Create Character
                    this.states.Push(new State_CharacterCreator(this.states));
                    break;
                
                case 3: //Delete Character

                    break;
                
                default:
                    break;
            }
        }
        override public void Update()
        { 
            Console.WriteLine(Gui.MenuTitle("Menu State"));
            Console.WriteLine(Gui.MenuOption(1, "New Game"));
            Console.WriteLine(Gui.MenuOption(2, "Create Character"));
            Console.WriteLine(Gui.MenuOption(3, "Delete Character"));
            Console.WriteLine(Gui.MenuOption(0, "Exit Game"));
            
            Console.Write(">> ");
            int input = Convert.ToInt32(Console.ReadLine());

            this.ProcessInput(input);

        }
    }
}
