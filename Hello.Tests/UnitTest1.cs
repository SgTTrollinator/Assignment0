using System;
using Xunit;
using System.IO;
using LeapYear;
namespace Hello.Tests
{
    public class UnitTest1
    {
        [Fact]
        // Yes, this is a comment
        // Another comment
        public void Test1()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            //Act
            Program.Main(new String[0]);
            var output = writer.GetStringBuilder().ToString().Trim();
            //Assert
            Assert.Equal("Hello, sweet World!", output);
        }
        
        [Fact]
        public void is_leap_year_test(){
            //Arrange
            var input = new StringReader("2000");
            Console.SetIn(input);
            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act 
            Program_Leap.Main(new string[1]{input.ToString()});
            String output = writer.GetStringBuilder().ToString().Trim();

            
            //Assert
            Assert.Equal("yay", output);
        }
    }
}
