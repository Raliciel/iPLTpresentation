using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarUI : MonoBehaviour
{
    public Text number;
    public Slider bar;

    // Start is called before the first frame update
    public void SetMaxHealth(int value)
    {
        bar.maxValue = value;
    }

    public void DecreseValue(int value)
    {
        bar.value -= value;
    }

    public int GetValue()
    {
        return (int) bar.value;
    }

    public void SetValue(int value)
    {
        bar.value = value;
    }

    // Update is called once per frame
    public void SetCurrentHealth(int value)
    {
        number.text = value.ToString();
        bar.value = value;
    }
}
