using System;

namespace Lesson1_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello ");
            Console.Write("World ");
            Console.Write("!!! ");
            Console.WriteLine();
            Console.WriteLine("Нажмите 'Enter' для завершения");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter);
        }
    }
}
