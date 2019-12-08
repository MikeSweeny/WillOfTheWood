using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StatsObject : ScriptableObject
{ 
    public int Accuracy { get; set; }
    public int Cunning { get; set; }
    public int Discrete { get; set; }
    public int Pursuasive { get; set; }
    public int Quick { get; set; }
    public int Strong { get; set; }
    public int Vigilant { get; set; }



    public virtual void IncreaseStat(int _value, int _secondValue) { }
    public virtual void DecreaseStat(int _value) { }
    public virtual void ApplyMod(int _value) { }

}
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
