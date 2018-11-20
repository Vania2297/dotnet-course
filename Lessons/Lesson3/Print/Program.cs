using System;

namespace Print
{
    public class Program
    {
        static void Main(string[] args)
        {
            var consolePrint = new ConsolePrint();
            var filePrint = new FilePrint();
            var picturePrint = new PicturePrint();

            Console.WriteLine("Which print text?\n1 - Console\n2 - File\n3 - Picture");
            var number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    consolePrint.Print();
                    break;
                case 2:
                    filePrint.Print();
                    break;
                case 3:
                    picturePrint.Print();
                    break;

                default:
                    Console.WriteLine("You enter don't right number!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
