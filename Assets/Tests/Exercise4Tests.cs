using NUnit.Framework;

namespace Editor.Tests
{
    public static class Exercise4Tests
    {
        private const string DefaultGreeting = "Hello friend.";

        [TestCase("Cats", "Cool Cats")]
        [TestCase("Game", "Cool Game")]
        public static void MakeCool(string thing, string expected)
        {
            string actual = Exercise4.MakeCool(thing);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Marten", "Hello Marten.")]
        [TestCase("Dora", "Hello Dora.")]
        [TestCase("Penelope", "Hello Penelope.")]
        [TestCase("", DefaultGreeting)]
        [TestCase(null, DefaultGreeting)]
        public static void Greet(string name, string expected)
        {
            string actual = Exercise4.Greet(name);
            Assert.AreEqual(expected, actual);
        }
    }
}
