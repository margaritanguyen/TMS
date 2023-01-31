using System;

namespace TMSConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string? name = Console.ReadLine();
            Console.Write("Your name is ");
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}