using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class Header:
////NAME : SecondaryStatsObject : ScriptableObject
////PURPOSE : Creating a Set of seconday stats for Entities to use.

public abstract class SecondaryStatsObject : ScriptableObject
{
    public int Armour { get; set; }
    public int Defence { get; set; }
    public int Toughness { get; set; }
    public int PainThreshold { get; set; }
}
//Class Header:
////NAME : className
////PURPOSE : what the class is for
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