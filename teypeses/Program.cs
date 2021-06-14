using System;

namespace teypeses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start..");
            long gigasecond = 1000000000;
            DateTime d1 = new DateTime();
            Console.WriteLine(d1);
            d1 = d1.AddSeconds(gigasecond);
            Console.WriteLine(d1);
        }
    }
}
