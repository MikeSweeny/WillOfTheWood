using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UClosePauseMenuButton : UIButton
{
    public override void Clicked()
    {
        GameEventManager.TriggerUnPause();
    }
}
