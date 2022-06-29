using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public characterGameObject player;

    // Update is called once per frame
    public void refillHealth()
    {
        player.currentHealthPoint = player.healthPoint;
    }
}
