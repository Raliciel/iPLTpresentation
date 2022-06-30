using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemList : MonoBehaviour
{
    public List<ItemTemplate> _item = new List<ItemTemplate>();
    public GameObject _itemDropTemplate;
    public static GameObject itemDropTemplate;
    public static List<ItemTemplate> item = new List<ItemTemplate>();
    void Start()
    {
        item = _item;
        itemDropTemplate = _itemDropTemplate;
    }

    public static ItemTemplate randomItem()
    {
        if (item == null)
        {
            Debug.Log("data error: no item found");
            return null;
        }
        return item[Random.Range(0, item.Count)];
    }

    public static void RandomDrop(Transform ttransform)
    {
        GameObject item = Instantiate(itemDropTemplate) as GameObject;
        item.GetComponent<ItemDropDisplay>().item = itemList.randomItem();
        item.transform.position = ttransform.position;
    }
}
