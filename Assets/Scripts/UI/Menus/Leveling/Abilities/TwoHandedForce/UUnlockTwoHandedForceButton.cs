using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUnlockTwoHandedForceButton : UIButton
{
    public override void Clicked()
    {
        AbilityManager.TriggerUnlockTwoHandedForce();
    }
}
