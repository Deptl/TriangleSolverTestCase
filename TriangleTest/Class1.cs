using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace TriangleTest
{
    [TestFixture]
    public class TriangleTestClass
    {
        [Test]
        public static void EquilateralTriangle_Input10and10and10_OutputEquilateralTriangle()
        {
            //Arrange
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 10;

            string expected = "Equilateral triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide); 

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
