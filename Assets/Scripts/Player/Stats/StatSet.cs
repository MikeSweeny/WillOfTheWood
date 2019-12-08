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
[CreateAssetMenu(menuName ="Stats/Statsets", fileName = "Primary Stats")]
public class StatSet : StatsObject
{
    [Range(0, 20)]
    public int accuracy;
    [Range(0, 20)]
    public int cunning;
    [Range(0, 20)]
    public int discrete;
    [Range(0, 20)]
    public int pursuasive;
    [Range(0, 20)]
    public int quick;
    [Range(0, 20)]
    public int strong;
    [Range(0, 20)]
    public int vigilant;



    private void Awake()
    {
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
