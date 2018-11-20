using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            
            Console.ReadKey();
        }

        public string GetType<T>(T item)
        {
            var type = typeof(T);

            return type.Name;
        }
    }
}
