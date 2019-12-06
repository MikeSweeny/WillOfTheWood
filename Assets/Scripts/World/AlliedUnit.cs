//FILE          :   AlliedUnit.cs
//PROJECT       :   Will of the Woods
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   06/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : AlliedUnit
//PURPOSE : represents a singular allied unit for the final battle
public class BAlliedUnit : BattleUnit 
{
    public BAlliedUnit(int tier) :
        base(tier)
    { }
    
    //Function : Strengthen
    //DESCRIPTION : raises unit tier by a set amount
    //PARAMETERS : int amount : the amount by which to raise the tier
    //RETURNS : none
    public void Strengthen(int amount)
    {
        if (unitTier < 5)
            unitTier += amount;
    }
}
