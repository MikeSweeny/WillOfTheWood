using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUnlockTwinAttackButton : UIButton
{
    public override void Clicked()
    {
        AbilityManager.TriggerUnlockTwinAttack();
    }
}
