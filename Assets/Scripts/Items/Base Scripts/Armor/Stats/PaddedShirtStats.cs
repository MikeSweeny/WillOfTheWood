using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddedShirtStats : ArmorStats
{
    public PaddedShirtStats()
    {
        armourType = armourTypes.LIGHT;
        minDefence = 1;
        maxDefence = 4;
    }
}
