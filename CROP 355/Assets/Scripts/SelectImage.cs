using TMPro;
using UnityEngine;

public class SelectImage : MonoBehaviour
{
    private GameObject inspector;
    public void PutImageInInspector()
    {
        inspector = GameObject.Find("Inspector");
        GameObject img = gameObject;
        inspector.GetComponent<Inspector>().EmptySelection();
        inspector.GetComponent<Inspector>().selectedImage = img;
        inspector.GetComponentInChildren<TextMeshProUGUI>().text = "Image";
    }
}
