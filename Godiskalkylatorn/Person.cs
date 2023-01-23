using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godiskalkylatorn
{
    public class Person
    {
        

        public int Age { get; set; }
        public int Candies { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        


        
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Age} år): {Candies} st.";
            
        }


    }
}

    //personListBox.Items.Add(person.ToString());
    
