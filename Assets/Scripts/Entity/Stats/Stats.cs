//File Header:
//FILE : Stats.cs
//PROJECT : WillofTheWood
//PROGRAMMER : Jeff Oldfield
//FIRST VERSION : 08/12/2019

using System.Collections.Generic;
using UnityEngine;
//Class Header:
////NAME : StatsObject : ScriptableObject
////PURPOSE : builds a base set of Attributes to be changed in the editor and appilied to various gameobjects

public abstract class StatsObject : ScriptableObject
{
    [SerializeField]
    public int Accuracy { get; set; }
    public int Cunning { get; set; }
    public int Discrete { get; set; }
    public int Pursuasive { get; set; }
    public int Quick { get; set; }
    public int Strong { get; set; }
    public int Vigilant { get; set; }



    ////FUNCTION : IncreaseStat
    ////DESCRIPTION : Increasing a Stat
    ////PARAMETERS : int _value, int _secondValue
    ////RETURNS : type and use  
    public virtual void IncreaseStat(int _value, int _secondValue) { }

    ////FUNCTION : DecreaseStat
    ////DESCRIPTION : decreasing a stat
    ////PARAMETERS : int _value, int _secondValue
    ////RETURNS : type and use  
    public virtual void DecreaseStat(int _value) { }
    ////FUNCTION : ApplyMod
    ////DESCRIPTION :Apply a Mod
    ////PARAMETERS : int _value, int _secondValue
    ////RETURNS : type and use  
    public virtual void ApplyMod(int _value) { }

}
//Class Header:
////NAME : Stats
////PURPOSE : giving the ScriptableObjects we creat the variables in the BaseClass
public class Stats
{
    public int accuracy;
    public int discrete;
    public int pursuasive;
    public int quick;
    public int strong;
    public int vigilant;


    //Function Header:
    //FUNCTION : Entitiy()
    //DESCRIPTION : Initialize child Classes with the information set in the Entity : ScriptableObjects class
    //PARAMETERS : EntityObject entity
    //RETURNS : VOID

    public Stats(StatsObject stats)
    {
        accuracy = stats.Accuracy;
        discrete = stats.Discrete;
        pursuasive = stats.Pursuasive;
        quick = stats.Quick;
        strong = stats.Strong;
        vigilant = stats.Vigilant;
    }

}
