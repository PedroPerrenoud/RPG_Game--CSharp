using System;

namespace ConsoleState_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine(Gui.Title("Adriano's Revenge"));
            game.Run();
        }  
     }
}