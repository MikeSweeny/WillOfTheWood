using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortSwordStats : WeaponStats
{
    public ShortSwordStats()
    {
        attackSpeed = 1;
        attackMinDamage = 1;
        attackMaxDamage = 6;
        isDagger = true;
        isOneHanded = true;
    }

}
