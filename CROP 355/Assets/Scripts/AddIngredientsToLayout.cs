using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AddIngredientsToLayout : MonoBehaviour
{
    public GameObject IngredientsTextPrefab;
    public GameObject DirectorObject;
    public GameObject MainLayoutPanel;
    public void AddToLayout()
    {
        string txt = DirectorObject.GetComponent<LabelObject>().IngredientText;
        GameObject ingredientTextObject = Instantiate(IngredientsTextPrefab, MainLayoutPanel.transform);
        ingredientTextObject.tag = "Draggable";
        ingredientTextObject.GetComponent<TextMeshProUGUI>().text = txt;
    }
}
