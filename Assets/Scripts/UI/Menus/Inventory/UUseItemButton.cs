using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUseItemButton : UIButton
{
    private Item targetItem;

    public override void Clicked()
    {
        targetItem.Use();
    }

    public void SetTargetItem(Item item)
    {
        targetItem = item;
    }
}
