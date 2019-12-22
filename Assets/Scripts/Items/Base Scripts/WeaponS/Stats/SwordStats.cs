using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordStats : WeaponStats
{
    private void Start()
    {
        
    }
    public SwordStats()
    {
        attackSpeed = 1;
        attackMinDamage = 1;
        attackMaxDamage = 8;
        isOneHanded = true;
    }
}
