using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////NAME : WeaponObject : ItemObject
////PURPOSE : Lets use create a WeaponObject asset file in the editor
[CreateAssetMenu(menuName = "Item/Weapon", fileName = "New Weapon")]
public class WeaponObject : ItemObject
{

    public int maxDamage;
    public int minDamage;
    public bool isDagger;
    public bool isOneHanded;
    public bool isTwoHanded;
    public bool effectApplied;
    public List<Abilities> abilityEffects;

    private void Awake()
    {
        type = ItemType.Weapon;
    }

    public void AttackRoll()
    {
        if(effectApplied)
        {
            WeaponEffect();
            Random.Range(minDamage, maxDamage);
        }
        else
        {
            Random.Range(minDamage, maxDamage);
        }
;
    }
    public override void UseItem()
    {
        // Equip Stuff Here.
    }
    public void WeaponEffect()
    {
        if(effectApplied)
        {
            //search through list of effects and use the one being applied.
        }
    }
}
