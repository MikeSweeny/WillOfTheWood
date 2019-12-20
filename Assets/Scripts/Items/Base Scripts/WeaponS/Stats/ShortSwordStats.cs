using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortSwordStats : WeaponStats
{
    public ShortSwordStats()
    {
        attackSpeed = 1.5f;
        attackMinDamage = 1f;
        attackMaxDamage = 6f;
        isDagger = true;
        isOneHanded = true;
    }

}
