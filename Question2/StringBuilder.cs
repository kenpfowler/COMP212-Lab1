using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//•	Implement an extension method named numOfWords for class StringBuilder to count the number of words contained in a StringBuilder object.
//•	For example, if a StringBuilder object sb = “This is a good book”, the number of words contained in sb is 5.

namespace _301155972_Fowler_Lab1.Question2
{
    public static class StringExtension
    {
        public static int numOfWords(this StringBuilder sb)
        {
            return sb.ToString().Split(' ').Length;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is a good book");
            Console.WriteLine("Number of words : " + sb.numOfWords());
            Console.ReadKey();
        }
    }
}