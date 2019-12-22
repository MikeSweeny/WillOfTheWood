//FILE          :   UCloseInventoryButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   22/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UCloseInventoryButton
//PURPOSE : calls the function that closes the inventory
public class UCloseInventoryButton : UIButton
{
    //Function : Clicked
    //DESCRIPTION : Calls the function in the UI event manager that closes the Inventory menu
    // and opens the pause menu
    //PARAMETERS :  none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerCloseInventory();
        UIEventManager.TriggerOpenPause();
    }
}
