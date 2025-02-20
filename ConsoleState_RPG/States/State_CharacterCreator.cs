using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleState_RPG.Characters;

namespace ConsoleState_RPG.States
{
    internal class State_CharacterCreator : State
    {
        ArrayList characterList;
        public State_CharacterCreator(Stack<State> states, ArrayList character_list) : base(states) 
        { 
            this.characterList = character_list;
        }


        public void ProcessInput(int input)
        {
            switch (input)
            {
                case 0: //Return
                    this.end = true;
                    break;

                case 1: //Define a Name
                    this.characterList.Add(new PlayerCharacter("Bob"));
                    this.characterList.Add(new PlayerCharacter("Thor"));
                    this.characterList.Add(new PlayerCharacter("Loki"));
                    Console.WriteLine(Gui.Annoucement("Characters created"));
                    break;

                case 2: //Define Class

                    break;

                case 3: //Define Attributes

                    break;

                default:
                    break;
            }
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
