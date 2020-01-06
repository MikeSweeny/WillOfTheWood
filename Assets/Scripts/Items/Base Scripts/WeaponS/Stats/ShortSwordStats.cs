using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortSwordStats : WeaponStats
{
    public ShortSwordStats()
    {
        weaponType = weaponTypes.ONEHANDED;
        weaponType = weaponTypes.DAGGER;
        attackSpeed = 1;
        attackMinDamage = 1;
        attackMaxDamage = 6;
    }

}
