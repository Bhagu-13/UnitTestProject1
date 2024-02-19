using System;
using NUnit.Framework;

namespace Class1.Tests
{
    public class Triangle
    {

        public static string ValidTriangle(int Side1, int Side2, int Side3)
        {
            if (Side1 > 0 && Side2 > 0 && Side3 > 0 && (Side1 + Side2 + Side3 == 180))
            {
                return "The triangle is valid.";
            }
            else
            {
                return "The triangle is invalid.";
            }
        }
    }

    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void ValidTriangle_ValidInput()
        {
            int Side1 = 50;
            int Side2 = 50;
            int Side3 = 80;

            string result = Triangle.ValidTriangle(Side1, Side2, Side3);

            Assert.AreEqual("The triangle is valid.", result);
        }

        [Test]
        public void ValidTriangle_InvalidInput()
        {
            int Side1 = 90;
            int Side2 = 90;
            int Side3 = 10;

            string result = Triangle.ValidTriangle(Side1, Side2, Side3);

            Assert.AreEqual("The triangle is invalid.", result);
        }

        [Test]
        public void ValidTriangle_InvalidInput2()
        {
            int Side1 = 70;
            int Side2 = 60;
            int Side3 = 10;

            string result = Triangle.ValidTriangle(Side1, Side2, Side3);

            Assert.AreEqual("The triangle is invalid.", result);
        }

        [Test]
        public void ValidTriangle_AllSidesZero()
        {
            int Side1 = 0;
            int Side2 = 0;
            int Side3 = 0;

            string result = Triangle.ValidTriangle(Side1, Side2, Side3);

            Assert.AreEqual("The triangle is invalid.", result);
        }

        [Test]
        public void ValidTriangle_OneSideNegative()
        {
            int Side1 = 50;
            int Side2 = 50;
            int Side3 = -80;

            string result = Triangle.ValidTriangle(Side1, Side2, Side3);

            Assert.AreEqual("The triangle is invalid.", result);
        }
    }
}
