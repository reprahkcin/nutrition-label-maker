using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepValueZero : MonoBehaviour
{
    public void Update()
    {
        var value = gameObject.GetComponent<InputField>().text;
        if (value == "")
        {
            gameObject.GetComponent<InputField>().text = Convert.ToString(0.0);
        }
    }
}
