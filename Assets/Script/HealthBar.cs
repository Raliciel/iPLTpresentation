using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public characterGameObject player;
    public Slider slider;

    public void Start()
    {
        gameObject.TryGetComponent<Slider>(out slider);
    }

    public void Update()
    {
        if (slider != null)
        {
            slider.value = player.currentHealthPoint;
        }
    }

    // Update is called once per frame
    public void refillHealth()
    {
        player.currentHealthPoint = player.healthPoint;
    }
}
