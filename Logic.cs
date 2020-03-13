using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu_Character_Generator
{
    class Logic
    {
        private Character player = new Character();
        private Input userInput = new Input();

        private string temp;

        private bool willContinue = true;

        public void CreateNewChar()
        {
            if(player.isNewCharacter == true)
            {
                temp = userInput.GetInput("name");
                player.SetDetail(temp, "name");
                temp = userInput.GetInput("player");
                player.SetDetail(temp, "player");
                temp = userInput.GetInput("sex");
                player.SetDetail(temp, "sex");
                temp = userInput.GetInput("age");
                player.SetDetail(temp, "age");
                temp = userInput.GetInput("occupation");
                player.SetDetail(temp, "occupation");
                temp = userInput.GetInput("birthplace");
                player.SetDetail(temp, "birthplace");
                temp = userInput.GetInput("residence");
                player.SetDetail(temp, "residence");
                player.DisplayCharacterInfo();

            }
        }
    }
}
