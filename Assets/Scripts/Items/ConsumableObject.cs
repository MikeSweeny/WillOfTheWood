using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Item/Consumable", fileName = "Items")]
public class ConsumableObject : ItemObject
{
    public int amount;
    private void Awake()
    {
        type = ItemType.Consumable;
    }
}
