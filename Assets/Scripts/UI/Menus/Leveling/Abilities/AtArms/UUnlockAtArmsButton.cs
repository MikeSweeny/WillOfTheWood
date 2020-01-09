using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUnlockAtArmsButton : UIButton
{
    public override void Clicked()
    {
        AbilityManager.TriggerUnlockAtArms();
    }
}
