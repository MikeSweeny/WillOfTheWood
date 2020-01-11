using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UInventorySlotButton : UIButton
{
    private Item item;
    private MInventory invMenu;

    public override void Clicked()
    {
        invMenu.SetSelectedItem(item);
    }

    public void SetInvMenu(MInventory mInventory)
    {
        invMenu = mInventory;
    }

    public void SetItem(Item itemRef)
    {
        item = itemRef;
    }
}
