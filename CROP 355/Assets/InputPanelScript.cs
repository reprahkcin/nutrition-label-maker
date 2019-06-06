using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InputPanelScript : MonoBehaviour
{
    public TextMeshProUGUI ServingSize;
    public TextMeshProUGUI ServingsPerContainer;
    public TextMeshProUGUI Calories;
    public TextMeshProUGUI TotalFat;
    public TextMeshProUGUI TotalFatPercentage;
    public TextMeshProUGUI SaturatedFat;
    public TextMeshProUGUI SaturatedFatPercentage;
    public TextMeshProUGUI TransFat;
    public TextMeshProUGUI Cholesterol;
    public TextMeshProUGUI CholesterolPercentage;
    public TextMeshProUGUI Sodium;
    public TextMeshProUGUI SodiumPercentage;
    public TextMeshProUGUI TotalCarbohydrate;
    public TextMeshProUGUI TotalCarbohydratePercentage;
    public TextMeshProUGUI DietaryFiber;
    public TextMeshProUGUI DietaryFiberPercentage;
    public TextMeshProUGUI TotalSugars;
    public TextMeshProUGUI AddedSugars;
    public TextMeshProUGUI TotalSugarsPercentage;
    public TextMeshProUGUI Protein;
    public TextMeshProUGUI ProteinPercentage;

    string _ServingSize = "10 pieces";
    string _ServingsPerContainer = "about 20";
    string _Calories = "50";
    string _TotalFat = "20";
    string _TotalFatUnits = "g";
    string _SaturatedFat = "5";
    string _SaturatedFatUnits = "g";
    string _TransFat = "3";
    string _TransFatUnits = "g";
    string _Cholesterol = "0";
    string _CholesterolUnits = "g";
    string _Sodium = "0";
    string _SodiumUnits = "mg";
    string _TotalCarbohydrate = "0";
    string _TotalCarbohydrateUnits = "g";
    string _DietaryFiber = "0";
    string _DietaryFiberUnits = "g";
    string _Sugars = "0";
    string _SugarsUnits = "g";
    string _AddedSugars = "0";
    string _AddedSugarsUnits = "g";
    string _Protein = "0";
    string _ProteinUnits = "g";

    void OnGUI()
    {
        GUI.Label(new Rect(25, 15, 150, 30), "Serving Size");
        _ServingSize = GUI.TextField(new Rect(25, 35, 150, 30), _ServingSize);

        GUI.Label(new Rect(185, 15, 150, 30), "Servings Per Container");
        _ServingsPerContainer =  GUI.TextField(new Rect(185, 35, 150, 30), _ServingsPerContainer);

        GUI.Label(new Rect(25, 75, 150, 30), "Calories");
        _Calories = GUI.TextField(new Rect(25, 95, 150, 30), _Calories);

        GUI.Label(new Rect(185, 75, 150, 30), "Total Fat");
        _TotalFat = GUI.TextField(new Rect(185, 95, 100, 30), _TotalFat);

        GUI.Label(new Rect(285, 75, 100, 30), "Units");
        _TotalFatUnits = GUI.TextField(new Rect(285, 95, 50, 30), _TotalFatUnits);

        GUI.Label(new Rect(25, 140, 150, 30), "Saturated Fat");
        _SaturatedFat = GUI.TextField(new Rect(25, 160, 100, 30), _SaturatedFat);

        GUI.Label(new Rect(125, 140, 100, 30), "Units");
        _SaturatedFatUnits = GUI.TextField(new Rect(125, 160, 50, 30), _SaturatedFatUnits);

        GUI.Label(new Rect(185, 140, 150, 30), "Trans Fat");
        _TransFat = GUI.TextField(new Rect(185, 160, 100, 30), _TransFat);

        GUI.Label(new Rect(285, 140, 100, 30), "Units");
        _TransFatUnits = GUI.TextField(new Rect(285, 160, 50, 30), _TransFatUnits);

        GUI.Label(new Rect(25, 205, 150, 30), "Cholesterol");
        _Cholesterol = GUI.TextField(new Rect(25, 225, 100, 30), _Cholesterol);

        GUI.Label(new Rect(125, 205, 100, 30), "Units");
        _CholesterolUnits = GUI.TextField(new Rect(125, 225, 50, 30), _CholesterolUnits);

        GUI.Label(new Rect(25, 270, 150, 30), "Sodium");
        _Sodium = GUI.TextField(new Rect(25, 290, 100, 30), _Sodium);

        GUI.Label(new Rect(125, 270, 100, 30), "Units");
        _SodiumUnits = GUI.TextField(new Rect(125, 290, 50, 30), _SodiumUnits);

        GUI.Label(new Rect(185, 270, 150, 30), "Total Carbs");
        _TotalCarbohydrate = GUI.TextField(new Rect(185, 290, 100, 30), _TotalCarbohydrate);

        GUI.Label(new Rect(285, 270, 205, 30), "Units");
        _TotalCarbohydrateUnits = GUI.TextField(new Rect(285, 290, 50, 30), _TotalCarbohydrateUnits);

        GUI.Label(new Rect(25, 335, 150, 30), "Dietary Fiber");
        _DietaryFiber = GUI.TextField(new Rect(25, 355, 100, 30), _DietaryFiber);

        GUI.Label(new Rect(125, 335, 100, 30), "Units");
        _DietaryFiberUnits = GUI.TextField(new Rect(125, 355, 50, 30), _DietaryFiberUnits);

        GUI.Label(new Rect(185, 335, 150, 30), "Total Sugars");
        _Sugars = GUI.TextField(new Rect(185, 355, 100, 30), _Sugars);

        GUI.Label(new Rect(285, 335, 270, 30), "Units");
        _SugarsUnits = GUI.TextField(new Rect(285, 355, 50, 30), _SugarsUnits);

        GUI.Label(new Rect(25, 400, 150, 30), "Added Sugars");
        _AddedSugars = GUI.TextField(new Rect(25, 420, 100, 30), _AddedSugars);

        GUI.Label(new Rect(125, 400, 100, 30), "Units");
        _AddedSugarsUnits = GUI.TextField(new Rect(125, 420, 50, 30), _AddedSugarsUnits);

        GUI.Label(new Rect(185, 400, 150, 30), "Protein");
        _Protein = GUI.TextField(new Rect(185, 420, 100, 30), _Protein);

        GUI.Label(new Rect(285, 400, 270, 30), "Units");
        _ProteinUnits = GUI.TextField(new Rect(285, 420, 50, 30), _ProteinUnits);

    }

    void Update()
    {
        ServingSize.text = _ServingSize;
        ServingsPerContainer.text = _ServingsPerContainer + " servings per container";
        Calories.text = _Calories;
        TotalFat.text = _TotalFat + _TotalFatUnits;
        SaturatedFat.text = _SaturatedFat + _SaturatedFatUnits;
        TransFat.text = _TransFat + _TransFatUnits;
        Sodium.text = _Sodium + _SodiumUnits;
        TotalCarbohydrate.text = _TotalCarbohydrate + _TotalCarbohydrateUnits;
        DietaryFiber.text = _DietaryFiber + _DietaryFiberUnits;
        TotalSugars.text = _Sugars + _SugarsUnits;
        AddedSugars.text = _AddedSugars + _AddedSugarsUnits + " added sugars";
        Protein.text = _Protein + _ProteinUnits;
        Cholesterol.text = _Cholesterol + _CholesterolUnits;
        CalculatePercentage(_TotalFat, _TotalFatUnits, TotalFatPercentage, 78f);
        CalculatePercentage(_SaturatedFat, _SaturatedFatUnits, SaturatedFatPercentage, 20f);
        CalculatePercentage(_Sodium, _SodiumUnits, SodiumPercentage, 2.3f);
        CalculatePercentage(_TotalCarbohydrate, _TotalCarbohydrateUnits, TotalCarbohydratePercentage, 300f);
        CalculatePercentage(_DietaryFiber, _DietaryFiberUnits, DietaryFiberPercentage, 28f);
        CalculatePercentage(_Cholesterol, _CholesterolUnits, CholesterolPercentage, 300f);
        CalculatePercentage(_AddedSugars, _AddedSugarsUnits, TotalSugarsPercentage, 50f);
        CalculatePercentage(_Protein, _ProteinUnits, ProteinPercentage, 50f);

    }

    void CalculatePercentage(string nutrient, string units, TextMeshProUGUI label, float dv)
    {
        if (units == "mg")
        {
            double convertedDV = Convert.ToDouble(dv);
            double Grams = Convert.ToDouble(nutrient) / 100;
            double Percent = (Grams / dv) * 100;
            label.text = Convert.ToString(Convert.ToInt32(Percent)) + "%";
        }
        if(units == "g")
        {
            double convertedDV = Convert.ToDouble(dv);
            double Grams = Convert.ToDouble(nutrient);
            double Percent = (Grams / dv) * 100;
            label.text = Convert.ToString(Convert.ToInt32(Percent)) + "%";
        }
    }




}
