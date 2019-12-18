using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    private List<Item> contents;

    // Start is called before the first frame update
    void Awake()
    {
        contents = new List<Item>();
    }

    public void AddItem(Item item)
    {
        contents.Add(item);
    }

    public void RemoveItem(Item item)
    {
        contents.Remove(item);
    }
}
