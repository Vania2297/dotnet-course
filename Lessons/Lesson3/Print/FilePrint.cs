using System;
using System.IO;

namespace Print
{
    public class FilePrint : IPrinter
    {
        public void Print()
        {
            var path = @"c:\temp\MyTest3.txt";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                Console.WriteLine("Enter text");
                var createText = Console.ReadLine(); // "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }

            // Comment on Comment!
            // This text is always added, making the file longer over time
            // if it is not deleted.
            //string appendText = "This is extra text" + Environment.NewLine;
            //File.AppendAllText(path, appendText);

            // Open the file to read from.
            //string readText = File.ReadAllText(path);
            //Console.WriteLine(readText);
        }
    }
}