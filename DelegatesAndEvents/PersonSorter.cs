using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    public delegate int Comparation<T>(T x, T y);

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            for(int i = 0; i < people.Length -1; i++) //-1 pois deixamos o último elemento para o for loop interior
            {
                for(int j = i + 1; j < people.Length; j++)
                {
                    if (comparison(people[i], people[j]) > 0)
                    {
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }
        }
    }

}
