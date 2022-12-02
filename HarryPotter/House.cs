using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HarryPotter
{
    public abstract class House
    {
        //Lista för klassen wizard där eleverna lagras
        public List<Wizard> Wizards { get; set; } = new List<Wizard>();


        public string? HouseGhost { get; set; }
        public string? Mascot { get; set; }
        public string? Password { get; set; }

        //metod för att säkerhetställa längden på lösenordet
        public virtual bool IsPasswordCorrectLength(string password)
        {
            
            if (password.Length >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
        //metod för att se om det är en vokal som första bokstav
        public virtual bool IsPasswordCorrectVowel(string password)
        {
            password = password.ToLower();

            if (password[0] == 'a' || password[0] == 'e' || password[0] == 'i' || password[0] == 'o' || password[0] == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        //metod för att se om sista bokstaven är en konsonant
        public bool IsPasswordCorrectConsonant(string password)
        {
            password = password.ToLower();

            if (password[password.Length - 1] == 'a' || password[password.Length - 1] == 'e' || password[password.Length - 1] == 'i' || password[password.Length - 1] == 'o' || password[password.Length - 1] == 'u')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //metod som ser så att alla krav metoder är uppfyllda
        public bool IsPasswordCorrect(string password)
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

        //Metod för att byta lösenord och att det går igenom kraven
        public void SetPassword(string password)
        {
            if (IsPasswordCorrect(password) == true)
            
            {
                Password = password;
            }
            else
            {
                return;
            }
        }

        
        


       
    }
}
