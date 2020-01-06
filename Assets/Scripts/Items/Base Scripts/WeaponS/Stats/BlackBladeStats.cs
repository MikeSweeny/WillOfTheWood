using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBladeStats : WeaponStats
{
    public BlackBladeStats()
    {
        weaponType = weaponTypes.TWOHANDED;
        attackSpeed = 2;
        attackMinDamage = 4;
        attackMaxDamage = 15;
    }
}
