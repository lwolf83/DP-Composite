using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("J");

            Person p2 = new Person("JC1");
            Person p3 = new Person("JC2");
            Person p4 = new Person("JC3");
            p1.Descendants.Add(p2);
            p1.Descendants.Add(p3);
            p1.Descendants.Add(p4);
            Person p5 = new Person("JC1C1");
            p2.Descendants.Add(p5);
            Person p6 = new Person("JC1C2");
            p2.Descendants.Add(p6);
            Person p7 = new Person("JC2C1");
            p3.Descendants.Add(p7);

            string descendants = p1.ToString();
            Console.WriteLine(descendants);

        }
    }
}
