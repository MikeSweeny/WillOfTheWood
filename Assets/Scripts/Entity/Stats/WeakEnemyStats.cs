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
[CreateAssetMenu(menuName = "Stats/EnemyStats/Weak", fileName = "Weak Stats")]
public class WeakEnemyStats : StatsObject
{
    [Range(5, 18)]
    public int accuracy;
    [Range(5, 18)]
    public int quick;
    [Range(5, 18)]
    public int strong;
    [Range(5, 18)]
    public int vigilant;
    private void Awake()
    { 
        Accuracy = 9;
        Speed = 8;
        Strong = 8;
        vigilant = 10;

        accuracy = Accuracy;
        quick = Speed;
        strong = Strong;
        vigilant = Vigilant;
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
    
}

