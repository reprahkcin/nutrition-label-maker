using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateTextObjects : MonoBehaviour
{

    public GameObject textField;
    public GameObject starterText;
    private int _starterFontSize = 32;

    [SerializeField] private string text;

    public void CreateTextObject()
    {
        GrabText();
        GameObject txt = Instantiate(starterText);
        txt.name = "Text Object";
        txt.tag = "Draggable";
        txt.transform.position = new Vector3(10,10,0);
        TextMeshProUGUI tmp = txt.GetComponent<TextMeshProUGUI>();
        tmp.text = text;
        tmp.fontSize = _starterFontSize;
        GameObject canvas = GameObject.Find("MainLayoutPanel"); 
        txt.transform.SetParent(canvas.transform, false);
    }
    void GrabText()
    {
        text = textField.GetComponent<Text>().text;
    }
}
