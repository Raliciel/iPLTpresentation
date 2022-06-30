using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public ItemTemplate item;
    public Text itemName;
    public Image itemIcon;
    // Start is called before the first frame update
    void Start()
    {
        itemName.text = item.itemName;
        itemIcon.sprite = item.itemImage;
    }

}
