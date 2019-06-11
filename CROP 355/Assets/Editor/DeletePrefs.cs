using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class DeletePrefs : EditorWindow
{
    [MenuItem("Edit/Delete All PlayerPrefs")]

    public static void DeletePlayerPrefs()
    {
        //PlayerPrefs.DeleteAll();
        GameObject panel = new GameObject("TestPanel");
        panel.AddComponent<CanvasRenderer>();
        panel.AddComponent<RectTransform>();
        Image i = panel.AddComponent<Image>();
        i.color = new Color(0f,150f,150f,255f);
        
        panel.transform.SetParent(FindObjectOfType<Canvas>().transform, false);
        Debug.Log("Deleted Player Preferences");
    }
}
