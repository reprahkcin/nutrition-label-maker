using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Ingredient : MonoBehaviour
{
    

    public GameObject ingredientPanel;
    public GameObject ingredientNameObject;
    public GameObject ingredientAmountObject;
    public GameObject ingredientUnitObject;

    [SerializeField]
    public string _ingredientName;
    [SerializeField]
    private float _ingredientAmount;
    [SerializeField]
    private string _ingredientUnit;

    public float IngredientAmountInMilligrams;

    public void RemoveIngredient()
    {
        Destroy(ingredientPanel);
    }


    public void Refresh()
    {
        _ingredientName = ingredientNameObject.GetComponent<TextMeshProUGUI>().text;
        _ingredientAmount = ingredientAmountObject.GetComponent<Text>().text == null ? 0.0f : float.Parse(ingredientAmountObject.GetComponent<Text>().text);
        _ingredientUnit = ingredientUnitObject.GetComponent<TextMeshProUGUI>().text;
        ConvertToMilligrams();
    }

    void ConvertToMilligrams()
    {
        switch (_ingredientUnit)
        {
            case "Select Unit":
                IngredientAmountInMilligrams = 0;
                break;
            case "grams":
                IngredientAmountInMilligrams = _ingredientAmount * 1000;
                break;
            case "milligrams":
                IngredientAmountInMilligrams = _ingredientAmount;
                break;
            case "ounces":
                IngredientAmountInMilligrams = _ingredientAmount * 28350;
                break;
            case "cups":
                IngredientAmountInMilligrams = _ingredientAmount * 236588;
                break;
            case "Tbsp":
                IngredientAmountInMilligrams = _ingredientAmount * 17063;
                break;
            case "tsp":
                IngredientAmountInMilligrams = _ingredientAmount * 2325;
                break;
        }
    }
}
