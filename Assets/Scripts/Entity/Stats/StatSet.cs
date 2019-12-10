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
[CreateAssetMenu(menuName = "Stats/Primary Stats", fileName = "Primary Stats")]
public class StatSet : StatsObject
{
    [Range(5, 20)]
    public int accuracy;
    [Range(5, 20)]
    public int cunning;
    [Range(5, 20)]
    public int discrete;
    [Range(5, 20)]
    public int pursuasive;
    [Range(5, 20)]
    public int quick;
    [Range(5, 20)]
    public int strong;
    [Range(5, 20)]
    public int vigilant;
    private void Awake()
    {
        Accuracy = 5;
        Cunning = 5;
        Discrete = 5;
        Pursuasive = 5;
        Quick = 5;
        Strong = 5;
        Vigilant = 5;
        accuracy = Accuracy;
        cunning = Cunning;
        discrete = Discrete;
        pursuasive = Pursuasive;
        quick = Quick;
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

