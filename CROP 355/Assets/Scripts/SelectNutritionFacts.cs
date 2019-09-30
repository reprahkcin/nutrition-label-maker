using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SelectNutritionFacts : MonoBehaviour
{
    private GameObject inspector;
    public void PutImageInInspector()
    {
        inspector = GameObject.Find("Inspector");
        GameObject img = gameObject;
        inspector.GetComponent<Inspector>().EmptySelection();
        inspector.GetComponent<Inspector>().selectedNutritionFacts = img;
        inspector.GetComponentInChildren<TextMeshProUGUI>().text = "Nutrition Facts";
    }
}
