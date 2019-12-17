//FILE          :   UCloseKeybindButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   17/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UCloseKeybindButton
//PURPOSE : closes the keybind menu
public class UCloseKeybindButton : UIButton
{

    //Function : Clicked
    //DESCRIPTION : calls the function in the UI event manager that opens the options menu
    // and closes the keybind menu
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerCloseKeybindMenu();
        UIEventManager.TriggerOptionsOpen();
    }
}
