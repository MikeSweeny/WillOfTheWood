
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
    [Tooltip("Grab the Players Secondary Stats Asset files variables for this class to use")]
    public SecondaryStatsSet pSecondaryStats;
    //public AbilitySet pAbilityes;
    //public PlayerController player;
    //public Inventory inventory;
    public int gold;
    public int accuracy;
    public int cunning;
    public int discrete;
    public int pursuasive;
    public int quick;
    public int strong;
    public int vigilant;
    public int armour;
    public int toughness;
    public int defence;
    public int painThreshold;


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
        armour = pSecondaryStats.armour;
        toughness = pSecondaryStats.toughness;
        defence = pSecondaryStats.defence;
        painThreshold = pSecondaryStats.painThreshold;

    }


}
