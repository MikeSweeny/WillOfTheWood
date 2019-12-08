using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Item/Armour", fileName = "Items")]
public class ArmourObject : ItemObject
{
    private void Awake()
    {
        type = ItemType.Armour;
    }
}
