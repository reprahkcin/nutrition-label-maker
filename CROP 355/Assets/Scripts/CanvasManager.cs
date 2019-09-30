using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public int activeCanvas = 0;
    public GameObject[] canvases; 

    void Start()
    {
        SwapCanvases(activeCanvas); 
    }

    public void NextThing()
    {
        activeCanvas++;
        if (activeCanvas > canvases.Length) { activeCanvas = 0; }
        SwapCanvases(activeCanvas);
    }

    public void LastThing()
    {
        activeCanvas--;
        if (activeCanvas < 0) { activeCanvas = 0; }
       
        SwapCanvases(activeCanvas);
    }

    public void SwapCanvases(int i)
    {
        foreach (GameObject thing in canvases)
        {
            thing.gameObject.SetActive(false);
        }
        canvases[i].gameObject.SetActive(true);
    }
}
