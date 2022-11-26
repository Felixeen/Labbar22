using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HarryPotter
{
    public class Slytherin : House
    {
        public Slytherin()
        {
            HouseGhost = "The Bloody Baron";
            Mascot = "Snake";
            Password = "Snakegang";
        }

        public override bool IsPasswordCorrectLength(string password)
        {

            if (password.Length >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        //Skriver över samma medtod i house, flippar om för att kolla om det är en konsonant som första bokstav
        public override bool IsPasswordCorrectVowel(string password)
        {
            password = password.ToLower();

            if (password[0] == 'a' || password[0] == 'e' || password[0] == 'i' || password[0] == 'o' || password[0] == 'u')
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        
        public override bool IsPasswordCorrect(string password)
        {
            if (IsPasswordCorrectLength(password) && IsPasswordCorrectVowel(password) && IsPasswordCorrectConsonant(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
