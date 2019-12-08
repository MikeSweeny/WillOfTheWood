using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////NAME : WeaponObject : ItemObject
////PURPOSE : Lets use create a WeaponObject asset file in the editor
[CreateAssetMenu(menuName = "Item/Weapon", fileName = "Items")]
public class WeaponObject : ItemObject
{

    public int maxDamage;
    public int minDamage;

    private void Awake()
    {
        type = ItemType.Weapon;
    }

    public void AttackRoll()
    {
        Random.Range(minDamage, maxDamage);
    }
    public override void UseItem()
    {
        // Equip Stuff Here.
    }
}
