using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ULoadSlotSelectButton : UIButton
{
    public override void Clicked()
    {
        GameSaveManager.SetCurrentSlot(transform.parent.name);
        //load desired scene here
    }
}
