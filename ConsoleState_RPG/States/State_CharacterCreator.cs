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
                case 0: //Return
                    this.end = true;
                    break;

                case 1: //Define a Name

                    break;

                case 2: //Define Class
                    
                    break;

                case 3: //Define Attributes
                    
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
