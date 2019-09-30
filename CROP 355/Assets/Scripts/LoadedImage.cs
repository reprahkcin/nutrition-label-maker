using UnityEngine;

public class LoadedImage : MonoBehaviour
{
    public void IncreaseSize()
    {
        Vector2 currentSize = gameObject.GetComponent<RectTransform>().sizeDelta;
        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(currentSize.x, currentSize.y)*1.05f;
    }
    public void DecreaseSize()
    {
        Vector2 currentSize = gameObject.GetComponent<RectTransform>().sizeDelta;
        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(currentSize.x, currentSize.y)*0.95f;
    }
}
