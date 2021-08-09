using System;
using PersonLib;

namespace ConsoleApp1
{
    class Program
    {
        private const UInt32 param_v = 123213123;

        static void Main(string[] args)
        {
            Console.Write("Enter name:");
            string name = "sss";
            name = Console.ReadLine();
            for (uint i = param_v; i < param_v+3; i++)
            {
                Console.WriteLine($"Hello {name} i is {i}");
            }
            Person p = new Person("violan");
            p.display();
            Console.WriteLine(123.MakeMore());
        }
    }

public  static class IntegerExtension
{
    public static int MakeMore(this int x)
    {
        var anon = new {name = "abc"};
        return 1 + x;
    }
}

}
