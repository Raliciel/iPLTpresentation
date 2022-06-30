using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bossbattle : MonoBehaviour
{

    public Image player;
    public Image boss;
    public float transitionRate = 200;
    private float transferIn = 200;
    void OnEnable()
    {
        StartCoroutine(Transition());
    }

    IEnumerator Transition()
    {
        while (transferIn >= 70)
        {
            transferIn -= Time.deltaTime * transitionRate;
            player.rectTransform.localPosition = new Vector3(transferIn, -14f, 0);
            boss.rectTransform.localPosition = new Vector3(-transferIn, -14f, 0);
            yield return null;
        }
        yield return new WaitForSeconds(0.2f);
        transferIn = 200;
        gameObject.SetActive(false);
    }
}
