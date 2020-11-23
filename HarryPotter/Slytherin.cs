using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotter
{
    class Slytherin : House
    {
        
        public Slytherin()

        {
            HouseGhost = "Blodige Baronen";
            Mascot = "Orm";
            Password = "Har andra regler";
        }

        public override bool HasCorrectPasswordFormat(string password)
        {
            {   
                if (password.Length >= 8 && FirstLetterConsonant(password) && LastLetterIsConsonant(password))

                    return true;

                else
                { return false; }
            }
        }


        public bool FirstLetterConsonant(string password)
        {

            for (int i = 0; i < password.Length; i++)

                if (LetterIsVowel(password[0]))
                {
                    return false;
                }

            return true;
        }
    }
}



















