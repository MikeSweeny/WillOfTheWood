using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUnlockPoisonerButton : UIButton
{
    public override void Clicked()
    {
        AbilityManager.TriggerUnlockPoisoner();
    }
}
