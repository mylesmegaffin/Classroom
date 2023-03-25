using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    internal class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        private int grade;

        public Student() 
        {
        
        }

        public Student(string firstname, string lastname)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
        }

        public Student(string firstname, string lastname, int grade)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            if(grade > 100) 
            {
                this.grade = 100;
            }
            else if(grade < 0)
            {
                this.grade = 0;
            }
            else
            {
                this.grade = grade;
            }
        }

        public int GetGrade()
        {
            return grade;
        }
        public void SetGrade(int grade)
        {
            if (grade > 100)
            {
                this.grade = 100;
            }
            else if (grade < 0)
            {
                this.grade = 0;
            }
            else
            {
                this.grade = grade;
            }
        }

        public string Intro()
        {
            return $"Hello my name is {Firstname} {Lastname} and I'm getting a {GetGrade()} in this class";
        }
    }
}
