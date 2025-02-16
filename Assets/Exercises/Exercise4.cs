﻿using System;

using UnityEditor.Experimental.GraphView;

using UnityEngine;

/// <summary>
/// Exercises for string manipulation
/// </summary>
public static class Exercise4
{
    /*
     * Make things cool by adding "Cool" to the front of the string.
     * E.g. Cats -> Cool Cats
     *
     * 'thing' is a string of the thing.
     *
     * 'thing' is guaranteed to be not null and not be empty.
     *
     * Hint: Don't forget a space between the two words.
     */
    public static void MakeCool(string thing)
    {
        
        // TODO Debug.Log() the cool thing.
        string msg = $"Cool {thing}";
        Debug.Log(msg);

    }

    /*
     * Create a custom greeting based on a name.
     *
     * If a name is given, say: "Hello <name>.".
     * Otherwise (string is empty or null), say: "Hello friend.".
     *
     * 'name' of the person.
     *
     * 'name' can contain a name, be empty ("") or be null.
     *
     * Hint: You need to check separately if 'name' is empty or null.
     * Hint: There are multiple ways to create the required string. Try using string interpolation.
     * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
     */
    public static void Greet(string name)
    {
        
        // TODO Debug.Log() the greeting.
        string greeting;

        if (name != null && name != "")
        {
            greeting = $"Hello {name}.";
        }
        else
        {
            greeting = "Hello friend.";
            
        }
        Debug.Log(greeting);
        
    }
}
