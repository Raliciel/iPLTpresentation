using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{
    public Slider staminaBar;
    private int maxStamina;
    // Start is called before the first frame update
    public void Start()
    {
        maxStamina = (int) staminaBar.maxValue;
    }
    public void ResetStamina()
    {
        staminaBar.value = maxStamina;
    }
}
