using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USaveSlotSelectButton : UIButton
{
    public override void Clicked()
    {
        GameSaveManager.SetCurrentSlot(transform.parent.name);
        //load desired scene here
    }
}
