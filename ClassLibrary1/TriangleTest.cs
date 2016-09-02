using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDemo.Models;
using NUnit.Framework;

namespace CIDemo.Tests
{
    [TestFixture]
    public class TriangleTest
    {
        private IShapeCalculate ShapeCalculator;

        [SetUp]
        public void Setup()
        {
            ShapeCalculator = new Triangle();
        }
        [TestCase(4,8)]
        [TestCase(2,4)]
        public void TriangleCalculation_WithPositiveValue_ShouldCalculate(int width, int height)
        {
            //Arrange
           

            //Act
            var actual = ShapeCalculator.CalculateSurface(width, height);

            //Assert
            Assert.AreEqual(4, actual);
        }

      
        
    }
}



