//FILE          :   WeaponStats.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   18/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : WeaponStats
//PURPOSE : The base class for all weapon stats
public class WeaponStats 
{
    protected float attackSpeed;
    protected float attackMinDamage;
    protected float attackMaxDamage;
    protected bool isOneHanded = false;
    protected bool isTwoHanded = false;
    protected bool isDagger = false;
    protected bool isLongWeapon = false;
    //Function : GetAttackSpeed
    //DESCRIPTION : checks weapons attack speed
    //PARAMETERS : none
    //RETURNS : attackSpeed
    public float GetAttackSpeed()
    {
        return attackSpeed;
    }
    //Function : GetAttackMinDamage
    //DESCRIPTION : checks weapons attack minimum damage
    //PARAMETERS : none
    //RETURNS : attackMinDamage
    public float GetAttackMinDamage()
    {
        return attackMinDamage;
    }
    //Function : GetAttackMaxDamage
    //DESCRIPTION : checks weapons attack maximum damage
    //PARAMETERS : none
    //RETURNS : attackMaxDamage
    public float GetAttackMaxDamage()
    {
        return attackMaxDamage;
    }
}
