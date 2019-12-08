using System.Collections;
using System.Collections.Generic;
using UnityEngine;
////NAME : ArmourObject : ItemObject
////PURPOSE : Lets use create a ArmourObject asset file in the editor

[CreateAssetMenu(menuName = "Item/Armour", fileName = "Items")]
public class ArmourObject : ItemObject
{
    private void Awake()
    {
        type = ItemType.Armour;
    }
}
