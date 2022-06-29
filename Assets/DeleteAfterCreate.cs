using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAfterCreate : MonoBehaviour
{
    public TextMesh damageText;
    private float timePassed = 0;
    public float textFloatValue;
    void Awake()
    {
        StartCoroutine(count());
    }
    private void Update()
    {
        transform.position = new Vector3 (transform.position.x, transform.position.y + Time.deltaTime * 0.01f, transform.position.z);
    }

    IEnumerator count()
    {
        while (timePassed <= 0.1f)
        {
            timePassed += Time.deltaTime;
            yield return null;
        }
        while (timePassed <= 0.3f)
        {
            Color color = damageText.color;
            color.a -= Time.deltaTime * 1 / 0.3f;
            damageText.color = color;
            timePassed += Time.deltaTime;
            yield return null;
        }
        Destroy(gameObject);
    }
}
