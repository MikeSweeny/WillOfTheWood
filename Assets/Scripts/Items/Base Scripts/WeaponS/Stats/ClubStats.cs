using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClubStats : WeaponStats
{
    public ClubStats()
    {
        weaponType = weaponTypes.ONEHANDED;
        attackSpeed = 1;
        attackMinDamage = 1;
        attackMaxDamage = 6;
    }
}
