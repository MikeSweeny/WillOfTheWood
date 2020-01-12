using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UCloseShopButton : UIButton
{
    public override void Clicked()
    {
        UIEventManager.TriggerCloseShop();
    }
}
