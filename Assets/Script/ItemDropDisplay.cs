using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropDisplay : MonoBehaviour
{
    public ItemTemplate item;
    public SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite.sprite = item.itemImage;
    }
}
