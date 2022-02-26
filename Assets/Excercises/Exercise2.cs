/*
 * Bool exercises that require comparing numbers.
 */
public static class Exercise2
{
    /*
     * Check if you can buy a game by comparing your money with the price of the game.
     *
     * 'money' is the money you have.
     * 'price' is the price of the game you want to buy.
     */
    public static bool CanBuyGame(float money, float price)
    {
        bool canBuy = false;
        // ##################################################

        // TODO Set canBuy to the correct bool value.

        // ##################################################
        return canBuy;
    }

    /*
     * Check if a weekday is part of the weekend.
     *
     * 'weekdayIndex' is a number between 0 and 6.
     *   0 -> Monday
     *   1 -> Tuesday
     *   ...
     *   6 -> Sunday
     */
    public static bool IsWeekend(int weekdayIndex)
    {
        bool weekend = false;
        // ##################################################

        // TODO Set weekend to the correct bool value.

        // ##################################################
        return weekend;
    }

    /*
     * Check if a person is considered to be a teenager.
     *
     * Teenagers are people between the age of 13 and 17.
     *
     * 'age' is the age in years of the person.
     */
    public static bool IsTeenager(int age)
    {
        bool teenager = false;
        // ##################################################

        // TODO Set teenager to the correct bool value.

        // ##################################################
        return teenager;
    }

    /*
     * Check if a GameObject is moving fast along the x-axis.
     *
     * A GameObject is considered to be moving "fast" if it moves with a speed of at least 10.0f.
     *
     * 'xSpeed' is the speed of the GameObject along the x-axis.
     * - A negative values means it moves to the left.
     * - A positive values means it moves to the right.
     */
    public static bool IsMovingFast(float xSpeed)
    {
        bool fast = false;
        // ##################################################

        // TODO Set fast to the correct bool value.

        // ##################################################
        return fast;
    }

    /*
     * Create your own Clamp. It limits a value to be between a minimum and a maximum value.
     *
     * 'number' is the original value that needs to be possibly clamped.
     * 'min' is the minimum value that 'number' is allowed to be.
     * 'max' is the maximum value that 'number' is allowed to be,
     *
     * Take a look at the Unity documentation for Mathf.Clamp() if you are unsure:
     * https://docs.unity3d.com/ScriptReference/Mathf.Clamp.html
     *
     * DO NOT actually use Math.Clamp() or Mathf.Clamp() but implement your own version.
     */
    public static float MyClamp(float number, float min, float max)
    {
        float newNumber = -1;
        // ##################################################

        // TODO Set newNumber to the correct float value.

        // ##################################################
        return newNumber;
    }

    /*
     * Convert human years into dog years (more accurately).
     *
     * The first human year equals 15 dog years.
     * The second human year equals 9 dog years.
     * Every additional human year equals 5 dog years.
     *
     * 'humanYears' is guaranteed to be 0 or positive.
     */
    public static int InDogYearsAdvanced(int humanYears)
    {
        int dogYears = -1;
        // ##################################################

        // TODO Set dogYears to the correct int value.

        // ##################################################
        return dogYears;
    }
}
