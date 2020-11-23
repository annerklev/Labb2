using System;
using System.Collections.Generic;
using System.Text;

namespace Godiskalkylatorn
{
    class Person
    {
        public int Age { get; set; }
        public int Candies { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

      


        public Person(int age, int candies, string firstName, string lastName)
        {
            Age = age;
            Candies = candies;
            FirstName = firstName;
            LastName = lastName;

            


        }
    }
}
