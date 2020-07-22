using System;
using NUnit.Framework;

namespace Figure.Tests
{
    public class TriangleTests
    {

        [Test]
        public void CalculateArea()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            //act
            Triangle t = new Triangle(a, b, c);
            double actual = t.Area();

            //assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void CheckCheckingForSquareness()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;

            //act
            Triangle t = new Triangle(a, b, c);
            bool actual = t.is_rectangular();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}