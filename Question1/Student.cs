using System;

namespace _301155972_Fowler_Lab1
{
    internal class Student : IComparable<Student>
    {
        public string Name { get; set; }

        public Student(string name)

        {
            Name = name;
        }

        public int CompareTo(Student other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}