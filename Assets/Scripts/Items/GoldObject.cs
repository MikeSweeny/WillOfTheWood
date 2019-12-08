using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////NAME : GoldObject : ItemObject
////PURPOSE : Lets use create a GoldObject asset file in the editor
[CreateAssetMenu(menuName = "Item/Gold", fileName = "Items")]
public class GoldObject : ItemObject
{
    public int amount;

    private void Awake()
    {
        type = ItemType.Gold;

    }
}
