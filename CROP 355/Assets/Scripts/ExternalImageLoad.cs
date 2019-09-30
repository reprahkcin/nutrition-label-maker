using System.Collections;
using UnityEngine;

public class ExternalImageLoad : MonoBehaviour
{
    private string imageUrl;
    public GameObject img;
    public CanvasRenderer image;

    public void ExternalCall()
    {
        Application.ExternalCall( "SayHello", "The game says hello!" );
    }

    public void MyFunction(string str)
    {
        imageUrl = str;
        StartCoroutine(LoadFromLikeCoroutine());
    }

    private IEnumerator LoadFromLikeCoroutine()
    {
        GameObject go = Instantiate(img);
        go.transform.SetParent(GameObject.Find("MainLayoutPanel").transform, false);
        WWW wwwLoader = new WWW(imageUrl);
        yield return wwwLoader;


        //image.SetTexture(wwwLoader.texture);

        //go.transform.SetParent(GameObject.Find("MainLayoutPanel").transform, false);
        CanvasRenderer canv = go.GetComponent<CanvasRenderer>();
        canv.SetTexture(wwwLoader.texture);
        go.GetComponent<RectTransform>().sizeDelta = new Vector2(wwwLoader.texture.width, wwwLoader.texture.height);
        go.GetComponent<RectTransform>().position = new Vector3(Screen.width/2,Screen.height/2);
        go.tag = "Draggable";
    }


}
