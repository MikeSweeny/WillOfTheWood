using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortSpearStats : WeaponStats
{
    public ShortSpearStats()
    {
        weaponType = weaponTypes.TWOHANDED;
        attackSpeed = 1;
        attackMinDamage = 1;
        attackMaxDamage = 8;
    }
}
