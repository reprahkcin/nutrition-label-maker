using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

class DragTransform : MonoBehaviour
{
    public const string DRAGGABLE_TAG = "Draggable";

    private bool dragging = false;
    private float distance;
    private Transform objectToDrag;
    private Image objectToDragImage;

    List<RaycastResult> selectedObjects = new List<RaycastResult>();

    void OnMouseDown()
    {
        dragging = true;
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            objectToDrag = GetDraggableTransformUnderMouse();

            if (objectToDrag != null)
            {
                dragging = true;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }

        if (dragging)
        {
            objectToDrag.position = Input.mousePosition;
        }
    }

    private GameObject GetObjectUnderMouse()
    {
        var pointer = new PointerEventData(EventSystem.current);

        pointer.position = Input.mousePosition;

        EventSystem.current.RaycastAll(pointer, selectedObjects);

        if (selectedObjects.Count <= 0) return null;

        return selectedObjects.First().gameObject;
    }

    private Transform GetDraggableTransformUnderMouse()
    {
        GameObject clickedObject = GetObjectUnderMouse();

        if (clickedObject != null && clickedObject.tag == DRAGGABLE_TAG)
        {
            return clickedObject.transform;
        }

        return null;
    }
}

