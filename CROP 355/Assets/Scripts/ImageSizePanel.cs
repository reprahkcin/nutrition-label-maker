using UnityEngine;

public class ImageSizePanel : MonoBehaviour
{
    private LoadedImage loadedImage;

    void Start()
    {
        loadedImage = gameObject.transform.GetChild(0).gameObject.GetComponentInChildren<LoadedImage>();
    }

    public void MakeBigger()
    {
        loadedImage.IncreaseSize();
    }

    public void MakeSmaller()
    {
        loadedImage.DecreaseSize();
    }
}
