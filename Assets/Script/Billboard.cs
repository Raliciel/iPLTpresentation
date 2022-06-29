using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Billboard : MonoBehaviour
{
    public RectTransform rectTransform;
    public Vector3 scale = Vector3.one;
    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    private void LateUpdate()
    {
        rectTransform.localScale = scale;
    }
}
