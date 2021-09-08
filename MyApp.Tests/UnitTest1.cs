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
            var actual = Program.IsLeapYear(4);
            Assert.Equal(expected,actual);

            expected = false;
            actual = Program.IsLeapYear(277);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void LeapYearNotEveryHundrethYear()
        {
            var expected = false;
            var actual = Program.IsLeapYear(100);
            Assert.Equal(expected,actual);

            expected = true;
            actual = Program.IsLeapYear(160);
            Assert.Equal(expected,actual);
        }
        
        [Fact]
        public void LeapYearEveryFourHundrethYearAnyway()
        {
            var expected = true;
            var actual = Program.IsLeapYear(400);
            Assert.Equal(expected,actual);
            for (int i = 1; i < 100; i++)
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
    }
}
