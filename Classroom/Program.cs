using System;

namespace Classroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student  = new Student("Myles", "Megaffin", 144);
            Student student1 = new Student("Jake", "Water", -20);
            Student student2 = new Student("Kevin", "Ketchup", 83);

            Console.WriteLine("Welcome to the Classroom, Introduce yourselves:");
            Console.WriteLine(student.Intro());
            Console.WriteLine(student1.Intro());
            Console.WriteLine(student2.Intro());

        }
    }
}
