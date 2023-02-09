using System;

namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                TextCalculator calculator = new TextCalculator();
                Console.WriteLine(calculator.Add(args[0]));
            }
            else
            {
                Console.WriteLine("No numbers");
                Console.ReadLine();
            }


        }
    }
}
