﻿using System;
using UnityEngine;

/// <summary>
/// Bool exercises that require comparing numbers.
/// </summary>
public static class Exercise2
{
   /*
    * Calculate if a value is an odd or even number.
    *
    * 0 is an even number.
    *
    * 'value' can either be positive or negative.
    *
    * Hint: What makes a number even? What makes a number odd? How can you check for this property?
    * Hint: % (Remainder) might be helpful
    * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#remainder-operator-
    */
    public static void IsEven(int value)
    {
        
        // TODO Debug.Log() the bool containing if even or not.
        int remainder = value % 2;
        bool even = remainder == 0;
        Debug.Log(even);

    }

    /*
     * Check if you can buy a game by comparing your money with the price of the game.
     *
     * 'money' is the money you have.
     * 'price' is the price of the game you want to buy.
     */
    public static void CanBuyGame(float money, float price)
    {
        
        // TODO Debug.Log() if you can buy the game or not.
        bool canBuy = money >= price;
        Debug.Log(canBuy);
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
    public static void IsSchoolDay(int weekdayIndex)
    {
        
        // TODO Debug.Log() if it is part of the weekend or not.
        bool weekday = weekdayIndex <= 4;
        Debug.Log(weekday);

    }

    /*
     * Check if a person is considered to be a teenager.
     *
     * Teenagers are people between the age of 13 and 17.
     *
     * 'age' is the age in years of the person.
     */
    public static void IsTeenager(int age)
    {
        
        // TODO Debug.Log() if they are a teenager.
        bool teenager = age > 12 && age < 18;
        Debug.Log(teenager);
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
    public static void IsMovingFast(float xSpeed)
    {
        
        // TODO Debug.Log() if the GameObject is moving fast.
        bool speed = xSpeed > 9.9f || xSpeed < -9.99f;
        Debug.Log(speed);

    }
}
