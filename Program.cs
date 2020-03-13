using System;

namespace Cthulhu_Character_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic game = new Logic();
            game.CreateNewChar();
            Console.ReadLine();
        }
    }
}