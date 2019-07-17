using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUItest : MonoBehaviour
{
    private string textFieldString = "text field";

    void OnGUI()
    {
        textFieldString = GUI.TextField(new Rect(25, 25, 100, 30), textFieldString);
    }

}
