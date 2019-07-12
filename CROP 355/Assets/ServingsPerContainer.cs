using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ServingsPerContainer : MonoBehaviour
{
    public InputField inputField;
    public TextMeshProUGUI outputLabel;

    private string nutrientValueStr;
    private string nutrientUnitStr;

    private string nutrientOutputStr;

    void Start()
    {
        outputLabel.GetComponent<TextMeshProUGUI>().text = " ";
    }
    void GetValues()
    {
        if (inputField.GetComponentsInChildren<Text>()[1].text == "")
        {
            gameObject.GetComponent<TextMeshProUGUI>().color = Color.red;
        }
        else
        {
            nutrientValueStr = inputField.GetComponentsInChildren<Text>()[1].text;
            gameObject.GetComponent<TextMeshProUGUI>().color = Color.white;
        }

    }

    void DoCalculations()
    {
        nutrientOutputStr = nutrientValueStr + " Servings per container";
    }

    void OutputValues()
    {
        outputLabel.GetComponent<TextMeshProUGUI>().text = nutrientOutputStr;
    }

    public void Button()
    {
        GetValues();
        DoCalculations();
        OutputValues();
    }
}
