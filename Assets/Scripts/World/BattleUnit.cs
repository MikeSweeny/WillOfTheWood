//FILE          :   BattleUnit.cs
//PROJECT       :   Will of the Woods
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   06/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : BattleUnit
//PURPOSE : interact with other units for the final battle
public class BattleUnit
{
    protected int unitTier;
    private const int MINRANGE = 0;
    private const int MAXRANGE = 20;


    public BattleUnit(int tier)
    {
        unitTier = tier;
    }

    //Function : SkillCheck
    //DESCRIPTION : adds a random value in range to unit tier
    //PARAMETERS : none
    //RETURNS : int : indicating battle performance
    public int SkillCheck()
    {
        return (unitTier + Random.Range(MINRANGE, MAXRANGE));
    }

    //Function : Weaken
    //DESCRIPTION : lowers unit's tier by a set amount
    //PARAMETERS : int amount : the amount by which to reduce the tier
    //RETURNS : none
    public void Weaken(int amount)
    {
        unitTier -= amount;
    }
}
