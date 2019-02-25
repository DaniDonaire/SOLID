using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    public class Student
    {
        public Guid GuidStudent { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student()
        {
            GuidStudent = new Guid();
        }

        public Student(string name, string surname)
        {
            GuidStudent = new Guid();
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", this.GuidStudent, this.Name, this.Surname);
        }
    }
}
