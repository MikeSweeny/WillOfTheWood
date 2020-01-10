using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotbarSlot
{
    public Abilities ability { get; set; }
    private Sprite abilityIcon;
    public void AbilityAct()
    {
        if(ability != null)
        {
            ability.Act();
        }
    }
}
