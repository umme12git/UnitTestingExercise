using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]

        [InlineData(4,20,8,32)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
             UnitTestMethods aTest = new UnitTestMethods();


            //Act
            var actual = aTest.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(23, 14, 9)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            var aTest = new UnitTestMethods();

            //Act
            var actual = aTest.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10,10,100)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var aTest = new UnitTestMethods();

            //Act
            var actual = aTest.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(40,5,8)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var aTest = new UnitTestMethods();


            //Act
            var actual = aTest.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);


        }

        [Fact]
        public void FindAreaSquareTest()
        {
            //Arrange
            var aTest = new UnitTestMethods();
            int  side1 = 10;
            int side2 = 10;
            //Act

            var actual = aTest.CanFindAreaSquare(side1, side2);


            //Assert
            Assert.Equal(100, actual);

        }

        [Fact]
        public void FindMaxTest()
        {
            //Arrange
            var aTest = new UnitTestMethods();
            int num1 = 27;
            int num2 = 78;

            //Act
            var actual = aTest.CanFindMax(num1, num2);
            //Assert
            Assert.Equal(78, actual);
        }
    }
}
