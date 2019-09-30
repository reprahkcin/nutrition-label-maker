using TMPro;
using UnityEngine;

public class SelectText : MonoBehaviour
{
    private GameObject inspector;

    public void PutSelfInInspector()
    {
        inspector = GameObject.Find("Inspector");
        TextMeshProUGUI txt = gameObject.GetComponent<TextMeshProUGUI>();
        inspector.GetComponent<Inspector>().EmptySelection();
        inspector.GetComponent<Inspector>().selectedText = txt;
        inspector.GetComponentInChildren<TextMeshProUGUI>().text = "Text Options";
    }

}
