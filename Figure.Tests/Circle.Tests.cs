using System;
using NUnit.Framework;

namespace Figure.Tests
{
    public class CircleTests
    {

        [Test]
        public void CalculateArea()
        {
            //arrange
            double radius = 5;
            double expected = Math.PI * radius * radius;

            //act
            Circle c = new Circle(radius);
            double actual = c.Area();

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}