using System;

namespace DesignPattern
{
    class Program
    {
        static void Main()
        {
            DesignPatterns.Choose(DesignPatternsEnum.State);
            Console.WriteLine("Design Pattern finished.");
            Console.Read();
        }
    }
}