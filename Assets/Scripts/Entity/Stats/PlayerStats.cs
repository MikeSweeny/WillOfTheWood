﻿//File Header:
////FILE : StatSet.cs
////PROJECT : WillOfTheWood
////PROGRAMMER : Jeff Oldfield
////FIRST VERSION : 13/12/2019


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Class Header:
////NAME : StatSet : StatsObject
////PURPOSE : Creating a Set of Attributes to be refrenced when making a new Entity
[CreateAssetMenu(menuName = "Stats/PlayerStats", fileName = "PlayerStats")]
public class PlayerStats : StatsObject
{
    [Range(5, 18)]
    public int accuracy;
    [Range(5, 18)]
    public int discrete;
    [Range(5, 18)]
    public int pursuasive;
    [Range(5, 18)]
    public int quick;
    [Range(5, 18)]
    public int strong;

    private int modValue;
    private void Awake()
    {
        Accuracy = 10;
        Discrete = 10;
        Pursuasive = 10;
        Quick = 10;
        Strong = 10;

        accuracy = Accuracy;
        discrete = Discrete;
        pursuasive = Pursuasive;
        quick = Quick;
        strong = Strong;
    }


    //Function Header:
    ////FUNCTION : IncreaseStat
    ////DESCRIPTION : Incresing an Attribute
    ////PARAMETERS : int _value, int _statValue  (_value is the number to increase by, _statValue is the Stat to increase)
    ////RETURNS : 
    public override void IncreaseStat(int _value, int _statValue)
    {
        _value += _statValue;
    }

    public override int GetMod(int _statValue)
    {
        if (_statValue == 5)
        {
            return 5;
        }
        else
        {
            return 0;
        }

    }
}


