using System;

namespace PersonLib
{
    public class Person
    {
        public string name;

        public Person(string name)
        {
            this.name = $"Person: {name}";
        }

        public void display()
        {
            System.Console.WriteLine(this.name);
        }

    }
}
