using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour {

    public Texture2D icon;
    private string textFieldString = "text field";

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 20), new GUIContent("Click me", icon, "This is the tooltip")))
        {
            Debug.Log("11");
        }
        GUI.Label(new Rect(10, 40, 100, 20), GUI.tooltip);
        if (GUI.RepeatButton(new Rect(10, 70, 100, 20), "Repeat"))
        {
            Debug.Log("2222");
        }

        textFieldString = GUI.TextField(new Rect(10, 100, 100, 20), textFieldString);
    }
}
