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
    public Item testItem;
    protected List<Image> slotImages;
    private Image defaultSlotImage;
    private int invContentsCount;
    private int maxContentsCount;

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    void Awake()
    {
        gameObject.SetActive(false);
        slotImages = new List<Image>();
        UIEventManager.OpenInventory += OpenMenu;
        UIEventManager.CloseInventory += CloseMenu;
        Transform slotHolder = transform.Find("InventorySlotHolder");
        maxContentsCount = slotHolder.childCount;
        for (int i = 0; i < maxContentsCount; ++i)
        {
            slotImages.Add(transform.GetChild(i).GetComponent<Image>());
        }
        defaultSlotImage.Equals(slotImages[0]);
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
        return maxContentsCount;
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
        for (int i = 0; i < maxContentsCount; ++i)
        {
            if (i < invContentsCount)
            {
                slotImages[i] = inventory[i].GetSprite();
            }
            else
            {
                slotImages[i] = defaultSlotImage;
            }
        }
    }
}
