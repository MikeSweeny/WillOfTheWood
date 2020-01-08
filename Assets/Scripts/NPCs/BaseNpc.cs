//FILE: BaseNpc.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 01/01/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME: BaseNpc
//PURPOSE: the parent class for the different types of NPCs
public class BaseNpc : CharacterBase
{


    public NpcPathing pathingPattern;
    public EnemyObject npcBrain;
    public int vigilant;

    //Function: SetPathingComp
    //DESCRIPTION: sets the pathingPattern variable
    //PARAMETERS: None
    //RETURNS: None
    protected void SetPathingComp()
    {
        pathingPattern = GetComponent<NpcPathing>();
    }

    //Function: RoamingPatterns
    //DESCRIPTION: function used to cycle between a waiting pattern and a just patrolling pattern
    //PARAMETERS: None
    //RETURNS: None
    protected void RoamingPatterns()
    {
        if (pathingPattern.WaypointContainer && pathingPattern.canWait)
        {
            pathingPattern.WaitWhilePathing();
        }
        else if (pathingPattern.WaypointContainer && pathingPattern.canWait == false)
        {
            pathingPattern.RoamingPath();
        }
    }

    //Function: setStats
    //DESCRIPTION: function used to set local variables
    //PARAMETERS: None
    //RETURNS: None
    public void setStats()
    {
        accuracy = npcBrain.accuracy;
        speed = npcBrain.quick;
        strong = npcBrain.strong;
        toughness = npcBrain.toughness;
        vigilant = npcBrain.vigilant;
    }

    //FUNCTION : getStats()
    //DESCRIPTION : Getting the Stats from the objectBrain
    //PARAMETERS : void
    //RETURNS : void
    public void getStats()
    {
        npcBrain.Initialize();
    }

}
