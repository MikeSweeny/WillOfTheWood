using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUnlockBackStabButton : UIButton
{
    public override void Clicked()
    {
        AbilityManager.TriggerUnlockBackStab();
    }
}
