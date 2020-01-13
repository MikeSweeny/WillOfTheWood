using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UShopItemButton : UIButton
{
    private Item item;
    private CharacterBase target;

    public override void Clicked()
    {
        //throw new System.NotImplementedException();
    }

    public void SetItem(Item item)
    {
        this.item = item;
    }

    public void SetTarget(CharacterBase character)
    {
        target = character;
    }
}
