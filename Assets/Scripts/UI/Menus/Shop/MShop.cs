//FILE          :   MShop.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   11/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : MShop
//PURPOSE : serves as the shop menu
public class MShop : Menu
{
    private CharacterBase target;
    private Player player;
    private const int shopSlotCount = 5;
    private List<ShopItemSlot> shopSlots;
    private List<ShopItemSlot> playerSlots;

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    void Awake()
    {
        gameObject.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        UIEventManager.OpenShop += OpenMenu;
        UIEventManager.OpenShop += TargetShopMenu;
        UIEventManager.CloseShop += CloseMenu;
        shopSlots = new List<ShopItemSlot>();
        playerSlots = new List<ShopItemSlot>();
        Transform holder = transform.GetChild(0).Find("ShopInventorySlotHolder");
        for (int i = 0; i < shopSlotCount; ++i)
        {
            shopSlots.Add(holder.GetChild(i).GetComponent<ShopItemSlot>());
        }
        holder = transform.GetChild(0).Find("InventorySlotHolder");
        for (int i = 0; i < holder.childCount; ++i)
        {
            playerSlots.Add(holder.GetChild(i).GetComponent<ShopItemSlot>());
        }
    }

    private void Update()
    {
        
    }

    private void TargetShopMenu()
    {
        target = player.FindPlayerTarget().GetComponent<CharacterBase>();
        for (int i = 0; i < shopSlots.Count; ++i)
        {
            shopSlots[i].SetButtonTarget(player);
        }
        for (int i = 0; i < playerSlots.Count; ++i)
        {
            playerSlots[i].SetButtonTarget(target);
        }
    }

    //Function : OnDestroy
    //DESCRIPTION : Called when the object is destroyed
    //PARAMETERS : none
    //RETURNS : none
    private void OnDestroy()
    {
        UIEventManager.OpenShop -= OpenMenu;
        UIEventManager.CloseShop -= CloseMenu;
    }
}
