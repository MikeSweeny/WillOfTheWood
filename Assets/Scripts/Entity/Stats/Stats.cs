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
    public int Accuracy { get; set; }
    public int Discrete { get; set; }
    public int Pursuasive { get; set; }
    public int Speed { get; set; }
    public int Strong { get; set; }
    public int Vigilant { get; set; }
    public int Defence { get; set; }
    ////FUNCTION : IncreaseStat
    ////DESCRIPTION : Increasing a Stat
    ////PARAMETERS : int _value, int _secondValue
    ////RETURNS : type and use  
    public virtual void IncreaseStat(int _value, int _secondValue) { }

    ////FUNCTION : DecreaseStat
    ////DESCRIPTION : decreasing a stat
    ////PARAMETERS : int _value, int _secondValue
    ////RETURNS : type and use  
    public virtual void DecreaseStat(int _value, int _secondValue) { }

    public virtual int GetMod(int _statValue)  { return 0; }
}
