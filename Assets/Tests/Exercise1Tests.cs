using System;

using NUnit.Framework;

namespace Editor.Tests
{
    public static class Exercise1Tests
    {
        [Test]
        public static void Sum([Values(-10, -7, -5, -1, 0, 1, 5, 7, 10)] int a,
                               [Values(-10, -7, -5, -1, 0, 1, 5, 7, 10)] int b)
        {
            int expected = a + b;
            int actual = Exercise1.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(1, 7)]
        [TestCase(2, 14)]
        [TestCase(3, 21)]
        [TestCase(7, 7*7)]
        [TestCase(13, 13*7)]
        public static void InDogYears(int humanYears, int expected)
        {
            int actual = Exercise1.InDogYears(humanYears);
            Assert.AreEqual(expected, actual);
        }

        private const int MinHealth = 0;
        private const int MaxHealth = 100;

        [Test]
        public static void ChangeHealth([Values(0, 1, 30, 80, 100)] int currentHealth,
                                        [Values(-9999, -100, -40, 0, 5, 100, 9999)] int changeInHealth)
        {
            int expected = Math.Clamp(currentHealth + changeInHealth, MinHealth, MaxHealth);
            int actual = Exercise1.ChangeHealth(currentHealth, changeInHealth);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(4, 1)]
        [TestCase(8, 1)]
        [TestCase(11, 2)]
        [TestCase(33, 5)]
        public static void RequiredShelves(int books, int expected)
        {
            int result = Exercise1.RequiredShelves(books);
            Assert.AreEqual(expected, result);
        }

        [TestCase(0, 0)]
        [TestCase(4, 4)]
        [TestCase(8, 0)]
        [TestCase(11, 3)]
        [TestCase(33, 1)]
        public static void LeftoverBooks(int books, int expected)
        {
            int actual = Exercise1.LeftoverBooks(books);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void IsEven([Values(-5, 0, 1, 2, 4, 7, 13, 18)] int value)
        {
            bool expected = value % 2 == 0;
            bool actual = Exercise1.IsEven(value);
            Assert.AreEqual(expected, actual);
        }

    }
}
