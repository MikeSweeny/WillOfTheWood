
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
{
    public StatSet pStats;
    //public PlayerController player;
    //Other Player Needed things.
    int accuracy;
    int cunning;
    int discrete;
    int pursuasive;
    int quick;
    int strong;
    int vigilant;
    private void Awake()
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
