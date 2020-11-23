using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotter
{
    abstract class House


    {
        public string HouseGhost { get; set; }
        public string Mascot { get; set; }
        public string Password { get; set; }
        public string Members { get; set; }

        public virtual bool HasCorrectPasswordFormat(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (PasswordHasFiveLetters(password) && FirstLetterIsVowel(password) && LastLetterIsConsonant(password))

                { return true; }
            }
            return false;
        }

        public bool IsRightPassword(string password)
        {
            if (password == Password)
            { return true; }

            return false;
        }

        public bool SetPassword(string correctpassword, string wrongpassword)
        {
            if (HasCorrectPasswordFormat(correctpassword) && IsRightPassword(correctpassword))
            { return true; }

            if (HasCorrectPasswordFormat(wrongpassword) && IsRightPassword(wrongpassword))
            {
                return false;
            }

            return true;
        }


        public bool PasswordHasFiveLetters(string password)
        {
            int count = 0;
            foreach (char letter in password)

            {
                count++;
                if (password.Length < 5)
                { { return false; } }
            }

            return true;
        }
        public bool LetterIsVowel(char c)
        {
            char[] vokaler = new char[] { 'a', 'A', 'o', 'O', 'U', 'u', 'Å', 'å', 'E', 'e', 'Y', 'y', 'I', 'i', 'Ä', 'ä', 'Ö', 'ö' };

            foreach (char v in vokaler)
            {
                if (v == c)
                {
                    return true;
                }
            }

            return false;
        }

        public bool FirstLetterIsVowel(string password)
        {
            char[] StringToChar = password.ToCharArray();
            for (int i = 0; i < password.Length; i++)

                if (LetterIsVowel(StringToChar[0]))
                { return true; }

            return false;
        }

        public bool LastLetterIsConsonant(string password)
        {
            for (int i = 0; i < password.Length; i++)

                if (!LetterIsVowel(password[password.Length - 1]) && IsLetterDigit(password))
                { return true; }

            return false;
        }

        
        
        public bool IsLetterDigit(string password)
        {
            foreach (char letter in password)
            {
                if (Char.IsDigit(letter))

                { return false; }

            }
            return true;
        }
    }



}
























