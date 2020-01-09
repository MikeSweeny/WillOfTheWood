using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUnlockPolearmMasteryButton : UIButton
{
    public override void Clicked()
    {
        AbilityManager.TriggerUnlockPoleArmMastery();
    }
}
