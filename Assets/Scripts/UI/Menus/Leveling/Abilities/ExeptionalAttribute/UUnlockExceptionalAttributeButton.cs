using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUnlockExceptionalAttributeButton : UIButton
{
    public override void Clicked()
    {
        AbilityManager.TriggerUnlockExceptionalAttribute();
    }
}
