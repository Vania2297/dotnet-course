using System;

namespace Print
{
    public class ConsolePrint : Printer
    {
        public override void Print()
        {
            Console.WriteLine("Enter text which you want.");
            var text = Console.ReadLine();
            Console.WriteLine(text);
        }
    }
}