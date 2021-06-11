using System;

class MainProgram {
    public static void Main(string[] args) {
        string input = "10";
        input = Console.ReadLine();
        ulong number = ulong.Parse(input);
        if (number % 2 != 0) number++;
        ulong n = number/2;
        ulong sum = n*n;
        Console.WriteLine(sum);
    }
}