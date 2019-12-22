using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortSpearStats : WeaponStats
{
    public ShortSpearStats()
    {
        attackSpeed = 1;
        attackMinDamage = 1;
        attackMaxDamage = 8;
        isTwoHanded = true;
        isLongWeapon = true;
    }
}
