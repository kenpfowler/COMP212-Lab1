using System;
using System.Collections.Generic;

namespace _301155972_Fowler_Lab1
{
    internal class SearchManager
    {
        // accept input for a list of 5 element
        // **can be integers or student objects** //

        private List<Student> studentsList;
        private List<int> integersList;

        //constructor
        public SearchManager()
        {
            studentsList = new List<Student>();
            integersList = new List<int>();
        }

        //getters and setters
        public List<Student> GetStudentsList()
        {
            return studentsList;
        }

        public List<int> GetIntegersList()
        {
            return integersList;
        }

        //add a student to the students list
        public void AddStudent(string name)
        {
            studentsList.Add(new Student(name));
        }

        //add an integer to the integer list
        public void AddInteger(int number)
        {
            integersList.Add(number);
        }

        //generic method to search lists
        public static int Search<T>(object searchTerm, List<T> list) where T : IComparable<T>
        {
            //loop over the list to be searched
            for (int i = 0; i < list.Count; i++)
            {
                //if the search term is found then return it's index in the array
                if (list[i].CompareTo((T?)searchTerm) == 0)
                {
                    return i;
                }
            }
            // if its not found return -1
            return -1;
        }

        //display all lists and their elements
        public void PrintLists()
        {
            Console.WriteLine("================ INTEGERS LIST =====================");
            this.GetIntegersList().ForEach(num => Console.Write($"{num} "));
            Console.WriteLine();
            Console.WriteLine("================ STUDENTS LIST =====================");
            this.GetStudentsList().ForEach(student => Console.Write($"{student.Name} "));
            Console.WriteLine();
        }

        public void PrintStudentList()
        {
            Console.WriteLine("================ STUDENTS LIST =====================");
            this.GetStudentsList().ForEach(student => Console.Write($"{student.Name} "));
        }

        public void PrintIntList()
        {
            Console.WriteLine("================ INTEGERS LIST =====================");
            this.GetIntegersList().ForEach(num => Console.Write($"{num} "));
        }
    }
}