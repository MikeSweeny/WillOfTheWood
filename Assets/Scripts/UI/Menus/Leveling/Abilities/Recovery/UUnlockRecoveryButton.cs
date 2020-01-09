using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUnlockRecoveryButton : UIButton
{
    public override void Clicked()
    {
        AbilityManager.TriggerUnlockRecovery();
    }
}
