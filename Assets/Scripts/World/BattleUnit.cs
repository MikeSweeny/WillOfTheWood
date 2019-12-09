//FILE          :   BattleUnit.cs
//PROJECT       :   Will of the Woods
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   06/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : BattleUnit
//PURPOSE : interact with other units for the final battle
[System.Serializable]
public class BattleUnit
{
    protected int unitTier;
    protected bool defeated;
    private bool fought;
    private bool spawned;
    private const int MINRANGE = 0;
    private const int MAXRANGE = 20;


    public BattleUnit(int tier)
    {
        unitTier = tier;
        defeated = false;
        fought = false;
        spawned = false;
        //WaveManager.StartWave += StartWave;
    }

    //Function : SkillCheck
    //DESCRIPTION : adds a random value in range to unit tier
    //PARAMETERS : none
    //RETURNS : int : indicating battle performance
    public int SkillCheck()
    {
        fought = true;
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

    //Function : Defeat
    //DESCRIPTION : Sets bool that marks the unit's defeat
    //PARAMETERS : none
    //RETURNS : none
    public void Defeat()
    {
        defeated = true;
    }

    //Function : IsDefeated
    //DESCRIPTION : returns the bool that marks the unit's defeat
    //PARAMETERS : none
    //RETURNS : bool defeated : indicating whether the 
    public bool IsDefeated()
    {
        return defeated;
    }

    //Function : HasFought
    //DESCRIPTION : returns whether the unit has fought this wave or no
    //PARAMETERS : none
    //RETURNS : bool fought : indicates if the unit has fought this round
    public bool HasFought()
    {
        return fought;
    }

    //Function : Spawn
    //DESCRIPTION : sets the unit so it has spawned
    //PARAMETERS : none
    //RETURNS : none
    public void Spawn()
    {
        spawned = true;
    }

    //Function : HasSpawned
    //DESCRIPTION : returns a bool stating whether the unit has spawned
    //PARAMETERS : none
    //RETURNS : bool spawned : indicates if the unit has spawned
    public bool HasSpawned()
    {
        return spawned;
    }

    //Function : WaveStart
    //DESCRIPTION : prepares unit for new wave cycle
    //PARAMETERS : none
    //RETURNS : none
    private void WaveStart()
    {
        fought = false;
    }
}
