using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Item/Gold", fileName = "Items")]
public class GoldObject : ItemObject
{
    public int amount;

    private void Awake()
    {
        type = ItemType.Gold;

    }
}
