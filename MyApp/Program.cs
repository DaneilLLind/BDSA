using System;

namespace MyApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a year to check if leap year");
            string yearString = Console.ReadLine();
            int year = int.Parse(yearString);
            Console.WriteLine(IsLeapYear(year) ? "yay" : "nay");
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return year % 4 == 0;
        }
    }
}
