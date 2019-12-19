using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats 
{
    protected float attackSpeed;
    protected float attackMinDamage;
    protected float attackMaxDamage;
    protected bool isOneHanded = false;
    protected bool isTwoHanded = false;
    protected bool isDagger = false;
    protected bool isLongWeapon = false;

    public float GetAttackSpeed()
    {
        return attackSpeed;
    }
    public float GetAttackMinDamage()
    {
        return attackMinDamage;
    }
    public float GetAttackMaxDamage()
    {
        return attackMaxDamage;
    }
}
