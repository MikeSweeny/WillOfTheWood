//FILE          :   MInventory.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   11/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME : MInventory
//PURPOSE : serves as the inventory menu
public class MInventory : Menu
{
    private Transform slotHolder;
    private Sprite defaultSlotSprite;
    private int invContentsCount;
    private const int MAXCONTENTSCOUNT = 16;

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    void Awake()
    {
        UIEventManager.OpenInventory += OpenMenu;
        UIEventManager.CloseInventory += CloseMenu;
        slotHolder = transform.Find("InventorySlotHolder");
        defaultSlotSprite = GameObject.Instantiate(slotHolder.GetChild(0)).GetComponent<InventorySlot>().GetImageSprite();
    }

    //Function : OnDestroy
    //DESCRIPTION : Called when the object is destroyed
    //PARAMETERS : none
    //RETURNS : none
    private void OnDestroy()
    {
        UIEventManager.OpenInventory -= OpenMenu;
        UIEventManager.CloseInventory -= CloseMenu;
    }

    //Function : GetMaxCount
    //DESCRIPTION : gets the max number of items in the inventory
    //PARAMETERS : none
    //RETURNS : int maxContentsCount : the maximum amount of items in the inventory
    public int GetMaxCount()
    {
        return MAXCONTENTSCOUNT;
    }

    //Function : GetCurrentCount
    //DESCRIPTION : gets the current number of items in the inventory
    //PARAMETERS : none
    //RETURNS : int invContentsCount : the current amount of items in the inventory
    public int GetCurrentCount()
    {
        return invContentsCount;
    }

    //Function : IncrementCurrentCount
    //DESCRIPTION : increments the current content count
    //PARAMETERS : none
    //RETURNS : none
    public void IncrementCurrentCount()
    {
        invContentsCount++;
    }

    //Function : IncrementCurrentCount
    //DESCRIPTION : decrements the current content count
    //PARAMETERS : none
    //RETURNS : none
    public void DecrementCurrentCount()
    {
        invContentsCount--;
    }

    //Function : UpdateSlots
    //DESCRIPTION : updates inventory menu slots
    //PARAMETERS : List<Item> inventory : the player inventory
    //RETURNS : none
    public void UpdateSlots(List<Item> inventory)
    {
        for (int i = 0; i < MAXCONTENTSCOUNT; ++i)
        {
            if (i < inventory.Count)
            {
                slotHolder.GetChild(i).GetComponent<InventorySlot>().SetImageSprite(inventory[i].GetSprite().sprite);
            }
            else
            {
                slotHolder.GetChild(i).GetComponent<InventorySlot>().SetImageSprite(defaultSlotSprite);
            }
        }
    }
}
