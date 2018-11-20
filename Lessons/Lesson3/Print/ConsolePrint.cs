using System;

namespace Print
{
    public class ConsolePrint : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Enter text which you want.");
            var text = Console.ReadLine();
            Console.WriteLine(text);
        }
    }
}