//FILE          :   UCloseOptionsButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   16/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UCloseOptionsMenu
//PURPOSE : calls the function to close the options menu
public class UCloseOptionsButton : UIButton
{ 

    //Function : Clicked
    //DESCRIPTION : Calls the function in the UI event manager that closes the options menu
    // and opens the main/pause menu
    //PARAMETERS :  none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerOpenMainMenu();
        UIEventManager.TriggerOpenPause();
        UIEventManager.TriggerOptionsClose();
    }
}
