//FILE          :   UnitManager.cs
//PROJECT       :   Will of the Woods
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   09/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UnitManager
//PURPOSE : manages Units for final battle
public class UnitManager
{
    private static BAlliedUnit[] allies;
    private static BEnemyUnit[] enemies;

    //Function : UnitsDoBattle
    //DESCRIPTION : runs inter-unit combat logic
    //PARAMETERS : none
    //RETURNS : none
    public static void UnitsDoBattle()
    {
        int minUnitDamage = 0;
        int maxUnitDamage = 2;
        if (allies != null && enemies != null)
        {
            for (int i = 0; i < allies.Length; ++i)
            {
                if (!allies[i].IsDefeated() && !allies[i].HasFought())
                { 
                    for (int j = 0; j < enemies.Length; ++j)
                    {
                        if (!enemies[j].IsDefeated() && !enemies[j].HasFought() && !enemies[j].HasSpawned())
                        {
                            int allyRating = allies[i].SkillCheck();
                            int enemyRating = enemies[j].SkillCheck();
                            if (allyRating > enemyRating)
                            {
                                enemies[j].Defeat();
                                allies[i].Weaken(Random.Range(minUnitDamage, maxUnitDamage));
                            }
                            else if (allyRating < enemyRating)
                            {
                                allies[i].Defeat();
                                enemies[j].Weaken(Random.Range(minUnitDamage, maxUnitDamage));
                            }
                        }
                    }
                }
            }
        }
    }

    //Function : GetEnemyUnit
    //DESCRIPTION : returns a capable enemy unit to convert into a wave
    //PARAMETERS : none
    //RETURNS : BEnemyUnit indicating a battle-ready unit, if null end battle
    public static BEnemyUnit GetEnemyUnit(int wave)
    {
        for (int i = wave; i < enemies.Length; ++i)
        {
            if (!enemies[i].IsDefeated() && !enemies[i].HasSpawned())
            {
                return enemies[i];
            }
        }

        return null;
    }
}
