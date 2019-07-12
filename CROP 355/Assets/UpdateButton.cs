using UnityEngine;

public class UpdateButton : MonoBehaviour
{
    public GameObject[] labels;
    public GameObject servingSize;
    public GameObject servingsPerContainer;
    public GameObject calories;

    public void UpdateButtonFunction()
    {
        foreach (GameObject label in labels)
        { 
            Nutrient nutrient = label.GetComponent<Nutrient>();
            nutrient.Button();
        }
        servingSize.GetComponent<ServingSize>().Button();
        servingsPerContainer.GetComponent<ServingsPerContainer>().Button();
        calories.GetComponent<Calories>().Button();
    }
}
