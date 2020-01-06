﻿//FILE          :   MInventory.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   11/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME : MInventory
//PURPOSE : serves as the inventory menu
public class MInventory : Menu
{

    protected List<Image> slotImages;

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    void Awake()
    {
        gameObject.SetActive(false);
        slotImages = new List<Image>();
        UIEventManager.OpenInventory += OpenMenu;
        UIEventManager.CloseInventory += CloseMenu;
    }

    //Function : OnDestroy
    //DESCRIPTION : Called when the object is destroyed
    //PARAMETERS : none
    //RETURNS : none
    private void OnDestroy()
    {
        UIEventManager.OpenInventory -= OpenMenu;
        UIEventManager.CloseInventory -= CloseMenu;
    }
}
