using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorStats
{
    protected int minDefence;
    protected int maxDefence;

    public float GetMinDamageModifier()
    {
        return minDefence;
    }
    public float GetMaxDamageModifier()
    {
        return maxDefence;
    }

}
