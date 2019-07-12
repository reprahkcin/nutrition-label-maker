using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Calories : MonoBehaviour
{
    public InputField inputField;
    public TextMeshProUGUI outputLabel;

    private string nutrientValueStr;
    
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
        nutrientOutputStr = nutrientValueStr;
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