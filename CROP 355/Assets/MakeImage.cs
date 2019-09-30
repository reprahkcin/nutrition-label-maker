
using UnityEngine;
using UnityEngine.UI;

public class MakeImage : MonoBehaviour
{
    public Texture2D nutritionFactsTexture;
    public GameObject imagePlaceholder;

    private int height;
    private int width;

    public void Start()
    {
        Debug.Log(gameObject.transform.position);
        Debug.Log(gameObject.transform.localPosition);
    }


    public void TakeShot()
    {
        nutritionFactsTexture = new Texture2D(Screen.width/2, Screen.height, TextureFormat.RGB24, false);
        nutritionFactsTexture.ReadPixels(new Rect(Screen.width/2, 0,Screen.width, Screen.height), 0, 0, false);
        nutritionFactsTexture.Apply();

        imagePlaceholder.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width/2,Screen.height);
        imagePlaceholder.GetComponent<Image>().sprite = Sprite.Create(nutritionFactsTexture, new Rect(0, 0, Screen.width/2, Screen.height), Vector2.zero);

    }
}
