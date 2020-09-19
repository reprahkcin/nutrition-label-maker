using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class RightClickDelete : MonoBehaviour
{
    GraphicRaycaster m_Raycaster;
    PointerEventData m_PointerEventData;
    EventSystem m_EventSystem;

    void Start()
    {
        m_Raycaster = GetComponent<GraphicRaycaster>();
        m_EventSystem = GetComponent<EventSystem>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            m_PointerEventData = new PointerEventData(m_EventSystem);
            m_PointerEventData.position = Input.mousePosition;

            List<RaycastResult> results = new List<RaycastResult>();
            m_Raycaster.Raycast(m_PointerEventData, results);

            if (results[0].gameObject.tag == "Draggable")
            {
                if (results[0].gameObject.name != "Output Panel(Clone)" && Input.GetKey(KeyCode.LeftShift))
                {
                    Destroy(results[0].gameObject);
                }
                if (results[0].gameObject.name != "Output Panel(Clone)" && Input.GetKey(KeyCode.RightShift))
                {
                    Destroy(results[0].gameObject);
                }
            }

        }
    }
}
