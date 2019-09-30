using UnityEngine;

public class ImageSizeButtonScript : MonoBehaviour
{
    private Transform loadedImage;
    private LoadedImage loadedImageScript;
    void Start()
    {
        loadedImageScript = gameObject.GetComponentInChildren<LoadedImage>();
        Transform[] children = gameObject.GetComponentsInChildren<Transform>();
        foreach (Transform child in children)
        {
            if (child.name == "Loaded Image")
            {
                loadedImage = child;
            }
        }
    }

    public void IncreaseSize()
    {
        loadedImageScript.IncreaseSize();
    }

    public void DecreaseSize()
    {
        loadedImageScript.DecreaseSize();
    }

    public void HideSelf()
    {
        loadedImage.gameObject.transform.SetParent(GameObject.Find("Canvas").transform, true);
        gameObject.SetActive(false);
        
    }
}
