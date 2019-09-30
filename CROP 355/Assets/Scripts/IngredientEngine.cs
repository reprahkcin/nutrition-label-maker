
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using static System.String;


public class IngredientEngine : MonoBehaviour
{
    public GameObject directorObject;

    public bool isBuilt;

    public GameObject ingredientPanel;
    public GameObject ingredientListObject;

    public Ingredient[] ingredientArray;

    public Dictionary<float, Ingredient> unsortedIngredientsDictionary;
    public Dictionary<float, Ingredient> sortedIngredientsDictionary;



    public void AddIngredient()
    {
        Instantiate(ingredientPanel, transform);
        isBuilt = true;
    }

    public void CollectIngredients()
    {
        ingredientArray = gameObject.GetComponentsInChildren<Ingredient>();
        RefreshAll();
    }

    public void RefreshAll()
    {
        for (int i = 0; i < ingredientArray.Length; i++)
        {
            ingredientArray[i].GetComponent<Ingredient>().Refresh();
        }
    }

    
    public void PopulateDictionary()
    {
        unsortedIngredientsDictionary = new Dictionary<float, Ingredient>();
        for (int i = 0; i < ingredientArray.Length; i++)
        {
            float key = ingredientArray[i].GetComponent<Ingredient>().IngredientAmountInMilligrams;
            if (unsortedIngredientsDictionary.ContainsKey(key))
            {
                float random = Random.Range(0.0f, 0.01f);
                key += random;
            }
            Ingredient value = ingredientArray[i].GetComponent<Ingredient>();
            Debug.Log(key);
            Debug.Log(value);
            unsortedIngredientsDictionary.Add(key,value);
        }
    }

    public void SortDictionary()
    {
        sortedIngredientsDictionary = new Dictionary<float, Ingredient>();
        foreach (KeyValuePair<float, Ingredient> quantity in unsortedIngredientsDictionary.OrderByDescending(key => key.Key))
        {
            sortedIngredientsDictionary.Add(quantity.Key,quantity.Value);
        }
    }


    public void OutputDictionary()
    {
        List<string> sortedStrings = new List<string>();
        foreach (KeyValuePair<float, Ingredient> ingredient in sortedIngredientsDictionary)
        {
            sortedStrings.Add(ingredient.Value._ingredientName);
        }
        string combined = Join(", ", sortedStrings);
        ingredientListObject.GetComponent<TextMeshProUGUI>().text = "INGREDIENTS: " + combined;
        GameObject.Find("Director").GetComponent<LabelObject>().IngredientText = "INGREDIENTS: " + combined;
    }

    public void DoItAll()
    {
        CollectIngredients();
        PopulateDictionary();
        SortDictionary();
        OutputDictionary();
    }

    public void MoveOn()
    {
        if (sortedIngredientsDictionary != null)
        {
            directorObject.GetComponent<CanvasManager>().NextThing();
        }
    }
}
