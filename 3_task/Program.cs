using System;

namespace _3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text: ");
            var textToReverse = Console.ReadLine();

            Console.WriteLine(Reverse(textToReverse));
        }

        public static string Reverse(string textToReverse)
        {
            char[] charArray = textToReverse.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
