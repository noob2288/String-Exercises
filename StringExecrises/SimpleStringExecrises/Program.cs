using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStringExecrises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Blue;

            PerformReverse();

            PerformCapitalization();

            PerformIsPalindrom();

            PerformLongestCommonSubstring();

            Console.ReadLine();
        }

        private static void PerformReverse()
        {
            Console.WriteLine("\nReverse\n");
            Console.WriteLine("Enter string for reverse");
            string inputReverse = Console.ReadLine();
            Console.WriteLine($"Reversed string: \n{SimpleStringRealization.Reverse(inputReverse)}");
        }

        private static void PerformCapitalization()
        {
            Console.WriteLine("\nCapitalize\n");
            Console.WriteLine("Enter string to Capitalize Words");
            string inputCapitalize = Console.ReadLine();
            Console.WriteLine($"Result: {SimpleStringRealization.Capitalize(inputCapitalize)}");
        }

        private static void PerformIsPalindrom()
        {
            Console.WriteLine("\nIsPalindrom\n");
            Console.WriteLine("Enter a line to find out is it polindrom: ");
            string line = Console.ReadLine();
            Console.WriteLine($"Line is palindrom: {SimpleStringRealization.IsPalindrom(line)}");
        }

        private static void PerformLongestCommonSubstring()
        {
            Console.WriteLine("\nLongest Common Substring\n");
            Console.WriteLine("Enter first line");
            string first = Console.ReadLine();
            Console.WriteLine("Enter second line");
            string second = Console.ReadLine();
            Console.WriteLine($"Result: {SimpleStringRealization.LongestCommonSubstring(first, second)}");
        }
    }
}
