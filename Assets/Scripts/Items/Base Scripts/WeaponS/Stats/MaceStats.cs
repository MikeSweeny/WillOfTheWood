using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceStats : WeaponStats
{
    public MaceStats()
    {
        attackSpeed = 0.75f;
        attackMinDamage = 1f;
        attackMaxDamage = 8f;
        isOneHanded = true;
    }
}
