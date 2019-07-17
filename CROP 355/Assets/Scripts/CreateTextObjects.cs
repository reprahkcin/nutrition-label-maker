using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateTextObjects : MonoBehaviour
{
    public GameObject textField;
    public GameObject sizeField;
    public TMP_FontAsset[] fonts;

    [SerializeField] private string text;
    [SerializeField] private int size;
    [SerializeField] private bool isBold;

    public void CreateTextObject()
    {
        GrabText();
        GrabSize();
        GameObject txt = new GameObject("text");
        txt.tag = "Draggable";
        txt.transform.position = new Vector3(10,10,0);
        txt.AddComponent<RectTransform>();
        txt.AddComponent<CanvasRenderer>();
        txt.AddComponent<TextMeshProUGUI>();

        txt.AddComponent<RightClickDelete>();

        TextMeshProUGUI tmp = txt.GetComponent<TextMeshProUGUI>();
        tmp.text = text;
        tmp.alignment = TextAlignmentOptions.Center;
        tmp.fontSize = size;

        if (isBold)
        {
            tmp.fontStyle = FontStyles.Bold;
        }
        GameObject canvas = GameObject.Find("Canvas"); 
        txt.transform.SetParent(canvas.transform, false);
    }
    void GrabText()
    {
        text = textField.GetComponent<Text>().text;
    }

    void GrabSize()
    {
        string temp = sizeField.GetComponent<Text>().text;
        size = Convert.ToInt32(temp);
    }

    public void ToggleBold()
    {
        if (isBold)
        {
            isBold = false;
        }
        else
        {
            isBold = true;
        }
    }


}
