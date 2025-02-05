using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleState_RPG.States
{
    internal class State_CharacterCreator : State
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

                case 2: //Create Character
                    this.states.Push(new State_CharacterCreator(this.states));
                    break;

                case 3:
                    //Delete Character
                    break;

                default:
                    break;
            }
        }

        public State_CharacterCreator(Stack<State> states) : base(states) 
        { 
            
        }

        public override void Update()
        {
            Console.WriteLine(Gui.MenuTitle("Character Creator"));
            Console.WriteLine(Gui.MenuOption(1, "Name"));
            Console.WriteLine(Gui.MenuOption(2, "Class"));
            Console.WriteLine(Gui.MenuOption(3, "Attributes"));
            Console.WriteLine(Gui.MenuOption(0, "Return"));

            Console.Write(">> ");
            int input = Convert.ToInt32(Console.ReadLine());

            this.ProcessInput(input);
        }

    }
}
