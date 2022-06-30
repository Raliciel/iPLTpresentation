using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePopUp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _damageCount;
    public TextMesh _damageText;
    static GameObject damageCount;
    static TextMesh damageText;

    void Start()
    {
        damageCount = _damageCount;
        damageText = _damageText;
    }
    public static void CreateDamage(Transform ttransform, int damage)
    {
        GameObject count = Instantiate(damageCount) as GameObject;
        count.transform.SetParent(ttransform, false);
        count.transform.position = ttransform.position + new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), 0);

        count.GetComponent<TextMesh>().text = damage.ToString();
    }

    public static void CreateDamage(Transform ttransform, string massage)
    {
        GameObject count = Instantiate(damageCount) as GameObject;
        count.transform.SetParent(ttransform, false);
        count.transform.position = ttransform.position + new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), 0);

        count.GetComponent<TextMesh>().text = massage;
        count.GetComponent<TextMesh>().color = Color.gray;
        count.GetComponent<TextMesh>().fontSize /= 2;
    }
}
