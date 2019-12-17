//FILE          :   UInventoryButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   13/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UInventoryButton
//PURPOSE : opens the inventory menu
public class UInventoryButton : UIButton
{

    //Function : Clicked
    //DESCRIPTION : calls the function in the UI event manager that opens the inventory
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerClosePause();
        UIEventManager.TriggerOpenInventory();
    }
}
