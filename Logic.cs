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

        public void CreateNewChar()
        {
            if (player.isNewCharacter == true)
            {
                temp = userInput.InputName();
                player.SetDetail(temp, "name");
                temp = userInput.InputPlayer();
                player.SetDetail(temp, "player");
                temp = userInput.InputSex();
                player.SetDetail(temp, "sex");
                temp = userInput.InputAge();
                player.SetDetail(temp, "age");
                temp = userInput.InputOccupation();
                player.SetDetail(temp, "occupation");
                temp = userInput.InputBirthPlace();
                player.SetDetail(temp, "birthplace");
                temp = userInput.InputResidence();
                player.SetDetail(temp, "residence");
                player.DisplayCharacterInfo();

            }
        }
    }
}