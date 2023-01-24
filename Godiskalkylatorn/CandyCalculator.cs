using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Godiskalkylatorn
{
    public class CandyCalculator
    {
        public List<Person> Members { get; set; } = new List<Person>();

        
        //metod för att distrubiera karamellerna
        public void DistributeCandies(int candies)
        {
            
            int rest = candies % Members.Count;
            int total = candies / Members.Count;

            foreach (Person member in Members)
            {
                member.Candies = total;
            }

            foreach (Person member in Members)
            {
                if (rest > 0)
                {
                    rest--;
                    member.Candies++;  
                }
            }




        }
        //sorteringsmetoder som aktiveras från radioknapparna
        public void SortByFirstName()
        {
            Members = Members.OrderBy(x => x.FirstName).ToList();

        }

        public void SortByLastName()
        {

            Members = Members.OrderBy(x => x.LastName).ToList();
        }
        public void SortByAge()
        {

            Members = Members.OrderBy(x => x.Age).ToList();

        }

    }   
}
