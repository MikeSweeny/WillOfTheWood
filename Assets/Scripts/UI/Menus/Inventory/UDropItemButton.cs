using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDropItemButton : UIButton
{
    private IPlayerInventory inventory;
    private Item targetItem;

    public override void Clicked()
    {
        inventory.RemoveItem(targetItem);
    }

    public void SetInventory(IPlayerInventory inventory)
    {
        this.inventory = inventory;
    }

    public void SetTargetItem(Item item)
    {
        targetItem = item;
    }
}
