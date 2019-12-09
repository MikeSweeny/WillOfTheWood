using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SecondaryStatsObject : ScriptableObject
{
    public int Armour { get; set; }
    public int Defence { get; set; }
    public int Toughness { get; set; }
    public int PainThreshold { get; set; }
}

public class SecondaryStats
{
    public int armour;
   public int defence;
   public int toughness;
   public int painThreshold;

    public SecondaryStats (SecondaryStatsObject secondaryStats)
    {
        armour = secondaryStats.Armour;
        defence = secondaryStats.Defence;
        toughness = secondaryStats.Toughness;
        painThreshold = secondaryStats.PainThreshold;
    }
}