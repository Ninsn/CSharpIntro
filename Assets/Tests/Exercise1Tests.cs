using System;

using NUnit.Framework;

using UnityEngine;
using UnityEngine.TestTools;

namespace Editor.Tests
{
    [Category("Exercise 1: Math")]
    [TestFixture]
    public static class Exercise1Tests
    {
        [TearDown]
        public static void Cleanup()
        {
            Utility.ClearLogConsole();
        }

        [Test]
        public static void Sum([Values(-10, -7, 0, 7, 10)] int a,
                               [Values(-10, -7, 0, 7, 10)] int b)
        {
            int expected = a + b;
            LogAssert.Expect(LogType.Log, expected.ToString());
            Exercise1.Add(a, b);
        }

        [TestCase(0, 0)]
        [TestCase(1, 7)]
        [TestCase(2, 14)]
        [TestCase(3, 21)]
        [TestCase(7, 7*7)]
        [TestCase(13, 13*7)]
        public static void InDogYears(int humanYears, int expected)
        {
            LogAssert.Expect(LogType.Log, expected.ToString());
            Exercise1.InDogYears(humanYears);
        }

        private const int MinHealth = 0;
        private const int MaxHealth = 100;

        [Test]
        public static void ChangeHealth([Values(0, 1, 30, 80, 100)] int currentHealth,
                                        [Values(-9999, -100, -40, 0, 5, 100, 9999)] int changeInHealth)
        {
            int expected = Math.Clamp(currentHealth + changeInHealth, MinHealth, MaxHealth);
            LogAssert.Expect(LogType.Log, expected.ToString());
            Exercise1.ChangeHealth(currentHealth, changeInHealth);
        }

        [TestCase(0, 0)]
        [TestCase(4, 1)]
        [TestCase(8, 1)]
        [TestCase(11, 2)]
        [TestCase(33, 5)]
        public static void RequiredShelves(int books, int expected)
        {
            LogAssert.Expect(LogType.Log, expected.ToString());
            Exercise1.RequiredShelves(books);
        }

        [TestCase(0, 0)]
        [TestCase(4, 4)]
        [TestCase(8, 0)]
        [TestCase(11, 3)]
        [TestCase(33, 1)]
        public static void LeftoverBooks(int books, int expected)
        {
            LogAssert.Expect(LogType.Log, expected.ToString());
            Exercise1.LeftoverBooks(books);
        }
    }
}
