using System;

namespace ConsoleApp1
{
    class Program
    {
        private const UInt32 param_v = 123213123;

        static void Main(string[] args)
        {
            Console.Write("Enter:");
            string name = Console.ReadLine();
            for (uint i = param_v; i < param_v+3; i++)
            {
                Console.WriteLine($"Hello {name} i is {i}");
            }
            
        }
    }
}
