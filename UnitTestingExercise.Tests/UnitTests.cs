using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData(23, 14, 9)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData(10,10,100)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange

            //Act
            
            //Assert

        }

        [Theory]
        [InlineData(40,5,8)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
