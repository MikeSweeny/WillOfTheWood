using System.Collections;
using System.Collections.Generic;
using UnityEngine;
////NAME : ConsumableObject : ItemObject
////PURPOSE : Lets use create a ConsumableObject asset file in the editor

[CreateAssetMenu(menuName = "Item/Consumable", fileName = "Items")]
public class ConsumableObject : ItemObject
{
    public int amount;
    private void Awake()
    {
        type = ItemType.Consumable;
    }
}
