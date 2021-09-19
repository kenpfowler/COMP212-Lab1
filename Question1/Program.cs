using System;

// •	Implement a generic method, search, that searches the specified element within an array using linear search algorithm.
// •	Method search should compare the search key (its first parameter) with each element in its array parameter (its second parameter) until the search key is found or until the end of the array is reached. If the search key is found, return its location in the array; otherwise return -1.
// •	Write a Console app with command-line textual menu that accepts user’s input for five array elements and searches the specified element.
// •	Your app should work for an array of integers. It should also work for an array of Student objects. The Student class should have only one instance variable name of type string.
// •	Every Student object should have unique name. The command-line textual menu should have separate options to allow a user to input the integers for the integer array, and to input the names for the Student objects array.
// •	The menu should also have separate options to search integer array for a given integer, and to search Student objects array for a given Student name.
// •	The app should be able to display all array elements to help user perform search functionality. You must use interface IComparable<T> in the “where” constraint of the method search and use the method CompareTo to compare the search key to the elements in the array.

namespace _301155972_Fowler_Lab1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //setup control variables and create a new manager
            int active = 1;
            int selection;
            SearchManager manager = new();

            //call promps with a while loop
            while (active == 1)
            {
                Console.WriteLine("========================================================");
                Console.WriteLine("Welcome to the list program.  Here are your options:    ");
                Console.WriteLine("                   CREATE A LIST                        ");
                Console.WriteLine("1. Press 1 to create a list of students                 ");
                Console.WriteLine("2. Press 2 to create a list of integers                 ");
                Console.WriteLine("                   SEARCH A LIST                        ");
                Console.WriteLine("3. Press 3 to search a list of students                 ");
                Console.WriteLine("4. Press 4 to search a list of integers                 ");
                selection = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Enter the name of 5 students you would like to add to your list: ");
                        for (int i = 0; i < 5; i++)
                        {
                            string name = Console.ReadLine();
                            manager.AddStudent(name);
                        }
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Enter 5 integers you would like to add to your list: ");
                        for (int i = 0; i < 5; i++)
                        {
                            int integer = Convert.ToInt32(Console.ReadLine());
                            manager.AddInteger(integer);
                        }
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Enter the name of the student you would like to search for: ");
                        string nameToSearchFor = Console.ReadLine();
                        Student searchForStudent = new Student(nameToSearchFor);
                        int position = SearchManager.Search(searchForStudent, manager.GetStudentsList());
                        if (position != -1)
                        {
                            Console.WriteLine($"Your student was position: {position + 1} in the list!");
                        }
                        else
                        {
                            Console.WriteLine($"Your search was not found!");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter the integer you would like to search for:             ");
                        int searchForInt = Convert.ToInt32(Console.ReadLine());
                        int position2 = SearchManager.Search(searchForInt, manager.GetIntegersList());
                        if (position2 != -1)
                        {
                            Console.WriteLine($"Your integer was position: {position2 + 1} in the list!");
                        }
                        else
                        {
                            Console.WriteLine($"Your search was not found!");
                        }
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }

                Console.WriteLine("Here are your lists...");
                manager.PrintLists();
                Console.WriteLine("Press 1 to continue...");
                Console.WriteLine("Press 0 to quit...");
                active = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}