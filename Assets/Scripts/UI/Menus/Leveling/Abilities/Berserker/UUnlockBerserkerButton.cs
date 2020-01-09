using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUnlockBerserkerButton : UIButton
{
    public override void Clicked()
    {
        AbilityManager.TriggerUnlockBerserker();
    }
}
