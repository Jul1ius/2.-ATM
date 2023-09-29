using System;

namespace _2._ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = int.Parse(Console.ReadLine());
            int with = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            if (with > limit)
                Console.WriteLine("The limit was exceeded.");

            else if (with > balance)
                Console.WriteLine("Insufficient availability.");

            else
                Console.WriteLine("The withdraw was successful.");
        }
    }
}
