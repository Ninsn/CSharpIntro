using NUnit.Framework;

namespace Editor.Tests
{
    public static class Exercise3Tests
    {
        [Test]
        public static void TryCompleteQuest([Values(0, 3, 7, 999)] int itemAmount,
                                         [Values(0, 1, 3, 5, 7, 19, 100, 1000)] int requiredAmount)
        {
            int expected = itemAmount >= requiredAmount ? itemAmount - requiredAmount : itemAmount;
            int actual = Exercise3.TryCompleteQuest(itemAmount, requiredAmount);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, "Child")]
        [TestCase(5, "Child")]
        [TestCase(12, "Child")]
        [TestCase(13, "Teenager")]
        [TestCase(16, "Teenager")]
        [TestCase(17, "Teenager")]
        [TestCase(18, "Adult")]
        [TestCase(20, "Adult")]
        [TestCase(50, "Adult")]
        public static void GetAgeName(int age, string expected)
        {
            string actual = Exercise3.GetAgeName(age);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, "Monday")]
        [TestCase(1, "Tuesday")]
        [TestCase(2, "Wednesday")]
        [TestCase(3, "Thursday")]
        [TestCase(4, "Friday")]
        [TestCase(5, "Saturday")]
        [TestCase(6, "Sunday")]

        [TestCase(-3, "Unknown")]
        [TestCase(7, "Unknown")]
        [TestCase(1000, "Unknown")]
        public static void GetWeekdayName(int index, string expected)
        {
            string actual = Exercise3.GetWeekdayName(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("January", "Winter")]
        [TestCase("February", "Winter")]
        [TestCase("March", "Spring")]
        [TestCase("April", "Spring")]
        [TestCase("May", "Spring")]
        [TestCase("June", "Summer")]
        [TestCase("July", "Summer")]
        [TestCase("August", "Summer")]
        [TestCase("September", "Fall")]
        [TestCase("October", "Fall")]
        [TestCase("November", "Fall")]
        [TestCase("December", "Winter")]
        public static void GetSeason(string month, string expected)
        {
            string actual = Exercise3.GetSeason(month);
            Assert.AreEqual(expected, actual);
        }
    }
}
