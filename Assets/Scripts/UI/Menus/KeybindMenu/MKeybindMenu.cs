//FILE          :   MKeybindMenu.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   16/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : MKeybindMenu
//PURPOSE : serves as the keybind menu
public class MKeybindMenu : Menu
{

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    private void Awake()
    {
        gameObject.SetActive(false);
        UIEventManager.OpenKeybindMenu += OpenMenu;
        UIEventManager.CloseKeybindMenu += CloseMenu;
    }

    //Function : OnDestroy
    //DESCRIPTION : Called when the object is destroyed
    //PARAMETERS : none
    //RETURNS : none
    private void OnDestroy()
    {
        UIEventManager.OpenKeybindMenu -= OpenMenu;
        UIEventManager.CloseKeybindMenu -= CloseMenu;
    }
}
