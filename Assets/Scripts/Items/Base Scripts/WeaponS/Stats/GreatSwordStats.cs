using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatSwordStats : WeaponStats
{
    public GreatSwordStats()
    {
        attackSpeed = 1;
        attackMinDamage = 1;
        attackMaxDamage = 10;
        isTwoHanded = true;
    }
    
}
