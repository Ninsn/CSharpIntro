using System;

using NUnit.Framework;

namespace Editor.Tests
{
    public static class Exercise2Tests
    {
        [Test]
        public static void CanBuyGame([Values(-10f, 0f, 30f)] float money,
                               [Values(-15f, -10f, -5f, 0f, 15f, 30f, 60f)] float price)
        {
            bool expected = money >= price;
            bool actual = Exercise2.CanBuyGame(money, price);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, false)]
        [TestCase(3, false)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(6, true)]
        public static void IsWeekend(int index, bool expected)
        {
            bool actual = Exercise2.IsWeekend(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, false)]
        [TestCase(3, false)]
        [TestCase(12, false)]
        [TestCase(13, true)]
        [TestCase(15, true)]
        [TestCase(17, true)]
        [TestCase(18, false)]
        [TestCase(19, false)]
        [TestCase(20, false)]
        [TestCase(99, false)]
        public static void IsTeenager(int age, bool expected)
        {
            bool actual = Exercise2.IsTeenager(age);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-11.3f, true)]
        [TestCase(-2f, false)]
        [TestCase(0f, false)]
        [TestCase(0.1f, false)]
        [TestCase(7.5f, false)]
        [TestCase(79.11f, true)]
        public static void IsMovingFast(float xSpeed, bool expected)
        {
            bool actual = Exercise2.IsMovingFast(xSpeed);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, -10, 10)]
        [TestCase(0, 3, 8)]
        [TestCase(-7, -3, -1)]
        [TestCase(130, -99, 99)]
        public static void MyClamp(float value, float min, float max)
        {
            float expected = Math.Clamp(value, min, max);
            float actual = Exercise2.MyClamp(value, min, max);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(1, 15)]
        [TestCase(2, 24)]
        [TestCase(3, 29)]
        [TestCase(7, 15 + 9 + 5*5)]
        [TestCase(13, 15 + 9 + 11*5)]
        public static void InDogYearsAdvanced(int humanYears, int expected)
        {
            int actual = Exercise2.InDogYearsAdvanced(humanYears);
            Assert.AreEqual(expected, actual);
        }
    }
}
