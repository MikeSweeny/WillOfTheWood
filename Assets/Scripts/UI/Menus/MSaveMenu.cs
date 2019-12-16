//FILE          :   MSaveMenu.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   12/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : MSaveMenu
//PURPOSE : serves as the save menu
public class MSaveMenu : Menu
{
    private SaveSlot slot1;
    private SaveSlot slot2;
    private SaveSlot slot3;

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    void Awake()
    {
        gameObject.SetActive(false);
        UIEventManager.OpenSaveMenu += OpenMenu;
        UIEventManager.CloseSaveMenu += CloseMenu;
    }



    //Function : OnDestroy
    //DESCRIPTION : Called when the object is destroyed
    //PARAMETERS : none
    //RETURNS : none
    private void OnDestroy()
    {
        UIEventManager.OpenSaveMenu -= OpenMenu;
        UIEventManager.CloseSaveMenu -= CloseMenu;
    }
}
