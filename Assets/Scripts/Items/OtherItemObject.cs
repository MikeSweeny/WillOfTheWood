using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Item/other", fileName = "Items")]

public class OtherItemObject : ItemObject
{
    private void Awake()
    {
        type = ItemType.Other;
    }
}
