using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject focus;
    public Vector3 offset = new Vector3(0, 0, -20);
    // Start is called before the first frame update
    void Update()
    {
        if (focus = null)
        {
            transform.position = focus.transform.position + offset;
        }

    }

}
