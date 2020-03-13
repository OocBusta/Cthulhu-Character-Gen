using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu_Character_Generator
{
    class Input
    {
        private string potInput;
        private string userInput;
        private bool isValid;

        public string GetInput(string userChoice)
        {
            isValid = false;
            while (isValid == false)
            {
                if (userChoice.Trim().ToLower() == "age")
                {
                    Console.WriteLine("Please type in your character's {0}.", userChoice);
                    string potInput = Console.ReadLine();
                    // Determine if input is a number and, if it is, determine is it fits into parameters.
                    if (int.TryParse(potInput, out int x))
                    {
                        if (x >= 15 && x <= 90)
                        {
                            userInput = potInput;
                            isValid = true;
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Please input a number between 15 and 90.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please input a number between 15 and 90.");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }
                else
                {
                    // Determine if the string sent in is too large or too small.
                    Console.WriteLine("Please type in your character's {0}.", userChoice);
                    potInput = Console.ReadLine();
                    if (potInput.Length >= 3 && potInput.Length <= 15)
                    {
                        userInput = potInput;
                        isValid = true;
                        Console.Clear();


                    }
                    else
                    {
                        Console.WriteLine("Please input a {0} that is 3 - 15 characters long.", userChoice);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }

            return userInput; 
        }
        
    }
}
