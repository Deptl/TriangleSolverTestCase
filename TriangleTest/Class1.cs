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

        [Test]
        public static void ScaleneTriangle_Input15and19and30_OutputScaleneTriangle()
        {
            //Arrange
            int firstSide = 15;
            int secondSide = 19;
            int thirdSide = 30;

            string expected = "Scalene triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public static void ScaleneTriangle_Input5and18and16_OutputScaleneTriangle()
        {
            //Arrange
            int firstSide = 5;
            int secondSide = 18;
            int thirdSide = 16;

            string expected = "Scalene triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public static void ScaleneTriangle_Input30and40and50_OutputScaleneTriangle()
        {
            //Arrange
            int firstSide = 30;
            int secondSide = 40;
            int thirdSide = 50;

            string expected = "Scalene triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public static void ScaleneTriangle_Input14and27and19_OutputScaleneTriangle()
        {
            //Arrange
            int firstSide = 14;
            int secondSide = 27;
            int thirdSide = 19;

            string expected = "Scalene triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public static void ScaleneTriangle_Input16and33and25_OutputScaleneTriangle()
        {
            //Arrange
            int firstSide = 16;
            int secondSide = 33;
            int thirdSide = 25;

            string expected = "Scalene triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public static void IsoscelesTriangle_Input25and25and12_OutputIsoscelesTriangle()
        {
            //Arrange
            int firstSide = 25;
            int secondSide = 25;
            int thirdSide = 12;

            string expected = "Isosceles triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public static void IsoscelesTriangle_Input18and29and29_OutputIsoscelesTriangle()
        {
            //Arrange
            int firstSide = 18;
            int secondSide = 29;
            int thirdSide = 29;

            string expected = "Isosceles triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public static void IsoscelesTriangle_Input45and33and45_OutputIsoscelesTriangle()
        {
            //Arrange
            int firstSide = 45;
            int secondSide = 33;
            int thirdSide = 45;

            string expected = "Isosceles triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public static void ZeroInputTriangle_Input0and12and18_OutputZeroInputTriangle()
        {
            //Arrange
            int firstSide = 0;
            int secondSide = 12;
            int thirdSide = 18;

            string expected = "Invalid Triangle - a zero has been detected";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public static void ZeroInputTriangle_Input0and0and26_OutputZeroInputTriangle()
        {
            //Arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 26;

            string expected = "Invalid Triangle - a zero has been detected";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public static void ZeroInputTriangle_Input0and0and0_OutputZeroInputTriangle()
        {
            //Arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 0;

            string expected = "Invalid Triangle - a zero has been detected";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
