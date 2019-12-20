using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongSpearStats : WeaponStats
{
    public LongSpearStats()
    {
        attackSpeed = 0.5f;
        attackMinDamage = 1f;
        attackMaxDamage = 10f;
        isTwoHanded = true;
        isLongWeapon = true;
    }
}
