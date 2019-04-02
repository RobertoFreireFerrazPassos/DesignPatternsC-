using System;

namespace DesignPattern
{
    class Program
    {
        static void Main()
        {
            DesignPatterns.Choose(DesignPatternsEnum.Command);
            Console.WriteLine("{0} design pattern finished.",DesignPatternsEnum.Command);
            Console.Read();
        }
    }
}