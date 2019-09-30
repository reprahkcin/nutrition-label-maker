using UnityEngine;

public class MainLayoutPanel : MonoBehaviour
{
    public GameObject inspector;

    public void EmptySelection()
    {
        inspector.GetComponent<Inspector>().selectedImage = null;
        inspector.GetComponent<Inspector>().selectedText = null;
        inspector.GetComponent<Inspector>().selectedIngredients = null;
        inspector.GetComponent<Inspector>().selectedNutritionFacts = null;
        inspector.GetComponent<Inspector>().selectedPanel = null;
    }
}
