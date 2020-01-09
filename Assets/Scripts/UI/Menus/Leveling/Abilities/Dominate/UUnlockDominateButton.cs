using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUnlockDominateButton : UIButton
{
    public override void Clicked()
    {
        AbilityManager.TriggerUnlockDominate();
    }
}
