using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElvenArmourStats : ArmorStats
{
    public ElvenArmourStats()
    {
        armourType = armourTypes.LIGHT;
        minDefence = 1;
        maxDefence = 8;
    }
}
