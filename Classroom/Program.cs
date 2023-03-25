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

            // Putting Sutdents in the classroom
            for (int i = 0; i < classroom.Length; i++)
            {
                classroom[i] = new Student($"{firstnames[i]}", $"{lastnames[i]}", i * 15);
            }



            Console.WriteLine("Welcome to the Classroom, Introduce yourselves:");
            foreach (Student student in classroom)
            {
                Console.WriteLine(student.Intro());
            }


        }
    }
}
