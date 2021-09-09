using System;

namespace MyApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a year to check if leap year");
            InputHandler();
        }

        public static void InputHandler()
        {
            string yearString = Console.ReadLine();
            try
            {
                int year = int.Parse(yearString);
                if (year >= 1582) Console.WriteLine(IsLeapYear(year) ? "yay" : "nay");
                else Console.WriteLine("Please enter a year after 1582");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter an integer");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        public static bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }
    }
}
