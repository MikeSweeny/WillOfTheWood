//FILE          :   IPlayerInventory.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   06/01/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME : IPlayerInventory
//PURPOSE : handles all player inventory specific logic
public class IPlayerInventory : Inventory
{
    private MInventory inventoryMenu;

    //Function : Start
    //DESCRIPTION : called when the object is initialized after Awake
    //PARAMETERS : none
    //RETURNS : none
    public IPlayerInventory()
    {
        inventoryMenu = GameObject.Find("InventoryCanvas").GetComponent<MInventory>();
        
    }

    //Function : AddItem
    //DESCRIPTION : adds an item to the inventory so long as the inventory is not full
    //PARAMETERS : Item item : the item to add to the inventory
    //RETURNS : none
    public override void AddItem(Item item)
    {
        if (inventoryMenu.GetCurrentCount() + 1 < inventoryMenu.GetMaxCount())
        { 
            base.AddItem(item);
            inventoryMenu.IncrementCurrentCount();
        }
    }

    //Function : RemoveItem
    //DESCRIPTION : removes an item from the inventory
    //PARAMETERS : Item item : the item to remove from the inventory
    //RETURNS : none
    public override void RemoveItem(Item item)
    {
        base.RemoveItem(item);
        inventoryMenu.DecrementCurrentCount();
    }
}
