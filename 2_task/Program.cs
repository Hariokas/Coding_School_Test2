using System;

namespace _2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of the month: ");
            var month = Int32.Parse(Console.ReadLine());
            DateTime printMonth = new DateTime(DateTime.Now.Year, month, DateTime.Now.Day);

            Console.WriteLine($"The '{month}' month is: {printMonth.ToString("MMMM")}");

        }
    }
}
