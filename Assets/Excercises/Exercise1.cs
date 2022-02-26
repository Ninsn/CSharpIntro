/*
 * Simple math exercises.
 */
using System;

using UnityEngine;

public static class Exercise1
{
    /*
     * Add two numbers together.
     *
     * 'a' is the first summand.
     * 'b' is the second summand.
     */
    public static int Add(int a, int b)
    {
        int sum = -1;
        // ##################################################

        // TODO Set sum to the correct int value.

        // ##################################################
        return sum;
    }

    /*
     * Convert human years into dog years.
     *
     * One human year equals seven dog years.
     *
     * 'humanYears' is guaranteed to be 0 or positive.
     */
    public static int InDogYears(int humanYears)
    {
        int dogYears = -1;
        // ##################################################

        // TODO Set dogYears to the correct int value.

        // ##################################################
        return dogYears;
    }

    /*
     * Change the current health of the player (by e.g. health potions or damage).
     *
     * The minimum allowed health of the player is 0.
     * The maximum allowed health of the player is 100.
     * You need to prevent 'newHealth' to be smaller than 0 and larger than 100.
     *
     * 'currentHealth' is the current health of the player.
     * 'changeInHealth' is the amount that the current health of the player should be changed by.
     *
     * 'currentHealth' is guaranteed to be 0 or positive.
     * 'changeInHealth' can either be positive or negative.
     */
    public static int ChangeHealth(int currentHealth, int changeInHealth)
    {
        int newHealth = -1;
        // ##################################################

        // TODO Set newHealth to the correct int value.

        // ##################################################
        return newHealth;
    }

    /*
     * You want to put all your books into shelves.
     * Each shelve can hold 8 books.
     * Calculate how many shelves you need to hold all books.
     *
     * 'books' is the amount of books.
     *
     * 'books' is guaranteed to be 0 or positive.
     *
     * Hint: Remember that 13/4 -> 3 while 13/4.0f -> 3.25f
     * Hint: Mathf.CeilToIn() might be helpful:
     * https://docs.unity3d.com/ScriptReference/Mathf.CeilToInt.html
     */
    public static int RequiredShelves(int books)
    {
        int shelveAmount = -1;
        // ##################################################

        // TODO Set shelveAmount to the correct int value.

        // ##################################################
        return shelveAmount;
    }

    /*
     * You hate empty spaces in your shelves.
     * You reconsider and decide to only buy those shelves that you can fully fill with books.     *
     * Each shelve can hold 8 books.
     * Calculate how many books will be left over after you filled all the shelves you bought with books.
     *
     * 'books' is the total amount of books.
     *
     * 'books' is guaranteed to be 0 or positive.
     *
     * Hint: % (Remainder) might be helpful
     * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#remainder-operator-
     */
    public static int LeftoverBooks(int books)
    {
        int leftoverBooks = -1;
        // ##################################################

        // TODO Set leftoverBooks to the correct int value.

        // ##################################################
        return leftoverBooks;
    }

    /*
     * Calculate if a value is an odd or even number.
     *
     * 0 is an even number.
     *
     * 'value' can either be positive or negative.
     *
     * Hint: % (Remainder) might be helpful
     * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#remainder-operator-
     */
    public static bool IsEven(int value)
    {
        bool even = false;
        // ##################################################

        // TODO Set even to the correct bool value.

        // ##################################################
        return even;
    }
}
