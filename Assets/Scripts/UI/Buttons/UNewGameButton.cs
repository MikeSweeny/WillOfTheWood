using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNewGameButton : UIButton
{
    public override void Clicked()
    {
        GameEventManager.TriggerGameStart();
    }
}
