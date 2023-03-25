using System;

namespace Classroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hardcodes names
            string[] firstnames = { "Jack", "Mike", "Sam", "Kyle", "Ryan" };
            string[] lastnames = { "Hill", "Toppy", "Johnson", "Sloan", "Jackie" };

            // Classroom size of students is 5
            Student[] classroom = new Student[5];

            // Registering Students in the classroom
            for (int i = 0; i < classroom.Length; i++)
            {
                classroom[i] = new Student($"{firstnames[i]}", $"{lastnames[i]}", i * 25);
                Console.WriteLine($"{firstnames[i]} is now registered in the classroom");
            }



            Console.WriteLine("\nWelcome to the Classroom, Introduce yourselves:");
           
            // Each student in the classroom introduces themselves
            foreach (Student student in classroom)
            {
                Console.WriteLine(student.Intro());
            }

            Console.Read();
        }
    }
}
