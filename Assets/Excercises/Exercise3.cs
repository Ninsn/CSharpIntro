/*
 * Exercises for if, else and switch statements.
 */
public static class Exercise3
{
    /*
     * Try to complete a quest where you need to deliver a certain amount of items.
     * The quest can only be completed if you have the full required amount.
     *
     * If you don't have enough items, you can't complete the quest and
     * 'newItemAmount' will be the same as the original 'itemAmount'.
     *
     * 'itemAmount' is the amount of items you currently have.
     * 'requiredAmount' is the amount of items that are required to complete the quest.
     *
     * 'itemAmount' is guaranteed to be 0 or positive.
     * 'requiredAmount' is guaranteed to be 0 or positive.
     */
    public static int TryCompleteQuest(int itemAmount, int requiredAmount)
    {
        int newItemAmount = -1;
        // ##################################################

        // TODO Set newItemAmount to the correct int value.

        // ##################################################
        return newItemAmount;
    }

    /*
     * Get a physical description of a person based on their age.
     *
     * Valid values are: Child, Teenager, and Adult.
     * A person is a Child if they are between 0 and 12 years old.
     * A person is a Teenager if they are between 13 and 17 years old.
     * A person is an Adult if they are +18 years old.
     *
     * 'age' is the age of the person in question.
     *
     * 'age' is guaranteed to be 0 or positive.
     */
    public static string GetAgeName(int age)
    {
        string ageName = "";
        // ##################################################

        // TODO Set ageName to the correct string value.

        // ##################################################
        return ageName;
    }

    /*
     * Get the name of the weekday based on the 'weekdayIndex'.
     *
     * Valid values are: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, Unknown.
     *
     * 'weekdayIndex' is the index of the weekday.
     * 0 -> Monday
     * 1 -> Tuesday
     * ...
     * 6 -> Sunday
     * Any other number -> Unknown
     *
     * 'weekdayIndex' can either be positive or negative.
     *
     * Hint: Try to use a switch case.
     */
    public static string GetWeekdayName(int weekdayIndex)
    {
        string weekdayName = "";
        // ##################################################

        // TODO Set weekdayName to the correct string value.

        // ##################################################
        return weekdayName;
    }

    /*
     * Get the name of the season based on a given month.
     *
     * Valid values for the month are:
     * January, February, March, April, May, June, July,
     * August, September, October, November, and December.
     *
     * Valid values for the season are: Spring, Summer, Fall, and Winter.
     *
     * From December to February is Winter.
     *
     * 'month' is the name of the month.
     *
     * Hint: Try to use a switch case using "fallthrough"-cases.
     */
    public static string GetSeason(string month)
    {
        string season = "";
        // ##################################################

        // TODO Set season to the correct string value.

        // ##################################################
        return season;
    }
}
