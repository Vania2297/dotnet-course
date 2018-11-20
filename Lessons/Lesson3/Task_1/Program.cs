using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static List<Student> _students = new List<Student>();

        public static void Main(string[] args)
        {
            var student1 = new Student() { Name = "Ivan" };
            var student2 = new Student() { Name = "Ivan" };
            _students.Add(student1);
            _students.Add(student2);
            for (var i = 0; i < 100; i++)
            {
                _students.Add(new Student() { Name = i.ToString() });
            }
            foreach (var student in _students)
            {
                Console.WriteLine($"{student.Id}:{student.Name}");
            }

            Console.ReadKey();
        }

        public class Student
        {
            public int Id { get; private set; }
            public string Name { get; set; }
            private static int NextId { get; set; }

            static Student()
            {
                if (true)
                {
                    NextId = 1000000;
                }
                else
                {
                    NextId = 0;
                }
            }

            public Student()
            {
                Id = NextId;
                NextId++;
            }
        }
    }
}
