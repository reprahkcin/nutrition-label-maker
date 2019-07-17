using System;
using UnityEngine;

public class AddText : MonoBehaviour
{
    public GameObject TextGenerationWindowPrefab;
    
    public void AddTextWindow()
    {
        GameObject window = Instantiate(TextGenerationWindowPrefab);
        window.transform.SetParent(GameObject.Find("Canvas").transform,false);
    }

}
