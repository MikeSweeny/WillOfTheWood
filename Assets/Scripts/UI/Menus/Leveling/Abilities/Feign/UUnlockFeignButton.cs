using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUnlockFeignButton : UIButton
{
    public override void Clicked()
    {
        AbilityManager.TriggerUnlockFeign();
    }
}
