﻿
//File Header:
//FILE : PlayerObject.cs
////PROJECT : WillOfTheWood
//PROGRAMMER : Jeff
//FIRST VERSION : 06/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class Header:
////NAME : PlayerObject : EntityObject
////PURPOSE : Lets use create a PlayerObject asset file in the editor
[CreateAssetMenu (menuName = "Entity/Player", fileName = "Player")]
public class PlayerObject : EntityObject

{   [Tooltip("Grab the Players Primary Stats Asset files variables for this class to use")]
    public StatSet pStats;
    [HideInInspector]
    public int gold;
    [HideInInspector]
    public int accuracy;
    [HideInInspector]
    public int cunning;
    [HideInInspector]
    public int discrete;
    [HideInInspector]
    public int pursuasive;
    [HideInInspector]
    public int quick;
    [HideInInspector]
    public int strong;
    [HideInInspector]
    public int vigilant;
    [HideInInspector]


    ////FUNCTION : Initialize()
    ////DESCRIPTION : Setting the Stats from the ScriptableObject (StatsSet) to the Enttiy that needs it
    ////PARAMETERS : Void
    ////RETURNS : void
    public void Initialize()
    {
        accuracy = pStats.accuracy;
        cunning = pStats.cunning;
        discrete = pStats.discrete;
        pursuasive = pStats.pursuasive;
        quick = pStats.quick;
        strong = pStats.strong;
        vigilant = pStats.vigilant;

    }
}