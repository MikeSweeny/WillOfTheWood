using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotbarSlot
{
    Abilities ability { get; set; }

    public void AbilityAct()
    {
        if(ability != null)
        {
            ability.Act();
        }
    }
}
