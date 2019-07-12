using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class AddedSugars : MonoBehaviour
{
    public InputField inputField;
    public Dropdown inputDD;
    public TextMeshProUGUI outputLabel;
    public TextMeshProUGUI outputDV;
    public InputField totalSugar;
    public Dropdown totalSugarDD;

    private string nutrientValueStr;
    private string nutrientUnitStr;

    private string nutrientOutputStr = "0";
    private string nutrientUnitOutputStr = "g";
    private string dvOutputStr = "";

    private double convertedValue;
    private double dvInt;
    private string dvSuffix = "";

    private double totalSugars;

    public double dailyValueG;
    private double dailyValueMG;

    private string test = "test";
    private void Start()
    {
        inputField.GetComponentsInChildren<Text>()[1].text = "0";
        nutrientValueStr = "0";
        dailyValueMG = dailyValueG * 1000;
    }

    void GetValues()
    {
        if (totalSugar.GetComponentsInChildren<Text>()[1].text == "")
        {
            totalSugar.GetComponent<TextMeshProUGUI>().color = Color.red;
        }
        else
        {
            totalSugars = Convert.ToDouble(totalSugar.GetComponentsInChildren<Text>()[1].text);
        }

        if (inputField.GetComponentsInChildren<Text>()[1].text == "")
        {
            gameObject.GetComponent<TextMeshProUGUI>().color = Color.red;
        }
        else
        {
            nutrientValueStr = inputField.GetComponentsInChildren<Text>()[1].text;
            gameObject.GetComponent<TextMeshProUGUI>().color = Color.white;
        }

        if (nutrientValueStr != null)
        {
            convertedValue = Convert.ToDouble(nutrientValueStr);
        }
        nutrientUnitStr = inputDD.GetComponentInChildren<Text>().text;
    }

    void DoCalculations()
    {
        if (totalSugarDD.GetComponentInChildren<Text>().text == "g")
        {
            dvInt = Math.Round(totalSugars / dailyValueG * 100);
            dvSuffix = "%";
        }

        if (totalSugarDD.GetComponentInChildren<Text>().text == "mg")
        {
            dvInt = Math.Round(totalSugars / dailyValueMG * 100);
            dvSuffix = "%";
        }

    }

    void OutputValues()
    {
        nutrientOutputStr = nutrientValueStr + nutrientUnitStr + " of added sugar";
        outputLabel.GetComponentInChildren<TextMeshProUGUI>().text = nutrientOutputStr;
        dvOutputStr = dvInt + dvSuffix;
        if (outputDV != null)
        {
            outputDV.GetComponentInChildren<TextMeshProUGUI>().text = dvOutputStr;
        }
    }

    public void Button()
    {
        GetValues();
        DoCalculations();
        OutputValues();
    }
}
