using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SelectIngredients : MonoBehaviour
{
    private GameObject inspector;

    public void PutSelfInInspector()
    {
        inspector = GameObject.Find("Inspector");
        TextMeshProUGUI txt = gameObject.GetComponent<TextMeshProUGUI>();
        inspector.GetComponent<Inspector>().EmptySelection();
        inspector.GetComponent<Inspector>().selectedIngredients = txt;
        inspector.GetComponentInChildren<TextMeshProUGUI>().text = "Ingredients List";
    }
}
