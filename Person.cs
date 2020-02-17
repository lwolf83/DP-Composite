using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    class Person
    {
        public string Name;
        public List<Person> Descendants = new List<Person>();

        public Person(string name)
        {
            Name = name;
        }

        public  override string ToString()
        {
            string result = Name + " - " ;
            foreach(Person child in Descendants)
            {
                result += child.ToString();
            }

            return result;
        }

    }
}
