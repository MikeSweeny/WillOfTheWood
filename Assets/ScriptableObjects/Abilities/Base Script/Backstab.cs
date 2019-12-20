using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Backstab", menuName = "Abilities/Backstab")]
public class Backstab : Abilities
{
    private bool isActive { get; set; }
    PlayerStats stats;
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
        stats.defence = stats.defence - 1;
        if(stats.defence <= 0)
        {
            stats.defence = 0;
        }

        if (stats.isDetected == false)
        {
            isNovice = true;
            additionalDamage();
        }
    }
    public override void adeptLevelAct()
    {
        stats.defence = stats.defence - 1;
        if (stats.defence <= 0)
        {
            stats.defence = 0;
        }

        if (!stats.isDetected == false)
        {
            isAdept = true;
            additionalDamage();
        }
    }
    public override void masterLevelAct()
    {
        if (!stats.isDetected == false)
        {
            isMaster = true;
            additionalDamage();

        }
    }
    public void additionalDamage()
    {
        if(isNovice || isAdept)
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