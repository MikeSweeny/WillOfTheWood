using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UInventoryMenuButton : UIButton
{
    public override void Clicked()
    {
        UIEventManager.TriggerClosePause();
        UIEventManager.TriggerOpenInventory();
    }
}
