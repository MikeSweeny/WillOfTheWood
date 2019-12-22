using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongSpearStats : WeaponStats
{
    public LongSpearStats()
    {
        attackSpeed = 1;
        attackMinDamage = 1;
        attackMaxDamage = 10;
        isTwoHanded = true;
        isLongWeapon = true;
    }
}
