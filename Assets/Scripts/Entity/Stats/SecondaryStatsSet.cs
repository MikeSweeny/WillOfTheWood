//File Header:
////FILE : StatSet.cs
////PROJECT : WillOfTheWood
////PROGRAMMER : Jeff Oldfield
////FIRST VERSION : 08/12/2019


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class Header:
////NAME : StatSet : StatsObject
////PURPOSE : Creating a Set of Attributes to be refrenced when making a new Entity
[CreateAssetMenu(menuName = "Stats/SecondaryStatsSet", fileName = "Secondary Stats")]
public class SecondaryStatsSet : SecondaryStatsObject
{
    [Range(0, 20)]
    public int armour;
    [Range(0, 20)]
    public int defence;
    [Range(0, 20)]
    public int toughness;
    [Range(0, 20)]
    public int painThreshold;



    private void Awake()
    {
        armour = Armour;
        defence = Defence;
        toughness = Toughness;
        painThreshold = PainThreshold;
    }
    //Function Header:
    ////FUNCTION : IncreaseStat
    ////DESCRIPTION : Incresing an Attribute
    ////PARAMETERS : int _value, int _statValue  (_value is the number to increase by, _statValue is the Stat to increase)
    ////RETURNS : 

}

