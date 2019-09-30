using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DefaultToGrams : MonoBehaviour
{
    public GameObject dropDown;

    public void ChangeToGrams()
    {
        if (dropDown.GetComponent<TMP_Dropdown>().value == 0)
        {
            dropDown.GetComponent<TMP_Dropdown>().value = 1;
        }
    }
}
