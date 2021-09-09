using System;
using System.IO;
using Xunit;

namespace MyApp.Tests
{
    
    public class UnitTest1
    {
        [Fact]
        public void LeapYearEveryFourthYear()
        {
            var expected = true;
            var actual = Program.IsLeapYear(2004);
            Assert.Equal(expected,actual);

            expected = false;
            actual = Program.IsLeapYear(2277);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void LeapYearNotEveryHundrethYear()
        {
            var expected = false;
            var actual = Program.IsLeapYear(1000);
            Assert.Equal(expected,actual);

            expected = true;
            actual = Program.IsLeapYear(1600);
            Assert.Equal(expected,actual);
        }
        
        [Fact]
        public void LeapYearEveryFourHundrethYearAnyway()
        {
            var expected = true;
            var actual = Program.IsLeapYear(400);
            Assert.Equal(expected,actual);
            for (int i = 4; i < 100; i++)
            {
                actual = Program.IsLeapYear(i*400);
                Assert.Equal(expected,actual);
            }

            expected = false;
            actual = Program.IsLeapYear(500);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void UserInputTestLeapYearFunction()
        {
            var input = new StringReader("2022");
            Console.SetIn(input);
            
            var output = new StringWriter();
            Console.SetOut(output);

            Program.Main();

            var actual = output.ToString();

            var expected = "nay";
            Assert.Contains(expected,actual);

        }

        [Fact]
        public void InvalidUserInput()
        {
            Console.SetIn(new StringReader("invalid input"));
            var output = new StringWriter();
            Console.SetOut(output);
            Program.Main();
            var actual = output.ToString();
            var expected = "Please enter an integer";
            Assert.Contains(expected,actual);
        }

        [Fact]
        public void ToEarlyYear()
        {
            Console.SetIn(new StringReader("100"));
            var output = new StringWriter();
            Console.SetOut(output);
            Program.Main();
            var actual = output.ToString();
            var expected = "Please enter a year after 1582";
            Assert.Contains(expected,actual);
        }
    }
}