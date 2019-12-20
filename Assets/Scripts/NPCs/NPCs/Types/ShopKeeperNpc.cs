//FILE: ShopKeeperNpc.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 12/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME: ShopKeeperNpc
//PURPOSE: this class will outline what is supposed to happen with the shop NPCs
public class ShopKeeperNpc : BaseInteractableNpc
{
    public GameObject shopDisplayWindow;

    private Inventory shopInventory;
    private Player player;


    //Function: OnInteract
    //DESCRIPTION: this function is an override from the parent class so that this npc knows what to do when its interacted with
    //PARAMETERS: None
    //RETURNS: None
    public override void OnInteract()
    {
        
    }
}
