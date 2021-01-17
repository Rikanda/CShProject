using System;

namespace CShProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi, {name}! Today is {DateTime.Now}");
        }
    }
}
