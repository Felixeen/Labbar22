using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godiskalkylatorn
{
    public class CandyCalculator
    {
        public List <Person> Members { get; set; } = new List<Person>();


        public void DistributeCandies(int Candies)
        {

            int nummer = Candies;
            for (int i = 0; i < nummer; i+=Members.Count)
            {
                //Members[i % Members.Count].Candies++;

                foreach (Person person in Members)
                {
                    person.Candies++;
                    Candies--;
                    
                    if (Candies == 0)
                    {
                        break;
                    }


                }
            }    

        }

    }
}
