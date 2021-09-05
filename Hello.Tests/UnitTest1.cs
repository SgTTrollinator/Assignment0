using System;
using Xunit;
using System.IO;
namespace Hello.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            //Act
            Program.Main(new String[0]);
            var output = writer.GetStringBuilder().ToString().Trim();
            //Assert
            Assert.Equal("Hello, World!", output);
        }
    }
}
