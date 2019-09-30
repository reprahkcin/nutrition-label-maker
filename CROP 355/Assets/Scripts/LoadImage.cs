using UnityEngine;
using UnityEngine.UI;
using SimpleFileBrowser;
using System.Collections;
using System.Collections.Generic;

public class LoadImage : MonoBehaviour
{

    public GameObject loadedImagePrefab;
    public GameObject organicLabel;

    string url;
    private List<GameObject> LoadedImages = new List<GameObject>();


    public void Browse()
    {
        FileBrowser.SetFilters(true, new FileBrowser.Filter("Images", ".jpg", ".png"));
        StartCoroutine(ShowLoadDialogCoroutine());
    }

    IEnumerator ShowLoadDialogCoroutine()
    {
        yield return FileBrowser.WaitForLoadDialog(false, null, "Load Image", "Select");
        url = FileBrowser.Result;

        Texture2D tex;
        tex = new Texture2D(4, 4, TextureFormat.DXT1, false);
        WWW www = new WWW(url);
        yield return www;
        www.LoadImageIntoTexture(tex);

        GameObject MainLayoutPanel = GameObject.Find("MainLayoutPanel");

        GameObject panel = Instantiate(loadedImagePrefab, MainLayoutPanel.transform,false);
        panel.name = "Loaded Image";
        panel.tag = "Draggable";

        LoadedImages.Add(panel);

        RectTransform rect = panel.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(tex.width,tex.height);

        Image img = panel.GetComponent<Image>();
        img.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), Vector2.zero);

        panel.AddComponent<LoadedImage>();
    }

    public void LoadOrganic()
    {
        GameObject MainLayoutPanel = GameObject.Find("MainLayoutPanel");
        GameObject panel = Instantiate(organicLabel, MainLayoutPanel.transform, false);
        panel.name = "Organic Label";
        LoadedImages.Add(panel);
        panel.AddComponent<LoadedImage>();
    }
}
