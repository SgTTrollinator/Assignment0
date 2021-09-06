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
        public void should_return_true(){
            //Arrange

            /*var input = new StringReader("2000");
            Console.SetIn(input);
            var writer = new StringWriter();
            Console.SetOut(writer);*/

            //Act 
            string actual = Program_Leap.readInput("2000");
            //String output = writer.GetStringBuilder().ToString().Trim();

            
            //Assert
            Assert.Equal("yay", actual);
        }

        [Fact]
        public void should_return_false(){

            //Arrange & Act
            string actual = Program_Leap.readInput("2001");

            //Assert
            Assert.Equal("nay", actual);
        }
    }
}
