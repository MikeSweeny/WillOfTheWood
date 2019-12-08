using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatType
{ 
    Accuracy,
    Cunning,
    Discrete,
    Pursuasive,
    Quick,
    Strong,
    Vigilant,
    Health
}

public abstract class Stats : ScriptableObject
{
    public new string name;
    public int statValue;
    public int statMod;
    public StatType type;

    [TextArea(15, 20)]
    public string description;

    public virtual void IncreaseStat(int _value) { }
    public virtual void DecreaseStat(int _value) { }
    public virtual void ApplyMod(int _value) { }

}

public class stat
{
    public string name;
    public int value;
    public int mod;
    public StatType type;

    public stat(Stats stat)
    {
        name = stat.name;
        value = stat.statValue;
        mod = stat.statMod;
        type = stat.type;
    }
}
