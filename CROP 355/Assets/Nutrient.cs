using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Nutrient : MonoBehaviour
{
    public InputField inputField;
    public Dropdown inputDD;
    public TextMeshProUGUI outputLabel;
    public TextMeshProUGUI outputDV;

    private string nutrientValueStr;
    private string nutrientUnitStr;

    private string nutrientOutputStr = "0";
    private string nutrientUnitOutputStr = "g";
    private string dvOutputStr = "";

    private double convertedValue;
    private double dvInt;
    private string dvSuffix = "";

    private double dailyValueG = 78;
    private double dailyValueMG = 7800;

    private string test = "test"; 
    private void Start()
    {
        inputField.GetComponentsInChildren<Text>()[1].text = "0";
        nutrientValueStr = "0";
    }

    void GetValues()
    {
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
        if (nutrientUnitStr == "g")
        {
            dvInt = Math.Round(convertedValue / dailyValueG * 100);
            dvSuffix = "%";
        }

        if (nutrientUnitStr == "mg")
        {
            dvInt = Math.Round(convertedValue / dailyValueMG * 100);
            dvSuffix = "%";
        }

    }

    void OutputValues()
    {
        nutrientOutputStr = nutrientValueStr + nutrientUnitStr;
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
