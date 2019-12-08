using System.Collections;
using System.Collections.Generic;
using UnityEngine;
////NAME : OtherItemObject : ItemObject
////PURPOSE : Lets use create a OtherItemObject (Or Misc) asset file in the editor

[CreateAssetMenu(menuName = "Item/other", fileName = "Items")]
public class OtherItemObject : ItemObject
{
    private void Awake()
    {
        type = ItemType.Other;
    }
}
