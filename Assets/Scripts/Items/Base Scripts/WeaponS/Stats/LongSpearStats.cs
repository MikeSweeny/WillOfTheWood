using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongSpearStats : WeaponStats
{
    public LongSpearStats()
    {
        weaponType = weaponTypes.TWOHANDED;
        weaponType = weaponTypes.LONG;
        attackSpeed = 1;
        attackMinDamage = 1;
        attackMaxDamage = 10;
    }
}
