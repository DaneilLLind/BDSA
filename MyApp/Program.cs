using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return year % 4 == 0;
        }
    }
}
