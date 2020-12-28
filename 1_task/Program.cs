using System;

namespace _1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "";
            Console.Write("Input: ");
            word = Console.ReadLine();

            Console.Write("Output: ");
            Console.WriteLine($"{word[0]}{word}{word[0]}");
        }
    }
}
