//FILE          :   IWeapon.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   18/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : IWeapon
//PURPOSE : the base class for weapons
public class IWeapon : Item
{
    protected WeaponStats stats;
    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    public void Awake()
    {
        itemType = ItemTypes.WEAPON;
    }

    public WeaponStats GetStats()
    {
        return stats;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Random.Range(stats.GetAttackMinDamage(), stats.GetAttackMaxDamage());
    }
}
