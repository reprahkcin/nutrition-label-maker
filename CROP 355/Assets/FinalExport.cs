using System;
using UnityEngine;
using System.Collections;

public class FinalExport : MonoBehaviour
{
    public KeyCode begin;

    public GameObject Inspector;
    public GameObject FooterPanel;

    public bool isActive = true;


    public void ToggleHUD()
    {
        if (isActive)
        {
            Inspector.SetActive(false);
            FooterPanel.SetActive(false);
            isActive = false;
        }
        else
        {
            Inspector.SetActive(true);
            FooterPanel.SetActive(true);
            isActive = true;
        }
    }


    public void TakeTheShot()
    {
        StartCoroutine(Capture());

    }

    IEnumerator Capture()
    {
        
        ToggleHUD();
        yield return new WaitForEndOfFrame();
        Debug.Log("we waited");
        var texture = ScreenCapture.CaptureScreenshotAsTexture();
        Debug.Log("We captured");
        // do something with texture
        byte[] bytes = texture.EncodeToPNG();
        Debug.Log("We encoded");
        string encodedText = System.Convert.ToBase64String(bytes);
        Debug.Log("We converted it to bytes");
        Application.ExternalCall("createImage", encodedText);
        // cleanup
        //Destroy(texture);
        //ToggleHUD();


    }

}
