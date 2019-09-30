using TMPro;
using UnityEngine;

public class SelectPanel : MonoBehaviour
{
    private GameObject inspector;

    public void PutPanelInInspector()
    {
        inspector = GameObject.Find("Inspector");
        GameObject img = gameObject;
        inspector.GetComponent<Inspector>().EmptySelection();
        inspector.GetComponent<Inspector>().selectedPanel = img;
        inspector.GetComponentInChildren<TextMeshProUGUI>().text = "Colored Panel";
    }
}
