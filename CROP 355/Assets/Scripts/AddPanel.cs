using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPanel : MonoBehaviour
{
    public GameObject panelPrefab;

    public void AddPanelToMainLayout()
    {
        var mainLayout = GameObject.Find("MainLayoutPanel");
        var panel = Instantiate(panelPrefab, mainLayout.transform);
        panel.tag = "Draggable";
        panel.GetComponent<Image>().color = Color.black;
    }
}
