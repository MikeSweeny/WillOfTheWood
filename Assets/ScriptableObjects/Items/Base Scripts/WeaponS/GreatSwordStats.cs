using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatSwordStats : WeaponStats
{
    public GreatSwordStats()
    {
        attackSpeed = 0.5f;
        attackRange = 1.75f;
        attackMinDamage = 1f;
        attackMaxDamage = 10f;
        isTwoHanded = true;
    }
}
