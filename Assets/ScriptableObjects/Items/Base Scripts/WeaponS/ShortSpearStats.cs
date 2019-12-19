using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortSpearStats : WeaponStats
{
    public ShortSpearStats()
    {
        attackSpeed = 0.75f;
        attackMinDamage = 1f;
        attackMaxDamage = 8f;
        isTwoHanded = true;
        isLongWeapon = true;
    }
}
