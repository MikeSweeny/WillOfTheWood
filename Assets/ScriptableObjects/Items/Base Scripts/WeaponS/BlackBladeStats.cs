using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBladeStats : WeaponStats
{
    public BlackBladeStats()
    {
        attackSpeed = 0.75f;
        attackRange = 1.75f;
        attackMinDamage = 4f;
        attackMaxDamage = 15f;
        isTwoHanded = true;
    }
}
