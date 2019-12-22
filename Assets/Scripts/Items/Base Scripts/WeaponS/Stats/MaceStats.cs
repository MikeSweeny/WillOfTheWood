using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceStats : WeaponStats
{
    public MaceStats()
    {
        attackSpeed = 1;
        attackMinDamage = 1;
        attackMaxDamage = 8;
        isOneHanded = true;
    }
}
