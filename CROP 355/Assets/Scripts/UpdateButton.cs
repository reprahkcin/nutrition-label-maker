using UnityEngine;

public class UpdateButton : MonoBehaviour
{
    public GameObject nutFactsPanel;
    public GameObject directorObject;
    public GameObject mainLayoutPanel;

    public GameObject[] labels;
    public GameObject servingSize;
    public GameObject servingsPerContainer;
    public GameObject calories;
    public GameObject addedSugars;

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
            addedSugars.GetComponent<AddedSugars>().Button();
        


    }

    public void NextButton()
    {
        GameObject nutrPanel = Instantiate(nutFactsPanel, mainLayoutPanel.transform);
        RectTransform rect = nutrPanel.GetComponent<RectTransform>();
        rect.localScale = new Vector3(0.5f, 0.5f);
        nutrPanel.tag = "Draggable";
        directorObject.GetComponent<CanvasManager>().NextThing();
    }
}
