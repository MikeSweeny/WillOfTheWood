//FILE          :   UInventoryMenuButton
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   07/01/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UInventoryMenuButton
//PURPOSE : Opens the inventory menu
public class UInventoryMenuButton : UIButton
{
    //Function : Clicked
    //DESCRIPTION : Calls the function in the UI event manager that closes the pause menu
    // and opens the inventory menu
    //PARAMETERS :  none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerClosePause();
        UIEventManager.TriggerOpenInventory();
    }
}
