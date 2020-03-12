using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu_Character_Generator
{
    class Character
    {
        public string Name { get; set; }
        public string Player { get; set; }
        public string Occupation { get; set; }
        public string Sex { get; set; }
        public string Residence { get; set; }
        public string BirthPlace { get; set; }

        public int Age { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Constitution { get; set; }
        public int Appearance { get; set; }
        public int Power { get; set; }
        public int Size { get; set; }
        public int Education { get; set; }
        public int HitPoint { get; set; }
        public int Sanity { get; set; }
        public int Luck { get; set; }

        public Character()
        {
            Name = "Unnamed Character";
            Player = "--";
            Occupation = "--";
            Sex = "--";
            Residence = "--";
            BirthPlace = "--";
            Age = 00;
            Strength = 15;
            Dexterity = 30;
            Intelligence = 45;
            Constitution = 60;
            Appearance = 75;
            Power = 90;
            Size = 99;
            Education = 00;
            HitPoint = 0;
            Sanity = 0;
            Luck = 0;
        }

        //Organize and display character information.
        public void DisplayCharacterInfo()
        {
            string title = " 1920's Investigator \n";
            string spacer = "- - - - - - - - - - - \n";
            string stat = "\n Characteristics \n";

            String[,] invDet = new string[,]
            {
                {"Name: ", Name},
                {"Player: ", Player},
                {"Occupation: ", Occupation},
                {"Sex: ", Sex},
                {"Age: ", Age.ToString()},
                {"Birthplace: ", BirthPlace},
                {"Residence: ", Residence}
            };

            String[,] invCha = new string[,]
            {
                {"STR: ", Strength.ToString() },
                {"DEX: ", Dexterity.ToString() },
                {"INT: ", Intelligence.ToString() },
                {"CON: ", Constitution.ToString() },
                {"APP: ", Appearance.ToString() },
                {"POW: ", Power.ToString() },
                {"SIZ: ", Size.ToString() },
                {"EDU: ", Education.ToString() }
            };

            Console.WriteLine(title + spacer);
            DisplaySplit(invDet, false);
            Console.WriteLine(stat + spacer);
            Console.WriteLine("     #  |1/2|1/5");
            DisplaySplit(invCha, true);
        }

        //All information not related to stats that a user inputs should be defaulted to Cyan.
        private void ColourDisplay(string value)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        //If a value is presented to the method, determine what colour is needed in relation to the
        //amount.
        private void ColourDisplay(string text, int value)
        {
            if (value <= 15)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"{text} | {value / 2} | {value / 5}");
                Console.ResetColor();
            }
            else if (value <= 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{text} | {value / 2} | {value / 5}");
                Console.ResetColor();
            }
            else if (value <= 45)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{text} | {value / 2} | {value / 5}");
                Console.ResetColor();
            }
            else if (value <= 60)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{text} | {value / 2} | {value / 5}");
                Console.ResetColor();
            }
            else if (value <= 75)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{text} | {value / 2} | {value / 5}");
                Console.ResetColor();
            }
            else if (value <= 90)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{text} | {value / 2} | {value / 5}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{text} | {value / 2} | {value / 5}");
                Console.ResetColor();
            }
        }

        // Determine if individual characters need to be coloured differently as in relation to stats
        private void DisplaySplit(String[,] value, bool isIndColoured)
        {
            if (isIndColoured)
            {
                for (int x = 0; x < value.Length / 2; x++)
                {
                    Console.Write(value[x, 0]);
                    ColourDisplay(value[x, 1], int.Parse(value[x,1]));
                }
            }
            else
            {

                for (int x = 0; x < value.Length / 2; x++)
                {
                    Console.Write(value[x, 0]);
                    ColourDisplay(value[x, 1]);
                }
            }
        }
    }
}
