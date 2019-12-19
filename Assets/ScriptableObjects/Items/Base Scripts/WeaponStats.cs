using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats 
{
    protected float attackSpeed;
    protected float attackMinDamage;
    protected float attackMaxDamage;

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
