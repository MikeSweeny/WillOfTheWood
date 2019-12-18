using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Backstab", menuName = "Abilities/Backstab")]
public class Backstab : Abilities
{
    private bool isActive { get; set; }

    public override void OnLoad()
    {
        if (isCollected)
        {
            if (isNovice)
            {
                if (isActive)
                {
                    noviceLevelAct();
                }
            }
            else if (isAdept)
            {
                if (isActive)
                {
                    adeptLevelAct();
                }
            }
            else if (isMaster)
            {
                if (isActive)
                {
                    masterLevelAct();
                }
            }
        }
    }
    public override void noviceLevelAct()
    {
        //player defence = defence - 1
        //
        //if(sneakAttack)
        //{
        //      equippedWeapon.AttackRoll();
        //      additionalDamage();
        //}
        //else
        //{
        //      equippedWeapon.AttackRoll();
        //}
    }
    public override void adeptLevelAct()
    {
        //player defence = defence - 1
        //
        //if(sneakAttack)
        //{
        //      equippedWeapon.AttackRoll();
        //      additionalDamage();
        //      bleedOut();
        //}
        //else
        //{
        //      equippedWeapon.AttackRoll();
        //}
    }
    public override void masterLevelAct()
    {
        //if(sneakAttack)
        //{
        //      equippedWeapon.AttackRoll();
        //      additionalDamage();
        //      bleedOut();
        //}
        //else
        //{
        //      equippedWeapon.AttackRoll();
        //}
    }
    public void additionalDamage()
    {
        if(isNovice)
        {
            Random.Range(1, 6);
        }
        else if (isMaster)
        {
            Random.Range(1, 8);
        }
    }
    public void bleedOut()
    {
        //trigger isBleeding bool on enemy attacked and apply following for loop to the enemy code.
        //
        //for (int i = 0; i < 10f; i++)
        //{
        //    enemyHealth = enemyHealth - 1
        //}
    }
}