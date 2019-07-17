using UnityEngine;


public class RightClickDelete : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
            Destroy(gameObject);
    }
}
