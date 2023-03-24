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
            Console.WriteLine($"Hello I'm {student.Firstname} {student.Lastname} and I have a {student.GetGrade()} in this class");
            Console.WriteLine($"Hello I'm {student1.Firstname} {student1.Lastname} and I have a {student1.GetGrade()} in this class");
            Console.WriteLine($"Hello I'm {student2.Firstname} {student2.Lastname} and I have a {student2.GetGrade()} in this class");

        }
    }
}
