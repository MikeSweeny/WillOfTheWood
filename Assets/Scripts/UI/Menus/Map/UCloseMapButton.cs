using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UCloseMapButton : UIButton
{
    public override void Clicked()
    {
        UIEventManager.TriggerCloseMapMenu();
    }
}
