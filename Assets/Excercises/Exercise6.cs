using System.Collections.Generic;

using UnityEngine;

/// <summary>
///  Exercises for lists
/// </summary>
public static class Exercise6
{
    /*
     * Print out all names in the list separately.
     *
     * Hint: You can access names.Count to know how many elements are in the list.
     */
    public static void PrintNames(List<string> names)
    {

        // TODO Debug.Log() the names separately.

    }

   /*
    * Filter a list of names by a given prefix.
    * All names that do not start with the defined 'prefix' should be removed from the list.
    *
    * DO NOT make a new list but use names.RemoveAt(<index>)
    *
    * 'prefix' may be null or empty in which case nothing should happen.
    *
    * Hint: Be careful with using names.RemoveAt() while using loops!
    * Hint: Use <string>.StartsWith() to check the prefix:
    * https://docs.microsoft.com/en-us/dotnet/api/system.string.startswith?view=net-6.0#system-string-startswith(system-string)
    */
    public static List<string> FilterNamesByPrefix(List<string> names, string prefix)
    {

        // TODO Return a filtered list

        return null;
    }

    /*
     * Take a list of numbers and return a new list with their order reversed.
     *
     * Hint: Notice the return type of the function.
     * Hint: Create a new list.
     */
    public static List<int> Reverse(List<int> numbers)
    {

        // TODO Return the numbers reversed.

        return null;
    }


}
