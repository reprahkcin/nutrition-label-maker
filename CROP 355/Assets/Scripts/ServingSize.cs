using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ServingSize : MonoBehaviour
{
    public InputField inputField;
    public Dropdown inputDD;
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
            nutrientUnitStr = inputDD.GetComponentInChildren<Text>().text;
            gameObject.GetComponent<TextMeshProUGUI>().color = Color.white;
        }
        
    }

    void DoCalculations()
    {
        nutrientOutputStr = nutrientValueStr + " " + nutrientUnitStr;
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
