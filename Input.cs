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

        public string InputName()
        {
            isValid = false;

            while(isValid == false)
            {
                Console.WriteLine("What is your character's name?");
                potInput = Console.ReadLine();
                if(potInput.Length >=3 && potInput.Length <= 20)
                {
                    userInput = potInput;
                    isValid = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Your characters name needs to be between 3 and 20 characters long." + "\n Hit enter to return.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            return userInput;
        }

        public string InputPlayer()
        {
            isValid = false;

            while (isValid == false)
            {
                Console.WriteLine("Who are you, the player of this character?");
                potInput = Console.ReadLine();
                if (potInput.Length >= 3 && potInput.Length <= 20)
                {
                    userInput = potInput;
                    isValid = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Your name needs to be 3 to 20 characters long." + "\n Hit enter to return.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            return userInput;
        }

        public string InputOccupation()
        {
            isValid = false;

            while (isValid == false)
            {
                Console.WriteLine("What is your character's current occupation?");
                potInput = Console.ReadLine();
                if (potInput.Length >= 3 && potInput.Length <= 20)
                {
                    userInput = potInput;
                    isValid = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Your occupation needs to be 3 to 20 characters long." + "\n Hit enter to return.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            return userInput;
        }

        public string InputSex()
        {
            isValid = false;

            while (isValid == false)
            {
                Console.WriteLine("What is your character's gender? (M)ale or (F)emale?");
                potInput = Console.ReadLine();
                potInput = potInput.Trim().ToLower();
                if(potInput == "m" || potInput == "male")
                {
                    userInput = "Male";
                    isValid = true;
                    Console.Clear();
                }
                else if(potInput == "f" || potInput == "Female")
                {
                    userInput = "Female";
                    isValid = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Please select either (M)ale or (F)emale." + "\n Hit enter to return.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            return userInput;
        }

        public string InputResidence()
        {
            isValid = false;

            while (isValid == false)
            {
                Console.WriteLine("In what city and state does your character live?");
                potInput = Console.ReadLine();
                if (potInput.Length >= 3 && potInput.Length <= 40)
                {
                    userInput = potInput;
                    isValid = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Your residence needs to be 3 to 40 characters long." + "\n Hit enter to return.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            return userInput;
        }

        public string InputBirthPlace()
        {
            isValid = false;

            while (isValid == false)
            {
                Console.WriteLine("In what city and state was your character born?");
                potInput = Console.ReadLine();
                if (potInput.Length >= 3 && potInput.Length <= 40)
                {
                    userInput = potInput;
                    isValid = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Your birthplace needs to be 3 to 40 characters long." + "\n Hit enter to return.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            return userInput;
        }

        public string InputAge()
        {
            isValid = false;

            while (isValid == false)
            {
                Console.WriteLine("How old is your character?");
                potInput = Console.ReadLine();
                if (int.TryParse(potInput, out int x))
                {
                    if(x >= 15 && x <= 90)
                    {
                        userInput = potInput;
                        isValid = true;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Your character's age must be between 15 and 90." + "\n Hit enter to return.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Please input a number between 15 and 90." + "\n Hit enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            return userInput;
        }
    }
}