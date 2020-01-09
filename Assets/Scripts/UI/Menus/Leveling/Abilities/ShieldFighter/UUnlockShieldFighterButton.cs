using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUnlockShieldFighterButton : UIButton
{
    public override void Clicked()
    {
        AbilityManager.TriggerUnlockShieldFighter();
    }
}
