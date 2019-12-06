//FILE          :   EnemyUnit.cs
//PROJECT       :   Will of the Woods
//PROGRAMMER    :   Timothy Olenio
//FIRST VERSION :   06/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : EnemyUnit
//PURPOSE : represents a singular enemy unit for the final battle
public class BEnemyUnit : BattleUnit
{
    private const int TIERTOENEMYCOUNT = 10;
    public BEnemyUnit(int tier):
    base(tier)
    { }

    //Function : EnemyUnitsToSpawn
    //DESCRIPTION : Multiplies the TIERTOENEMYCOUNT by the 
    //              the unitTier from BattleUnits. 
    //PARAMETERS : none
    //RETURNS : int : The amount of enemies per waves 
    private int EnemyUnitsToSpawn()
    {
        int units = unitTier * TIERTOENEMYCOUNT;
        return units;
    }


   
}
