using NUnit.Framework;

using UnityEngine;
using UnityEngine.TestTools;

namespace Editor.Tests
{
    [Category("Exercise 5: Loops")]
    [TestFixture]
    public static class Exercise5Tests
    {
        [TearDown]
        public static void Cleanup()
        {
            Utility.ClearLogConsole();
        }

        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(4, 24)]
        [TestCase(5, 120)]
        [TestCase(6, 720)]
        [TestCase(7, 5040)]
        [TestCase(8, 40320)]
        [TestCase(9, 362880)]
        [TestCase(10, 3628800)]
        public static void Factorial(int number, int expected)
        {
            LogAssert.Expect(LogType.Log, expected.ToString());
            Exercise5.Factorial(number);
        }

        [TestCase(0, "A")]
        [TestCase(1, "AH")]
        [TestCase(3, "AHHH")]
        [TestCase(10, "AHHHHHHHHHH")]
        public static void Shout(int length, string expected)
        {
            LogAssert.Expect(LogType.Log, expected);
            Exercise5.Shout(length);
        }

        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(6, false)]
        [TestCase(7, true)]
        [TestCase(8, false)]
        [TestCase(9, false)]
        [TestCase(10, false)]
        [TestCase(11, true)]
        [TestCase(133, false)]
        [TestCase(137, true)]
        public static void IsPrime(int number, bool expected)
        {
            LogAssert.Expect(LogType.Log, expected.ToString());
            Exercise5.IsPrime(number);
        }
    }
}
