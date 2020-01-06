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
    //Function : AdditionalDamage
    //DESCRIPTION : returns additional damage int between 1 - 6
    //PARAMETERS : none
    //RETURNS : none
    public int AdditionalDamage()
    {
        int AD;
        AD = Random.Range(1, 6);
        return AD;
    }
}
