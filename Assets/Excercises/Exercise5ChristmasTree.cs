using System;
using UnityEngine;

public class Exercise5ChristmasTree : MonoBehaviour
{
    [Range(1, 50)]
    public int size = 1;

    public void PrintChristmasTree()
    {
        string newline = "\n";
        string tree = $"Tree ({size}):" + newline;
        // ##################################################

        // TODO Set tree to the correct string value.

        // ##################################################
        Debug.Log(tree);
    }
}
