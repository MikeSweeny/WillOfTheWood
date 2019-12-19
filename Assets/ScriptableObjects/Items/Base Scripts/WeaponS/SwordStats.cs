using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordStats : WeaponStats
{
    public SwordStats()
    {
        attackSpeed = 1f;
        attackMinDamage = 1f;
        attackMaxDamage = 8f;
        isOneHanded = true;
    }
}
