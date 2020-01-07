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
    protected int attackSpeed;
    protected int attackMinDamage;
    protected int attackMaxDamage;
    public enum weaponTypes {ONEHANDED,TWOHANDED,DAGGER,LONG,BLACKBLADE}
    public weaponTypes weaponType;
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
    public int GetAttackMinDamage()
    {
        return attackMinDamage;
    }
    //Function : GetAttackMaxDamage
    //DESCRIPTION : checks weapons attack maximum damage
    //PARAMETERS : none
    //RETURNS : attackMaxDamage
    public int GetAttackMaxDamage()
    {
        return attackMaxDamage;
    }
    public void SetAttackMinDamageModifier(int changeMin)
    {
        attackMinDamage = attackMinDamage + changeMin;
    }
    public void SetAttackMaxDamageModifier(int changeMax)
    {
        attackMaxDamage = attackMaxDamage + changeMax;
    }
}
