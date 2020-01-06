using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceStats : WeaponStats
{
    public MaceStats()
    {
        weaponType = weaponTypes.ONEHANDED;
        attackSpeed = 1;
        attackMinDamage = 1;
        attackMaxDamage = 8;
    }
}
