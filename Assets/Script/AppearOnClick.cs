using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppearOnClick : MonoBehaviour
{
    public Image cursor;
    public RectTransform rectTransform;
    void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            cursor.enabled = true;
            rectTransform.position = Input.mousePosition;
        }
        else
        {
            cursor.enabled = false;
        }
    }
}
