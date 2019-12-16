//FILE          :   UKeybindMenuButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   16/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UKeybindMenuButton
//PURPOSE : calls the function that opens the keybind menu
public class UKeybindMenuButton : UIButton
{

    //Function : Clicked
    //DESCRIPTION : calls the function in the UI event manager that closes the options menu
    // and opens the keybind menu
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerOptionsClose();
        UIEventManager.TriggerOpenKeybindMenu();
    }
}
