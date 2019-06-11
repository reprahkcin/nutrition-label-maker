using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class MenuItemDemo : EditorWindow
{
    [MenuItem("Edit/Do A Thing")]

    public static void DoAThing()
    {

        // Create a Canvas
        GameObject newCanvas = new GameObject("Canvas");
        Canvas c = newCanvas.AddComponent<Canvas>();
        c.renderMode = RenderMode.ScreenSpaceOverlay;
        // Add the standard components to the new canvas
        newCanvas.AddComponent<CanvasScaler>();
        newCanvas.AddComponent<GraphicRaycaster>();

        // Create a Panel
        GameObject panel = new GameObject("TestPanel");
        // Add the standard components to the new panel
        panel.AddComponent<CanvasRenderer>();
        panel.AddComponent<RectTransform>();
        Image i = panel.AddComponent<Image>();
        i.color = new Color(0f, 150f, 150f, 255f);

        // Add the panel as a child of the new canvas
        panel.transform.SetParent(newCanvas.transform, false);

        // Create a primitive
        GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        // Configure it
        newCube.transform.position = new Vector3(5, 10, 20);
    }
}
