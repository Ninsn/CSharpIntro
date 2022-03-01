using System.Collections;
using System.Collections.Generic;

using UnityEditor;

using UnityEngine;

[CustomEditor(typeof(Exercise5ChristmasTree))]
public class Exercise5ChristmasTreeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUILayout.Space(10);

        if (GUILayout.Button("Print Christmas Tree"))
        {
            var go = target as Exercise5ChristmasTree;
            go.PrintChristmasTree();
        }
    }
}
