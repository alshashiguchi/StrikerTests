using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestStriker.UnitTests
{
    public class HelloTests
    {
        [Fact]
        public void HelloManShouldBeWellFormated()
        {
            // Arrange
            var hello = new Hello("John", "Doe");

            // Act
            var helloMan = hello.HelloMan();

            //Assert
            helloMan
                .Should()
                .StartWith("Hello")
                .And
                .EndWith("!")
                .And
                .Contain("John")
                .And
                .Contain("Doe");
        }
    }
}
