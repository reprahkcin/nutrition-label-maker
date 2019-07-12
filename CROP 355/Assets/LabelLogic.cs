using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LabelLogic : MonoBehaviour
{
    public GameObject servingSizeInputField;
    private string servingSizeValue;
    public GameObject servingsPerContainerInputField;
    private string servingsPerContainerValue;
    public GameObject caloriesInputField;
    private string caloriesValue;
    public GameObject totalFatInputField;
    private string totalFatValue;
    public GameObject saturatedFatInputField;
    private string saturatedFatValue;
    public GameObject transFatInputField;
    private string transFatValue;
    public GameObject cholesterolInputField;
    private string cholesterolValue;
    public GameObject sodiumInputField;
    private string sodiumValue;
    public GameObject totalCarbsInputField;
    private string totalCarbsValue;
    public GameObject dietaryFiberInputField;
    private string dietaryFiberValue;
    public GameObject totalSugarsInputField;
    private string totalSugarsValue;
    public GameObject addedSugarsInputField;
    private string addedSugarsValue;
    public GameObject proteinInputField;
    private string proteinValue;
    public GameObject[] inputFields;
    public string[] inputValues;


    public GameObject servingSizeDD;
    public GameObject servingsPerContainerDD;
    public GameObject caloriesDD;
    public GameObject totalFatDD;
    public GameObject saturatedFatDD;
    public GameObject transFatDD;
    public GameObject cholesterolDD;
    public GameObject sodiumDD;
    public GameObject totalCarbsDD;
    public GameObject dietaryFiberDD;
    public GameObject totalSugarsDD;
    public GameObject addedSugarsDD;
    public GameObject proteinDD;
    public GameObject[] dropdowns;



    void BuildArrays()
    {
        inputFields = new GameObject[]
        {
            servingSizeInputField,
            servingsPerContainerInputField,
            caloriesInputField,
            totalFatInputField,
            saturatedFatInputField,
            transFatInputField,
            cholesterolInputField,
            sodiumInputField,
            totalCarbsInputField,
            dietaryFiberInputField,
            totalSugarsInputField,
            addedSugarsInputField,
            proteinInputField
        };

        dropdowns = new GameObject[]
        {
            servingSizeDD,
            servingsPerContainerDD,
            caloriesDD,
            totalFatDD,
            saturatedFatDD,
            transFatDD,
            cholesterolDD,
            sodiumDD,
            totalCarbsDD,
            dietaryFiberDD,
            totalSugarsDD,
            addedSugarsDD,
            proteinDD
        };
    }

    // Start is called before the first frame update
    void Start()
    {
        BuildArrays();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(servingSizeInputField.GetComponentInChildren<Text>().text);
        Debug.Log(servingSizeDD.GetComponentInChildren<TextMeshProUGUI>().text);
    }
}
